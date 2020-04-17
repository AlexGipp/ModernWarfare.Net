using System.IO;
using System.Threading.Tasks;

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
