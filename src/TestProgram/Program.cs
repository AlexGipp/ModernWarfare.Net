using System;
using System.Threading.Tasks;
using ModernWarfare.Net;
using ModernWarfare.Net.Models.Enums;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public async Task test()
        {
            var client = new ModernWarfareClient();
            var test = await client.GetMultiplayerStats(Platform.BattleNet, "Timmmy#21485");
        }
    }
}
