using Newtonsoft.Json;

namespace WinFormsApp1.Models
{
    public class WindInfo
    {
        [JsonProperty("speed")]
        public float Speed { get; set; }
    }
}
