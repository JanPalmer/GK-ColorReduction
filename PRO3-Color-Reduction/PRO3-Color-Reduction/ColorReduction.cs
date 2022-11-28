using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace PRO3_Color_Reduction
{
    static public class ColorReduction
    {
        public const int colorsPerByte = 256;

        // Popularity Color Reduction
        static public Bitmap PopularityQuantization(Bitmap source, int colorCount, ProgressBar progressBar, int newWidth = 0, int newHeight = 0)
        {
            if(newWidth == 0 || newHeight == 0)
            {
                newWidth = source.Width;
                newHeight = source.Height;
            }

            Bitmap sourceCopy = new Bitmap(source);
            //Bitmap result = new Bitmap(source, newWidth, newHeight);

            Dictionary<Color, long> histogram =
                HistogramCreator.CreateHistogram(source, colorsPerByte);

            List<KeyValuePair<Color, long>> histogramList = histogram.ToList();
            histogramList.Sort((a, b) => a.Value.CompareTo(b.Value));

            //List<Color> selectedColors = new List<Color>(histogramList.GetRange(0, colorCount).);
            List<Color> selectedColors = new List<Color>();

            for (int i = 0; i < colorCount; i++) selectedColors.Add(histogramList[i].Key);

            Color currentColor, approxColor;
            for(int y = 0; y < sourceCopy.Height; y++)
            {
                for(int x = 0; x < sourceCopy.Width; x++)
                {
                    currentColor = source.GetPixel(x, y);
                    approxColor = Utilities.ApproximateColor(currentColor, selectedColors);
                    sourceCopy.SetPixel(x, y, approxColor);
                }

                progressBar.Value = (int)(((float)(y + 1) / (float)sourceCopy.Height) * progressBar.Maximum);
            }

            return new Bitmap(sourceCopy, newWidth, newHeight);
        }

        // K-Means Color Reduction (K-Means Clustering)
        static public Bitmap KMeansQuantization(Bitmap source, int colorCount, int epsilon, ProgressBar progressBar, int newWidth = 0, int newHeight = 0)
        {
            if (colorCount <= 0) throw new Exception("KMeansQuantization - colorCount invalid\n");

            if (newWidth == 0 || newHeight == 0)
            {
                newWidth = source.Width;
                newHeight = source.Height;
            }

            Bitmap sourceCopy = new Bitmap(source);

            var random = new Random();
            bool isChange = true;

            int k = colorCount;
            Color[] centroids = new Color[k];

            Vector3[] sums = new Vector3[k];
            int[] counts = new int[k];

            int[,] pixelsCentroidIndex = new int[sourceCopy.Width, sourceCopy.Height];

            for (int i = 0; i < k; i++) centroids[i] = sourceCopy.GetPixel(random.Next(k), random.Next(k));

            int iterationCount = 0;
            const int maxIterationCount = 1000;

            while(isChange && iterationCount < maxIterationCount)
            {
                iterationCount++;

                for(int y = 0; y < source.Height; y++)
                    for(int x = 0; x < source.Width; x++)
                    {
                        Color c = source.GetPixel(x, y);
                        pixelsCentroidIndex[x, y] = Utilities.FindClosestApproximate(c, centroids);
                        sums[pixelsCentroidIndex[x, y]].X += c.R;
                        sums[pixelsCentroidIndex[x, y]].Y += c.G;
                        sums[pixelsCentroidIndex[x, y]].Z += c.B;
                        counts[pixelsCentroidIndex[x, y]]++;
                    }

                isChange = false;
                for(int i = 0; i < k; i++)
                {
                    if (counts[i] == 0) continue;

                    int r = (int)(sums[i].X / counts[i]);
                    int g = (int)(sums[i].Y / counts[i]);
                    int b = (int)(sums[i].Z / counts[i]);

                    Color newColor = Color.FromArgb(r, g, b);

                    if(Utilities.CalculateColorDistance(centroids[i], newColor) > epsilon)
                    {
                        isChange = true;
                        centroids[i] = newColor;
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    sums[i].X = 0; sums[i].Y = 0; sums[i].Z = 0;
                }
                Array.Clear(counts, 0, k);

                progressBar.Value = (int)((float)iterationCount / (float)maxIterationCount * progressBar.Maximum);
            }

            for (int y = 0; y < source.Height; y++)
                for (int x = 0; x < source.Width; x++)
                    sourceCopy.SetPixel(x, y, centroids[pixelsCentroidIndex[x, y]]);

            return sourceCopy;
        }
    }
}
