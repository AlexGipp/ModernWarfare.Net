using System;
using System.Collections.Generic;
using System.Text;

namespace ModernWarfare.Net.Models.Enums
{
    public enum Platform
    {
        BattleNet,
        Activision,
        PSN,
        XBL
    }

    internal static class PlatformExtensions
    {
        internal static string ToApiString(this Platform platform)
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
