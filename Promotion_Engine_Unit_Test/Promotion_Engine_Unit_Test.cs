using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion_Engine;
using Promotion_Engine.Promotion_Business_Logic;

namespace Promotion_Engine_Unit_Test
{
    [TestClass]
    public class Promotion_Engine_Unit_Test
    {
        NoDiscountStrategy noDiscountStrategy = new NoDiscountStrategy();
        Type1PromotionStrategy type1PromotionStrategy = new Type1PromotionStrategy();
        Type2PromotionStrategy type2PromotionStrategy = new Type2PromotionStrategy();
        StrategyContext strategyContext = new StrategyContext();


        [TestMethod]
        public void Context_GetStrategy_Test1()
        {
            var result = strategyContext.GetStrategy(new int[] { 1, 1, 1, 0 });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(typeof(NoDiscountStrategy), (result[0].GetType()));
        }

        [TestMethod]
        public void Context_GetStrategy_Test2()
        {
            var result = strategyContext.GetStrategy(new int[] { 3, 2, 0, 1 });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(typeof(Type1PromotionStrategy), (result[0].GetType()));
        }

        [TestMethod]
        public void Context_GetStrategy_Test3()
        {
            var result = strategyContext.GetStrategy(new int[] { 1, 1, 1, 1 });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(typeof(Type2PromotionStrategy), (result[0].GetType()));
        }



        [TestMethod]
        public void Context_GetStrategy_Test4()
        {
            var result = strategyContext.GetStrategy(new int[] { 1, 3, 4, 1 });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(typeof(Type1PromotionStrategy), (result[0].GetType()));
        }



        [TestMethod]
        public void Context_ApplyStrategy_Test1()
        {
            var result = strategyContext.ApplyStrategy(new List<IPromotionStrategy>(){ new Type1PromotionStrategy() },new int[] { 1, 3, 4, 1 });
            Assert.AreEqual(220,result);
        }

        [TestMethod]
        public void Context_ApplyStrategy_Test2()
        {
            var result = strategyContext.ApplyStrategy(new List<IPromotionStrategy>() { new Type1PromotionStrategy() }, new int[] { 3, 2, 0, 1 });
            Assert.AreEqual(190, result);
        }

        [TestMethod]
        public void Context_ApplyStrategy_Test3()
        {
            var result = strategyContext.ApplyStrategy(new List<IPromotionStrategy>() { new Type2PromotionStrategy() }, new int[] { 1, 1, 1, 1 });
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void Context_ApplyStrategy_Test4()
        {
            var result = strategyContext.ApplyStrategy(new List<IPromotionStrategy>() { new NoDiscountStrategy() }, new int[] { 1, 1, 0, 1 });
            Assert.AreEqual(95, result);
        }


        [TestMethod]
        public void NoDiscount_Test1()
        {
            var result = noDiscountStrategy.GetPriceAfterPromotionalDiscount(new int[] { 1, 1, 0, 1 });
            Assert.AreEqual(95, result);
        }

        [TestMethod]
        public void Type1PromotionStrategy_Test1()
        {
            var result = type1PromotionStrategy.GetPriceAfterPromotionalDiscount(new int[] { 3, 2, 0, 1 });
            Assert.AreEqual(190, result);
        }

        [TestMethod]
        public void Type2PromotionStrategy_Test1()
        {
            var result = type2PromotionStrategy.GetPriceAfterPromotionalDiscount(new int[] { 1, 1, 1, 1 });
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void Type1PromotionStrategy_Test2()
        {
            var result = type1PromotionStrategy.GetPriceAfterPromotionalDiscount(new int[] { 1, 3, 4, 1 });
            Assert.AreEqual(220, result);
        }

        [TestMethod]
        public void NoDiscount_Test2()
        {
            var result = noDiscountStrategy.GetPriceAfterPromotionalDiscount(new int[] { 1, 1, 1, 0 });
            Assert.AreEqual(100, result);
        }


     
    }
}
