using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BinaryGap
{
    static class BinaryGap
    {
        const int TwoPowerOfIntMax = 32;

        public static int GetGapSize(int number)
        {
            bool started = false;
            int maxGapLenght = 0;
            int currentGapLength = 0;

            for (int caret = 0; caret < TwoPowerOfIntMax; caret++)
            {
                int mask = 1 << caret;
                if ((number & mask) == mask)
                {
                    if (started)
                    {
                        maxGapLenght = Math.Max(maxGapLenght, currentGapLength);
                        currentGapLength = 0;
                    }
                    else started = true;
                }
                else if (started)
                {
                    currentGapLength++;
                }
            }
            return maxGapLenght;
        }
    }
}
