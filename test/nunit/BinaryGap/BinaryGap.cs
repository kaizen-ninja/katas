using System;

namespace Katas.BinaryGap
{
    public class BinaryGap
    {
        public string binary { get; private set; }  //  Число в двоичном виде
        int n;                                      //  Длина binaryGap
        int number;                                 //  Число в десятичном виде

        //  Конструктор класса
        public BinaryGap(int number)
        {
            this.number = number;
        }

        //  Находит бинарный разрыв
        public int Findbinarygap()
        {
            binary = Convert.ToString(number, 2);

            int n1 = 0;
            int n2 = n1;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    n1++;
                }
                else
                    n1 = 0;

                if (n1 > n)
                {
                    n2 = n;
                    n = n1;
                }

                if (i == binary.Length - 1 && binary[i] == '0')
                    n = n2;
            }

            return n;
        }

    }
}
