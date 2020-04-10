using System;
using System.Collections.Generic;
using System.Text;
using ModernWarfare.Net.Models.Enums;

namespace ModernWarfare.Net.Helpers
{
    internal static class PlatformFormatter
    {
        internal static string FormatPlatform(Platform platform)
        {
            switch (platform)
            {
                case Platform.Activision:
                    return "atvi";
                case Platform.BattleNet:
                    return "battlenet";
                case Platform.PSN:
                    return "psn";
                case Platform.XBL:
                    return "xbl";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }
    }
}
