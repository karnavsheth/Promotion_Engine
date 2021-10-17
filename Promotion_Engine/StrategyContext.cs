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
            public StrategyContext(double price)
            {
            strategyContext.Add(nameof(NoDiscountStrategy),
                    new NoDiscountStrategy());

        }

        public void ApplyStrategy(List<IPromotionStrategy> strategies, int[] nums)
            {

                var total = 0;
                foreach (var strategy in strategies)
                {
                    total = total + strategy.GetPriceAfterPromotionalDiscount(nums);
                }
                Console.WriteLine("Price after offer:" + total);
            }

            public List<IPromotionStrategy> GetStrategy(int[] SKUArra)
            {
                List<IPromotionStrategy> iPromotionStrategy = new List<IPromotionStrategy>();
                if (SKUArra[0] > 3 || SKUArra[1] > 1)
                {
                iPromotionStrategy.Add(strategyContext[nameof(Type1PromotionStrategy)]);
                }
                else if (SKUArra[2] > 1 && SKUArra[3] > 1)
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
