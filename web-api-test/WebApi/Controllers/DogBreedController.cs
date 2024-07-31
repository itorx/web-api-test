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

            Breed breed = new Breed()
            {
                data = new Data()
                {
                    attributes = new Attributes()
                    {
                        name = "Golden Retriever",
                        min_life = 10,
                        max_life = 12,
                    },
                    id = "1",
                    type = "breeds"
                },
                links = new Links()
                {
                    self = "https://api.thedogapi.com/v1/breeds/1"
                }
            };

            return breed;
        }
    }
}
