using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Katas.TheCalcStatsKata
{
    public class CalcStat
    {
        public static void Solution(int[] arr)
        {
            int n = 0, min = 0, max = 0;
            double AverageValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n++;
                AverageValue += arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            AverageValue = AverageValue / arr.Length;
        }
    }
}