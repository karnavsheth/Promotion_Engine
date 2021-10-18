using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine.Promotion_Business_Logic
{
    public class Type1PromotionStrategy : IPromotionStrategy
    {
        public string Name => nameof(Type1PromotionStrategy);
        int total = 0;
        public int GetPriceAfterPromotionalDiscount(int[] num)
        {
            if (num.Length > 0)
            {
                total += (int)((Math.Floor((double)num[0] / 3) * 130) + ((num[0] % 3) * 50));
            }
            if (num.Length > 1)
            {
                total += (int)((Math.Floor((double)num[1] / 2) * 45) + ((num[1] % 2) * 30));
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
