using Microsoft.AspNetCore.Mvc;
using Work1.Helpers;

namespace Work1.Controllers
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
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetWeatherForecast2")]
        public void GetWeatherForecast2()
        {
            using (Calc c= new())
            {
                c.Add(1, 22, out int x);

                int y = 222;
                
                c.AddTwo(1, 22,ref y);

                Console.WriteLine(x);
            }
        }

        [HttpGet(Name = "GetWeatherForecast22")]
        public void GetWeatherForecast22()
        {
            using (Calc c = new())
            {
                c.Add(1, 22, out int x);

                int y = 222;

                c.AddTwo(1, 22, ref y);

                Console.WriteLine(x);
            }
        }
    }
}