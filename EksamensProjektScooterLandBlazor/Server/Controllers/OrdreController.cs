using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/Ordre")]
    public class OrdreController : ControllerBase
    {
        private readonly IOrdreRepository Repository = new OrdreRepositorySql();

        public OrdreController(IOrdreRepository ordreRepository) 
        { 
            if(ordreRepository == null && ordreRepository != null)
            {
                Repository = ordreRepository;
                Console.WriteLine("repository initialized");
            }

        }

        [HttpGet]
        public IEnumerable<Ordre> GetAllOrdrer()
        {
            Console.WriteLine("Get all ordrer kaldet");

            return Repository.GetAllOrdrer();
        }


        [HttpPost]
        public void AddOrdre(Ordre ordre)
        {
            Console.WriteLine("Tilføj ordre kaldet: " + ordre.ToString());
            Repository.AddOrdre(ordre);
        }

        [HttpGet("{id:int}")]
        public Ordre FindOrdre(int id)
        {
            var ordre = Repository.FindOrdre(id);
            return ordre;
        }

        [HttpPut]
        public void UpdateOrdre(Ordre ordre)
        {
            Repository.UpdateOrdre(ordre);
        }

        [HttpDelete("{id:int}")]
        public void DeleteOrdre(int id) 
        { 
            Repository.DeleteOrdre(id); 
        }


    }
}
