using System;
using System.Windows.Forms;
using WinFormsApp1.Api;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly WeatherService _weatherService;

        public Form1()
        {
            InitializeComponent();
            _weatherService = new WeatherService();
        }

        private async void button_Click(object sender, EventArgs e)
        {
            string city = textCity.Text.Trim();

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Wpisz nazwę miasta.");
                return;
            }

            labelResult.Text = "Pobiernie danych...";

            try
            {
                var weather = await _weatherService.GetWeatherAsync(city);

                labelResult.Text =
                    $"Miasto: {weather.Name}\n" +
                    $"Temperatura: {weather.Main.Temp} °C\n" +
                    $"Opis: {weather.Weather[0].Description}\n" +
                    $"Wilgotność: {weather.Main.Humidity}%\n" +
                    $"Wiatr: {weather.Wind.Speed} m/s";
            }
            catch (Exception ex)
            {
                labelResult.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
