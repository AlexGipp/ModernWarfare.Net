using System;
using System.Threading.Tasks;
using ModernWarfare.Net;
using ModernWarfare.Net.Models.Enums;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new Program();
            test.test();
        }

        public void test()
        {
            var client = new ModernWarfareClient();

            var test5 = client.GetWarzoneStatsAsync(Platform.BattleNet, "Timmmy#21485").Result.PlunderStats.AvarageLife.DisplayValue;

            Console.WriteLine("AAA");

        }
    }
}
