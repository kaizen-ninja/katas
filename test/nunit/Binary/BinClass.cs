using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.NUnit
{
    class BinClass
    {
        int x;
        string s = "";
        public BinClass(int x)
        {
            this.x = x;
        }

        public int Solution()
        {
            int maxcount = 0;
            int count = 0;
            s = ConvertToBin();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    count += 1;
                }
                if (s[i] == '1')
                {
                    maxcount = Math.Max(maxcount, count);
                    count = 0;
                }
            }
            return maxcount;
        }

        public string ConvertToBin()
        {
            while (x > 0)
            {
                if (x % 2 == 0)
                {
                    s = "0" + s;
                }
                else
                    s = "1" + s;
                x /= 2;
            }
            return s;
        }
    }
}
