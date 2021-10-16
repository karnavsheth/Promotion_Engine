using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine.Promotion_Business_Logic
{
    public interface IPromotionStrategy
    {
        string Name { get; }
        int GetPriceAfterPromotionalDiscount(int[] num);
    }
}
