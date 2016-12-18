using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Katas.TheCalcStatsKata
{
    public class CalcStat
    {
        public static Dictionary<string, double> CalcStats(int[] array)
        {
            int min = array.Min();
            int max = array.Max();
            int count = array.Length;
            double average = array.Average();
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("Minimum", min);
            dict.Add("Maximum", max);
            dict.Add("Number of elements", count);
            dict.Add("Average value", average);
            return dict;
        }
    }
}