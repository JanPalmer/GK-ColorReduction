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
        static public Bitmap PopularityQuantization
            (Bitmap source, int colorCount, ProgressBar progressBar = null)
        {
            if (colorCount <= 0) throw new Exception("PopularityQuantization - colorCount invalid\n");

            Bitmap result = new Bitmap(source);

            Dictionary<Color, long> histogram =
                HistogramCreator.CreateHistogram(source, colorsPerByte);

            if (histogram.Count <= colorCount) return result;

            List<KeyValuePair<Color, long>> histogramList = histogram.ToList();
            histogramList.Sort((a, b) => a.Value.CompareTo(b.Value));

            List<Color> selectedColors = new List<Color>();

            for (int i = 0; i < colorCount; i++) selectedColors.Add(histogramList[i].Key);

            Color currentColor, approxColor;
            for(int y = 0; y < result.Height; y++)
            {
                for(int x = 0; x < result.Width; x++)
                {
                    currentColor = source.GetPixel(x, y);
                    approxColor = Utilities.ApproximateColor(currentColor, selectedColors);
                    result.SetPixel(x, y, approxColor);
                }

                if(progressBar != null) progressBar.Value = (int)(((float)(y + 1) / (float)result.Height) * progressBar.Maximum);
            }

            return result;
        }

        // K-Means Color Reduction (K-Means Clustering)
        static public Bitmap KMeansQuantization
            (Bitmap source, int colorCount, int epsilon, ProgressBar progressBar = null)
        {
            if (colorCount <= 0) throw new Exception("KMeansQuantization - colorCount invalid\n");

            Bitmap result = new Bitmap(source);

            var random = new Random();
            bool isChange = true;

            int k = colorCount;
            Color[] centroids = new Color[k];

            Vector3[] sums = new Vector3[k];
            int[] counts = new int[k];

            int[,] pixelsCentroidIndex = new int[result.Width, result.Height];

            for (int i = 0; i < k; i++) centroids[i] = result.GetPixel(random.Next(k), random.Next(k));

            int iterationCount = 0;
            const int maxIterationCount = 1000;

            while(isChange && iterationCount < maxIterationCount)
            {
                iterationCount++;

                for(int y = 0; y < source.Height; y++)
                {
                    for(int x = 0; x < source.Width; x++)
                    {
                        Color c = source.GetPixel(x, y);
                        pixelsCentroidIndex[x, y] = Utilities.FindClosestApproximate(c, centroids);
                        sums[pixelsCentroidIndex[x, y]].X += c.R;
                        sums[pixelsCentroidIndex[x, y]].Y += c.G;
                        sums[pixelsCentroidIndex[x, y]].Z += c.B;
                        counts[pixelsCentroidIndex[x, y]]++;
                    }
                    if (progressBar != null) progressBar.Value = (int)(((float)(y + 1) / (float)result.Height) * progressBar.Maximum);
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
            }

            for (int y = 0; y < source.Height; y++)
                for (int x = 0; x < source.Width; x++)
                    result.SetPixel(x, y, centroids[pixelsCentroidIndex[x, y]]);

            return result;
        }
        
        // Error Diffustion Color Reduction
        public enum ErrorDiffusionMatrix
        {
            FloydSteinberg,
            Burkes,
            Stucky
        }

        static private float[,] FloydSteinbergFilter =
        { 
            { 0, 0, 0 }, 
            { 0, 0, 7f/16f }, 
            { 3f/16f, 5f/16f, 1f/16f }
        };
        static private float[,] BurkesFilter =
        { 
            { 0, 0, 0, 0, 0 }, 
            { 0, 0, 0, 8f / 32f, 4f / 32f }, 
            { 2f / 32f, 4f / 32f, 8f / 32f, 4f / 32f, 2f / 32f }
        };
        static private float[,] StuckyFilter =
        {
            {0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0 },
            {0, 0, 0, 8f/42f, 4f/42f },
            {2f/42f, 4f/42f, 8f/42f, 4f/42f, 2f/42f },
            {1f/42f, 2f/42f, 4f/42f, 2f/42f, 1f/42f }
        };

        static private void PropagateError(Bitmap bitmap, (int x, int y) p, float[,] filter, Vector3 errorValue)
        {
            int fy = (filter.GetLength(1) - 1) / 2;
            int fx = (filter.GetLength(0) - 1) / 2;
            for (int dy = 0; dy <= fy && p.y + dy < bitmap.Height; dy++)
                for (int dx = -fx; dx <= fx && p.x + dx < bitmap.Width; dx++)
                {
                    if (p.y + dy < 0 || p.x + dx < 0) continue;

                    float coef = filter[fx + dx, fy + dy];
                    Color currColor = bitmap.GetPixel(p.x + dx, p.y + dy);

                    int newR = (int)((float)currColor.R + errorValue.X * coef);
                    if (newR > 255) newR = 255;
                    if (newR < 0) newR = 0;
                    int newG = (int)((float)currColor.G + errorValue.Y * coef);
                    if (newG > 255) newG = 255;
                    if (newG < 0) newG = 0;
                    int newB = (int)((float)currColor.B + errorValue.Z * coef);
                    if (newB > 255) newB = 255;
                    if (newB < 0) newB = 0;

                    bitmap.SetPixel(p.x + dx, p.y + dy,  Color.FromArgb(newR, newG, newB));
                }
        }

        static public Bitmap ErrorDiffusionQuantization
            (Bitmap source, int colorCount, ErrorDiffusionMatrix matrixType, bool useK3Colors, ProgressBar progressBar = null)
        {
            if (colorCount <= 0) throw new Exception("PopularityQuantization - colorCount invalid\n");

            float[,] filter = FloydSteinbergFilter;
            switch (matrixType)
            {
                case ErrorDiffusionMatrix.FloydSteinberg:
                    filter = FloydSteinbergFilter;
                    break;
                case ErrorDiffusionMatrix.Burkes:
                    filter = BurkesFilter;
                    break;
                case ErrorDiffusionMatrix.Stucky:
                    filter = StuckyFilter;
                    break;
            }

            //filter = KosnoFilter;

            Bitmap result = new Bitmap(source);

            List<Color> selectedColors = Utilities.EquallySpacedColors(colorCount);

            Color currentColor, approxColor;
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    currentColor = result.GetPixel(x, y);
                    approxColor =
                        (useK3Colors == true)
                        ? Utilities.ApproximateColor_EquallySpaced(currentColor, colorCount)
                        : Utilities.ApproximateColor(currentColor, selectedColors);

                    result.SetPixel(x, y, approxColor);
                    Vector3 errorVal = new Vector3(currentColor.R - approxColor.R, currentColor.G - approxColor.G, currentColor.B - approxColor.B);
                    PropagateError(result, (x, y), filter, errorVal);
                }

                if (progressBar != null) progressBar.Value = (int)(((float)(y + 1) / (float)result.Height) * progressBar.Maximum);
            }

            return result;
        }
    }
}
