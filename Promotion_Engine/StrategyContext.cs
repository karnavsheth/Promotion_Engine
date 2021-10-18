using Promotion_Engine.Promotion_Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine
{

    public class StrategyContext
    {
        Dictionary<string, IPromotionStrategy> strategyContext
            = new Dictionary<string, IPromotionStrategy>();
        public StrategyContext()
        {
            strategyContext.Add(nameof(NoDiscountStrategy),
                    new NoDiscountStrategy());
            strategyContext.Add(nameof(Type1PromotionStrategy),
                    new Type1PromotionStrategy());
            strategyContext.Add(nameof(Type2PromotionStrategy),
                    new Type2PromotionStrategy());
        }

        public int ApplyStrategy(List<IPromotionStrategy> strategies, int[] nums)
        {

            var total = 0;
            foreach (var strategy in strategies)
            {
                total = total + strategy.GetPriceAfterPromotionalDiscount(nums);
            }
            return total;
        }

        public List<IPromotionStrategy> GetStrategy(int[] SKUArray)
        {
            List<IPromotionStrategy> iPromotionStrategy = new List<IPromotionStrategy>();
            if (SKUArray[0] > 2 || SKUArray[1] > 1)
            {
                iPromotionStrategy.Add(strategyContext[nameof(Type1PromotionStrategy)]);
            }
            else if (SKUArray[2] > 0 && SKUArray[3] > 0)
            {
                iPromotionStrategy.Add(strategyContext[nameof(Type2PromotionStrategy)]);
            }
            else
            {
                //implement no discount values
                iPromotionStrategy.Add(strategyContext[nameof(NoDiscountStrategy)]);
            }
            return iPromotionStrategy;
        }
    }
}
