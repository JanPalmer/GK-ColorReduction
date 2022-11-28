using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PRO3_Color_Reduction
{
    static public class HistogramCreator
    {
        static public Dictionary<Color, long> CreateHistogram(Bitmap bitmap, int colorPerDimension)
        {
            Dictionary<Color, long> histogram = new Dictionary<Color, long>();
            Color currColor;

            for (int y = 0; y < bitmap.Height; y++)
                for(int x = 0; x < bitmap.Width; x++)
                {
                    currColor = bitmap.GetPixel(x, y);
                    if (histogram.ContainsKey(currColor) == false)
                        histogram.Add(currColor, 1);
                    else
                        histogram[currColor]++;
                }

            return histogram;
        }

    }
}
