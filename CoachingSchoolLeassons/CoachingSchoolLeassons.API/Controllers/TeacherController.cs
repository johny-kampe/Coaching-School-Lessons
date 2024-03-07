using CoachingSchoolLeassons.API.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CoachingSchoolLeassons.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Teacher> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Teacher
            {
                //Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                //TemperatureC = Random.Shared.Next(-20, 55),
                //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}