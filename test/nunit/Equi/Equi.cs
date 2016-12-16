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
            int left = 0;               //  Левая граница массива 
            int rigth = 0;              //  Правая граница массива 
            int sum = 0;                //  Сумма элементов массива
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            do
            {
                if (rigth != 0 || sum != 0)
                {
                    sum -= arr[j];
                    rigth = sum;
                    if (left == rigth)
                    {
                        result[j] = 1;
                    }
                    else
                    {
                        result[j] = 0;
                    }
                    left += arr[j];
                    j++;
                }
                else
                {
                    break;
                }
                continue;
            } while (left != rigth);
            return result;
        }
    }
}
