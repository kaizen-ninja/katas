using System.Collections.Generic;

namespace Katas.Equi
{
    public class Equi
    {
        public List<int> GetEqui(int n, int[] arr)
        {
            List<int> indx = new List<int>();
            int left = 0, right = 0;
           
                for (int j = 1; j < n-1; j++)
                {
                    for(int i = 0; i< j; i++)
                        left += arr[i];
                    for (int y = n- 1; y > j; y--)
                        right += arr[y];
                if (right == left)
                    indx.Add(j);
                left = 0;
                right = 0;  
                }

            for (int i = 1; i < n; i++)
                right += arr[i];
            if (right == 0)
                indx.Add(0);
            for (int i = n - 2; i >= 0; i--)
                left += arr[i];
            if (left == 0)
                indx.Add(n - 1);

            return indx;
        }
    }
}
