using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion_Engine.Promotion_Business_Logic;

namespace Promotion_Engine_Unit_Test
{
    [TestClass]
    public class Promotion_Engine_Unit_Test
    {
        NoDiscountStrategy noDiscountStrategy = new NoDiscountStrategy();

        [TestMethod]
        public void NoDiscount_Test1()
        {
            var result = noDiscountStrategy.GetPriceAfterPromotionalDiscount(new int[] { 1, 1, 0, 1 });
            Assert.AreEqual(95, result);
        }
    }
}
