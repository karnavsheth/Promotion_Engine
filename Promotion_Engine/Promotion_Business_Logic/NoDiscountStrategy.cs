using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine.Promotion_Business_Logic
{
    /* Concrete implementation of base Strategy */
    public class NoDiscountStrategy : IPromotionStrategy
    {
        public string Name => nameof(NoDiscountStrategy);

        int total = 0;
        public int GetPriceAfterPromotionalDiscount(int[] num)
        {
            if (num.Length > 0)
            {
                total += num[0] * 50;
            }
            if (num.Length > 1)
            {
                total += num[1] * 30;
            }
            if (num.Length > 2)
            {
                total += num[2] * 20;
            }
            if (num.Length > 3)
            {
                total += num[3] * 15;
            }
            return total;
        }
    }
}
