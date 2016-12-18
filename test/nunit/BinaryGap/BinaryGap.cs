using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class BinaryGap
    {
        public int Solution(int n)
        {
            string s = Convert.ToString(n, 2);
            int count = 0;
            int maxCount = 0;
            while (true)
            {
                char lastLetter = s[s.Length - 1];
                if (lastLetter == '1')
                    break;
                s = s.Substring(0, s.Length - 1);
            }
            while (s.Length > 0)
            {
                char lastLetter = s[s.Length - 1];
                if (lastLetter == '1')
                {
                    if (maxCount < count)
                        maxCount = count;
                    count = 0;
                }
                else
                    count++;
                s = s.Substring(0, s.Length - 1);
            }
            return maxCount;
        }
    }
}
