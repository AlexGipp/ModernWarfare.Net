using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ModernWarfare.Net.Helpers
{
    public class ApiProcessor
    {
        public static HttpClient ApiClient { get; set; }

        public static async Task<string> GetUser(string apiUrl)
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var jsonAsString = await ApiClient.GetStringAsync(apiUrl);
            return jsonAsString ?? string.Empty;
        }
    }
}
