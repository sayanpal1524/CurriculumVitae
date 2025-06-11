using Microsoft.AspNetCore.Mvc;
using MyResume.Model.Response;

namespace MyResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyResumeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MyResumeController> _logger;

        public MyResumeController(ILogger<MyResumeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Resume> Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return new List<Resume>
            {
                new Resume
                {
                    FileName = "JohnDoe_Resume.pdf",
                    Email = "  " } };
        }
    }
}
