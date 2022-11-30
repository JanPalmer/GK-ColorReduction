using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PRO3_Color_Reduction
{
    static public class Utilities
    {
        static public int CalculateColorDistance(Color cv, Color cu)
        {
            int distR = cu.R - cv.R;
            int distG = cu.G - cv.G;
            int distB = cu.B - cv.B;

            return distR * distR + distG * distG + distB * distB;
        }

        static public List<Color> EquallySpacedColors(int numberOfColors)
        {
            List<Color> result = new List<Color>();

            if(numberOfColors <= 1)
            {
                result.Add(Color.White);
                return result;
            }

            double step = Math.Floor(0xFFFFFF / (double)(numberOfColors - 1));
            for(double i = 0; i <= 0xFFFFFF; i += step)
            {
                result.Add(Color.FromArgb((int)i));
            }

            return result;
        }

        static private int ApproximateColor_EquallySpaced_OneColor(int originalColor, int colorsNumber)
        {
            double rangeLength = 255.0 / (double)(colorsNumber - 1);
            int rangeNumber = (int)((double)originalColor / rangeLength);
            if (rangeNumber == colorsNumber) rangeNumber--;
            return (int)(rangeNumber * rangeLength);
        }
        static public Color ApproximateColor_EquallySpaced(Color toApproximate, int colorsNumber)
        {
            if (colorsNumber <= 1) return Color.White;

            int colorsR, colorsG, colorsB;
            colorsR = colorsG = colorsB = colorsNumber;

            int r = ApproximateColor_EquallySpaced_OneColor(toApproximate.R, colorsR);
            int g = ApproximateColor_EquallySpaced_OneColor(toApproximate.G, colorsG);
            int b = ApproximateColor_EquallySpaced_OneColor(toApproximate.B, colorsB);
            return Color.FromArgb(r, g, b);
        }

        static public Color ApproximateColor(Color toApproximate, List<Color> candidates)
        {
            Color[] candidatesArray = candidates.ToArray();
            return candidates[FindClosestApproximate(toApproximate, candidatesArray)];
        }

        static public int FindClosestApproximate(Color toApproximate, Color[] candidates)
        {
            if (candidates == null || candidates.Length == 0) throw new Exception("FindClosestApproximate - centroid list was null");

            int minDist = int.MaxValue, dist;
            int k = candidates.Length;
            int bestApproxIndex = 0;

            for(int i = 0; i < k; i++)
            {
                dist = CalculateColorDistance(toApproximate, candidates[i]);
                if (dist < minDist)
                {
                    minDist = dist;
                    bestApproxIndex = i;
                }
            }

            return bestApproxIndex;
        }
    }
}
