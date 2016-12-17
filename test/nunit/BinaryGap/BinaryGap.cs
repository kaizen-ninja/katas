using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BinaryGap
{
    class BinaryGap
    {
        public int Solution(int n)
        {
            string val = Convert.ToString(n, 2);
            int max = 0;
            int counter = 0;

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == '0')
                {
                    counter++;
                }
                else
                {
                    if (counter > max)
                        max = counter;
                    counter = 0;
                }
            }
            return max;
        }
    }
}
