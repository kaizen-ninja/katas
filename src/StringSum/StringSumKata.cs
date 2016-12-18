using System;

namespace Katas.TheStringSum
{
    public class StringSumKata
    {
        public int StringSum(string num1, string num2)
        {
            int result = 0;
            string[] s = { num1, num2 };
            foreach (string n in s)
            {
                if (IsNatural(n))
                    result += int.Parse(n);
            }
            return result;
        }

        public bool IsNatural(string num)
        {
            int n;
            bool isInt = int.TryParse(num, out n);
            if (n > 0 && isInt)
                return true;
            else
                return false;
        }

    }
}