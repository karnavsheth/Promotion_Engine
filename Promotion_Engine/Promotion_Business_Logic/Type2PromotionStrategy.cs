using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine.Promotion_Business_Logic
{
    public class Type2PromotionStrategy : IPromotionStrategy
    {
        public string Name => nameof(Type2PromotionStrategy);
        int total = 0;
        public int GetPriceAfterPromotionalDiscount(int[] num)
        {
            if (num.Length > 0)
            {
                total += (num[0] * 50);
            }
            if (num.Length > 1)
            {
                total += (num[1] * 30);
            }
            if (num.Length > 3 && num[2] >= 1 && num[3] >= 1)
            {
                while (num[2] >= 1 && num[3] >= 1)
                {
                    total += 45;
                    num[2]--;
                    num[3]--;
                }
                total += num[2] * 20 + num[3] * 15;
            }
            return total;
        }
    }
}
