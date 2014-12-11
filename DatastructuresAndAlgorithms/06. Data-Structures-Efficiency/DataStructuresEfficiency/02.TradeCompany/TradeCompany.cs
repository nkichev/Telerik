using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Wintellect.PowerCollections;

namespace _02.TradeCompany
{
    public class TradeCompany
    {
        public const int itemsCount = 1000000;
        public const int searchesCount = 1000000;
        public static Random rnd = new Random();

        public static void Main()
        {
            SolveWithMultyDict();
        }

        private static string GetRandomString()
        {
            return new string(((char)rnd.Next(65,91)),rnd.Next(5,12));
        }

        private static void SolveWithMultyDict()
        {
            OrderedMultiDictionary<int, Product> dict = new OrderedMultiDictionary<int, Product>(true);
            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < itemsCount; i++)
            {
                var price = rnd.Next(1, itemsCount);
                dict.Add(price, new Product(GetRandomString(), GetRandomString(), GetRandomString(), price));
            }

            Console.WriteLine("Added {0} items in {1} time",itemsCount,sw.Elapsed);
            sw.Restart();

            for (int i = 0; i < searchesCount; i++)
            {
                dict.Range(rnd.Next(0, itemsCount / 2), true, rnd.Next(itemsCount/2,itemsCount), true);
            }

            Console.WriteLine("Found Range {0} items in {1} time", searchesCount, sw.Elapsed);
        }
    }
}
