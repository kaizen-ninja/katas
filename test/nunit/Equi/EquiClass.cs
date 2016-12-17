using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.NUnit
{
    public class EquiClass
    {
        int[] array;
        public EquiClass(int[] array)
        {
            this.array = array;
        }
        public int Solution()
        {
            int value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        value += array[j];
                    }
                    if (value == 0) return i;
                    else value = 0;
                }
                else if(i == array.Length - 1)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        value += array[j];
                    }
                    if (value == 0) return i;
                    else value = 0;
                }
                else if (i > 0 && i < (array.Length - 1))
                {
                    if(Value(i, false) == Value(i, true)) return i;
                }
            }
            return -1;
        }
        public int Value(int idx, bool rl)
        {
            int value = 0;
            if (rl == false)
            {
                for (int i = 0; i < idx; i++)
                {
                    value += array[i];
                }
            }
            else
            {
                for (int i = idx + 1; i < array.Length; i++)
                {
                    value += array[i];
                }
            }
            return value;
        }
    }
}
