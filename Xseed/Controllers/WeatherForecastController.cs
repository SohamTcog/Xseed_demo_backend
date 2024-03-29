using Microsoft.AspNetCore.Mvc;
using XSeed.Bussiness.Weather;
using XSeed;
using XSeed.Data.ViewModel;

namespace Xseed.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
           
        }

      
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> WeatherControllerMethod()
        {
            WeatherInfo model = new WeatherInfo();
           
            return (IEnumerable<WeatherForecast>)model.WeatherInfoMethod();

        }
    }
}
