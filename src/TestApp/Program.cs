using System;
using System.Threading.Tasks;
using ModernWarfare.Net;
using ModernWarfare.Net.Models;
using ModernWarfare.Net.Models.Enums;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Program();
            a.test().Wait();
        }

        public async Task test()
        {
            var client = new ModernWarfareClient();
            var tet = await client.GetMultiplayerStatsAsync(Platform.BattleNet, "Timmmy#21485");
            var te2 = await client.GetWarzoneStatsAsync(Platform.BattleNet, "Timmmy#21485");
            Console.WriteLine(tet.Kills);
            Console.WriteLine(te2.Downs);
            Console.ReadLine();
        }
    }
}
