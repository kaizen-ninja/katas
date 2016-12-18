using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Equi
{
    class Equi
    {
        public static int EquiRun(int[] a, int n)
        {
            int leftSum, rightSum;

            for (int i = 0; i < n; ++i)
            {
                leftSum = 0;
                rightSum = 0;

                for (int j = 0; j < i; j++)
                    leftSum += a[j];

                for (int j = i + 1; j < n; j++)
                    rightSum += a[j];

                if (leftSum == rightSum)
                    return i;
            }

            return -1;
        }
    }
}
