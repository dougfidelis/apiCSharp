using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repository;

        public AnimalController()
        {
            repository = new AnimalRepository();
        }
        [HttpGet]
        public List<Animal> Get()
        {
          
            return repository.GetAll();
        }

        [HttpPost]
        public string Post(Animal model)
        {
            
            return repository.Create(model);
        }
    }
}
