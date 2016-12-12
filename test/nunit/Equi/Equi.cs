using System.Collections.Generic;

namespace EquiKata
{
    public class Equi

    {
        public int[] array;


        public Equi(int[] array)
        {
            this.array = array;

        }
        public bool IsEquilibrium(int indexEl)
        {
            int summ1 = 0;
            int summ2 = 0;
            for (int i = 0; i < indexEl; i++)
            {
                summ1 += array[i];
            }
            for (int i = indexEl + 1; i < array.Length; i++)
            {
                summ2 += array[i];
            }
            return summ1 == summ2;


        }
        public List<int> GetIndexOfEquilibrium()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (IsEquilibrium(i))
                {
                    result.Add(i);
                }
            }


            return result.Count == 0 ? new List<int>() { -1 } : result;
        }
    }
}

