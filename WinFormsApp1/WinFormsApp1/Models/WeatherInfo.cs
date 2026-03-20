using Newtonsoft.Json;

namespace WinFormsApp1.Models
{
    public class WeatherInfo
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}