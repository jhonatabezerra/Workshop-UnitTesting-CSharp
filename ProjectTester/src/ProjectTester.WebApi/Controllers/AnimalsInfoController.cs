using Microsoft.AspNetCore.Mvc;
using ProjectTester.Domain.Models.Animals;
using ProjectTester.Services.Provider;

namespace ProjectTester.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalsInfoController : ControllerBase
    {
        private readonly ILogger<AnimalsInfoController> _logger;
        private readonly AnimalProvider _animalProvider;

        public AnimalsInfoController(ILogger<AnimalsInfoController> logger, AnimalProvider animalProvider)
        {
            _logger = logger;
            _animalProvider = animalProvider ?? new();
        }

        [HttpGet("~/GetAnimals")]
        public Animal GetAnimals()
        {
            _logger.Log(LogLevel.Information, "Get animals.");
            return _animalProvider.GetAnimals();
        }
    }
}