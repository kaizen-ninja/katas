using System.Collections.Generic;

namespace Katas.Equi
{
    public class Equi
    {
        
        public List<int> Solution(int[] array)
        {
            var result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (DivideSum(array, i))
                    result.Add(i);
            }
            return result;
        }

        public bool DivideSum(int[] array, int n)
        {
            int s1 = 0;
            int s2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < n)
                    s1 += array[i];
                else if (i > n)
                    s2 += array[i];
            }
            return s1 == s2;
        }
    }
}
