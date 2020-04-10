using System;
using System.Collections.Generic;
using System.Text;
using ModernWarfare.Net.Helpers;
using ModernWarfare.Net.Models.Enums;

namespace ModernWarfare.Net
{
    public class ModernWarfareClient
    {
        public void GetMultiplayerStats(Platform platform, string username)
        {
            string reguestPlatform = PlatformFormatter.FormatPlatform(platform);
        }

        public void GetWarzoneStats(Platform platform, string username)
        {
            string reguestPlatform = PlatformFormatter.FormatPlatform(platform);
        }
    }
}
