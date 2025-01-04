using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
    [ApiController]
	[Route("api/scooterbrand")]
	public class ScooterBrandController
    {

        private readonly IScooterBrandRepository repository = new ScooterBrandRepositorySql();
    
        public ScooterBrandController(IScooterBrandRepository scooterBrandRepository)
        {
            if (repository == null && scooterBrandRepository != null)
            {
                repository = scooterBrandRepository;
                Console.WriteLine("scooterbrand repository initialized");
            }
        }

        [HttpGet]
        public IEnumerable<ScooterBrand> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id:int}")]
        public ScooterBrand GetSingle(int id)
        {
            var result = repository.GetSingle(id);
            return result;
        }
    
    }
}
