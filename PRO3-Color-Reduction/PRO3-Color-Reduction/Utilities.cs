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

        static public Color ApproximateColor(Color toApproximate, List<Color> candidates)
        {
            Color[] candidatesArray = candidates.ToArray();
            return candidates[FindClosestApproximate(toApproximate, candidatesArray)];
        }

        static public int FindClosestApproximate(Color toApproximate, Color[] candidates)
        {
            if (candidates == null || candidates.Length == 0) throw new Exception("FindNearestCentroid - centroid list was null");

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
