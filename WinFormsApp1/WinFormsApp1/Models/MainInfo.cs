using Newtonsoft.Json;

namespace WinFormsApp1.Models
{
    public class MainInfo
    {
        [JsonProperty("temp")]
        public float Temp { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
