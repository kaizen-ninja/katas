using System;

namespace Katas.TheOddEvenKata
{
    public class OddEven
    {
        public static string Run(int n)
        {
            return DefineOddEvenOrPrime(n);
        }

        public static string Run(int firstNum, int lastNum)
        {
            string result = "";
            for (int i = firstNum; i < lastNum; i++)
            {
                result += DefineOddEvenOrPrime(i) + " ";
            }

            return result.Trim();
        }

        private static string DefineOddEvenOrPrime(int n)
        {
            if (IsPrime(n))
                return n.ToString();
            else if (n % 2 == 0)
                return "Even";
            else if (n % 2 != 0)
                return "Odd";

            return "Error";
        }

        private static bool IsPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(Math.Abs(n)) + 1; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}