namespace MyCoreApp.Models
{
    public class WeatherResponse
    {
        public string Name { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public MainInfo Main { get; set; }
        public WindInfo Wind { get; set; }
    }
}
