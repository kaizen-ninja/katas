using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Equi
{
    class Equi
    {
        public int[] Solution(int[] arr)
        {
            int[] result = new int[arr.Length];
            int left = 0;               
            int rigth = 0;              
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                rigth += arr[i];
            }

            do
            {
                rigth -= arr[j];
                if (left == rigth)
                {
                    result[j] = 1;
                    left += arr[j];
                    j++;
                    continue;
                }
                else
                {
                    result[j] = 0;
                    left += arr[j];
                    j++;
                    continue;
                }
            } while (j != arr.Length);
            return result;
        }
    }
}
