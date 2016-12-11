using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BinaryGap
{
    public class BinaryGap
    {
       public string ToBinary(int n)
        {

           return Convert.ToString(n, 2);
        } 
        public int Solution(int n)
        {
            var binary = ToBinary(n);
            List<int> lens = new List<int>();
            char prev = '0';
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0' && prev == '1')
                {
                    var count = FindEndOfGap(binary.Substring(i));
                    i += count;
                    lens.Add(count);
                }
                prev = binary[i];
            }
            return lens.Max();
        }

        public int FindEndOfGap(string str)
        {
            int i = 0;
            do i++;
            while (str[i] != '1');

            return i;
        }
    }
}
