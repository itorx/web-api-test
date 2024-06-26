using Microsoft.AspNetCore.Mvc;
using WebApi.DogsService;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogBreedController : ControllerBase
    {
        private readonly ILogger<DogBreedController> _logger;

        public DogBreedController(ILogger<DogBreedController> logger)
        {
        }

        [HttpGet(Name = "DogBreed")]
        public Breed Get(string id)
        {
            // Call the DogBreedService to get the breed object.

            return null;
        }
    }
}
