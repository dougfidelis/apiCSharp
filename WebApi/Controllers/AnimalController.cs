using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    public class AnimalController : GenericController<Animal, AnimalRepository>
    {
        public AnimalController() : base(new AnimalRepository())
        {

        }
    }
}
