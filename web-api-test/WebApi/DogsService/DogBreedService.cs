using WebApi.Models;
using System.Text.Json;

namespace WebApi.DogsService
{
    public class DogBreedService
    {
        private readonly HttpClient _httpClient;

        public DogBreedService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Create a method call the following api and returns a Breed object.
        /// Url: https://dogapi.dog/api/v2/breeds/{id} 
        /// Use id '68f47c5a-5115-47cd-9849-e45d3c378f12' to get back a breed object.
        /// </summary>
        /// <param name="id"></param>
    }
}
