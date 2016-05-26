using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Char;
using static System.String;

namespace Katas.StringSum
{
    public static class AnotherStringSumKata
    {

        /// <summary>
        /// The character shift
        /// The zero char in unicode equals 48, so if we subtract 48 from char We'll have int value of char
        /// </summary>
        private const int CharShift = 48;

        public static string Sum(string left, string right)
        {
            left = IsNaturalNumber(left) ? left : "0";
            right = IsNaturalNumber(right) ? right : "0";

            left = CompleteZeroLeftOperand(left, right);
            right = CompleteZeroLeftOperand(right, left);

            var sb = new StringBuilder();
            var memoryDischarge = false;

            for (int i = left.Length - 1; i >= 0; i--)
            {
                int current = CharToInt(left[i]) + CharToInt(right[i]);
                if (memoryDischarge)
                {
                    current++;
                    memoryDischarge = false;
                }
                if (current >= 10)
                {
                    sb.Insert(0, current % 10);
                    memoryDischarge = true;
                }
                else
                {
                    sb.Insert(0, current);
                }
            }
            if (memoryDischarge)
            {
                sb.Insert(0, '1');
            }
            return sb.ToString();
        }

        private static int CharToInt(char c)
        {
            return c - CharShift;
        }

        private static bool IsNaturalNumber(string number)
        {
            return !IsNullOrEmpty(number) && number.All(IsDigit);
        }

        private static string CompleteZeroLeftOperand(string left, string right)
        {
            return left.Length < right.Length ? left.PadLeft(right.Length, '0') : left;
        }
    }
}
