using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Helpers
{
    public class ApiProcessor
    {

        public static async Task<Stream> GetUser(string apiUrl)
        {
            var jsonAsStream = await ApiHelper.ApiClient.GetStreamAsync(apiUrl);
            return jsonAsStream ?? null;
        }
    }
}
