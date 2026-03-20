using Newtonsoft.Json;

namespace WinFormsApp1.Models
{
    public class WeatherResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weather")]
        public WeatherInfo[] Weather { get; set; }

        [JsonProperty("main")]
        public MainInfo Main { get; set; }

        [JsonProperty("wind")]
        public WindInfo Wind { get; set; }
    }
}