using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.NUnit
{
    class CalcClass
    {
        int[] array;
        public CalcClass(int[] array)
        {
            this.array = array;
        }
        public int Min()
        {
            return array.Min();
        }
        public int Max()
        {
            return array.Max();
        }
        public int Number()
        {
            return array.Length;
        }
        public double Average()
        {
            return Math.Round(array.Average(), 5);
        }
    }
}
