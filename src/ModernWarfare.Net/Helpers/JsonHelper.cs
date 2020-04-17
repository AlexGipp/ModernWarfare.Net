using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace ModernWarfare.Net.Helpers
{
    internal class JsonHelper
    {
        internal Task<T> Deserialise<T>(Stream stream)
        {
            var streamReader = new StreamReader(stream);
            var jsonTextReader = new JsonTextReader(streamReader);
            var jsonSerializer = new JsonSerializer();

            return Task.FromResult(jsonSerializer.Deserialize<T>(jsonTextReader));
        }
    }
}
