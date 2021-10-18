using Promotion_Engine.Promotion_Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine
{
    public class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext();
            Console.WriteLine("Enter SKU Numbers in order (e.g. A B C D):");
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            List<IPromotionStrategy> strategy = context.GetStrategy(input);
            var result = context.ApplyStrategy(strategy, input);
            Console.WriteLine("Price after offer:" + result);
            Console.ReadLine();
        }
    }
}
