using System;
using System.Text.RegularExpressions;

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

        internal static string ToValidUsername(this Platform platform, string username)
        {
            if (platform == Platform.BattleNet)
            {
                if (!username.Contains("#") && !Regex.IsMatch(username, @"\d{4}$"))
                    throw new NotSupportedException("Invalid username type.");

                var newUsername = username.Replace("#", "%23");
                return newUsername;
            }
            return username;
        }
    }
}