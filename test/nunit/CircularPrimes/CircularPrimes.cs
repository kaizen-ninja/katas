using System;
using System.Collections.Generic;

namespace Katas.CircularPrimes
{
    public class CircularPrimes
    {
        private bool IsPrimeNumber(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        private bool IsCircularPrimeNumber(int x)
        {
            // TODO: Nikitos, put here your ideas
            return IsPrimeNumber(x);
        }

        public List<int> GetDigits(int x)
        {
            var digits = new List<int>();
            // TODO: Nikitos, write loop
            digits.Add(x % 10);
            return digits;
        }

        public int CalcCircularPrimesCount(int n)
        {
            var primes = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsCircularPrimeNumber(i))
                {
                    Console.WriteLine(i);
                    primes++;
                }
            }
            return primes;
        }
    }
}