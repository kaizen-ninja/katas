using System;

namespace Katas.TheHarryPotterKata
{
    public class HarryPotterShop
    {
        float[] discountTiers;
        float bookPrice;

        public HarryPotterShop(float bookPrice, params float[] discounts)
        {
            this.bookPrice = bookPrice;
            discountTiers = discounts.Clone() as float[];
        }

        public float GetBasketSum(params int[] basketMask)
        {
            float sum = 0;
            int uniqueAmount;
            do
            {
                uniqueAmount = 0;
                for (int i = 0; i < basketMask.Length; i++)
                {
                    if (basketMask[i] > 0)
                    {
                        basketMask[i]--;
                        uniqueAmount++;
                    }
                }
                sum += uniqueAmount * bookPrice * GetDiscount(uniqueAmount);
            }
            while (uniqueAmount > 0);

            return sum;
        }

        public float GetDiscount(int uniqueAmount)
        {
            if (--uniqueAmount < 0)
            {
                return 0f;
            }
            return discountTiers[Math.Min(uniqueAmount, discountTiers.Length - 1)];
        }
    }
}