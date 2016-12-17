using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.CalcStats
{
    class CalcStats
    {
        
        public double MinValue(List<double> set)
        {
            return set.Min();
        }
        public double MaxValue(List<double> set)
        {
            return set.Max();
        }
        public double AverageValue(List<double> set)
        {
            double summ = 0;
            for (int i = 0; i < set.Count; i++)
            {
                summ += set[i];
            }
            return (int)summ/NumberOfElementsInTheSequence(set);
        }
        public int NumberOfElementsInTheSequence(List<double> set)
        {
            int counter = 0;
            for (int i = 0; i < set.Count; i++)
            {
                counter++;
            }
            return counter;
        }
    }
}
