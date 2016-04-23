using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas.TheNaturalStringSortingKata
{
    public class NaturalStringSorting
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public List<string> SortString(string[] strItems)
        {
            return SortString(strItems, SortOrder.Ascending);
        }

        public List<string> SortString(string[] strItems, SortOrder order)
        {
            Func<string, object> convert = str =>
            {
                try
                {
                    return int.Parse(str);
                }
                catch
                {
                    return str;
                }
            };

            return GetSortedList(strItems, order, convert);

        }

        private static List<string> GetSortedList(IEnumerable<string> strItems, SortOrder order,
            Func<string, object> convert)
        {
            List<string> sorted;
            switch (order)
            {
                case SortOrder.Descending:
                    sorted = strItems.OrderByDescending(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
                default:
                    sorted = strItems.OrderBy(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
            }
            return sorted;
        }

    }
}