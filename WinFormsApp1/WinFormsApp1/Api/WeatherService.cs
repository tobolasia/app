using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinFormsApp1.Config;
using WinFormsApp1.Models;

namespace WinFormsApp1.Api
{
    public class WeatherService
    {
        private readonly HttpClient _client;

        public WeatherService()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("Miasto nie może być puste.");

            string url =
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={AppSettings.ApiKey}&units=metric&lang=pl";

            try
            {
                var response = await _client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Błąd API: {response.StatusCode}");

                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WeatherResponse>(json);
            }
            catch (HttpRequestException)
            {
                throw new Exception("Brak połączenia z internetem.");
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd pobierania danych: " + ex.Message);
            }
        }
    }
}
