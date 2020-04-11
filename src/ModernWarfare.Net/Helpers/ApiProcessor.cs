using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModernWarfare.Net.Helpers
{
    public class ApiProcessor
    {
        public static async Task<string> GetUser(string apiUrl)
        {
            var jsonAsString = await ApiHelper.ApiClient.GetStringAsync(apiUrl);
            return jsonAsString ?? string.Empty;
        }
    }
}
