using System.Configuration;

namespace WinFormsApp1.Config
{
    public static class AppSettings
    {
        public static string ApiKey => ConfigurationManager.AppSettings["OpenWeatherApiKey"];
    }
}