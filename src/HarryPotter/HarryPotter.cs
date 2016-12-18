using System;
using System.Linq;

namespace Katas.TheHarryPotterKata
{
    public class HarryPotterShop
    {
        public double HarryPotter(int n1 = 0, int n2 = 0, int n3 = 0, int n4 = 0, int n5 = 0)
        {
            double result = 0;
            double bookPrice = 8;
            int[] a = { n1, n2, n3, n4, n5 };
            int count = 0;
            while (a.Sum() > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (a[i] > 0)
                    {
                        a[i]--;
                        count++;
                    }
                }
                switch (count)
                {
                    case 1:
                        result += bookPrice;
                        break;
                    case 2:
                        result += bookPrice * count * 0.95;
                        break;
                    case 3:
                        result += bookPrice * count * 0.90;
                        break;
                    case 4:
                        result += bookPrice * count * 0.80;
                        break;
                    case 5:
                        result += bookPrice * count * 0.75;
                        break;
                }
                count = 0;
            }

            return result;
        }
    }
}