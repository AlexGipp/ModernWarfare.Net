using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ModernWarfare.Net.Helpers
{
    internal static class UsernameValidator
    {
        internal static string ValidateBattleNetUserName(string username)
        {
            if (!username.Contains("#") && !Regex.IsMatch(username, @"\d{4}$"))
                throw new NotSupportedException("Invalid platform type.");

            string newUsername = username.Replace("#", "%23");
            return newUsername;
        }
    }
}
