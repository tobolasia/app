using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCoreApp.Models;
using MyCoreApp.Services;

namespace MyCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WeatherService _weatherService;

        public IndexModel(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [BindProperty]
        public string City { get; set; }

        public WeatherResponse? Weather { get; set; }
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (string.IsNullOrWhiteSpace(City))
            {
                ErrorMessage = "Podaj nazwę miasta.";
                return Page();
            }

            Weather = await _weatherService.GetWeatherAsync(City);

            if (Weather == null)
            {
                ErrorMessage = "Nie znaleziono miasta lub wystąpił błąd API.";
            }

            return Page();
        }
    }
}