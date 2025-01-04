using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/scooterleje")]
    public class ScooterLejeController
    {
        private readonly IScooterLejeRepository repository = new ScooterLejeRepositorySql();

        public ScooterLejeController(IScooterLejeRepository scooterLejeRepository)
        {
            if (repository == null && scooterLejeRepository != null)
            {
                repository = scooterLejeRepository;
                Console.WriteLine("scooterbrand repository initialized");
            }
        }

        [HttpGet]
        public IEnumerable<ScooterLeje> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id:int}")]
        public ScooterLeje GetSingle(int id)
        {
            var result = repository.GetSingle(id);
            return result;
        }
    }
}
