using Newtonsoft.Json;

namespace CodeBOT
{
    public class ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prifix")]
        public string Prifix { get; private set; }
    }
}