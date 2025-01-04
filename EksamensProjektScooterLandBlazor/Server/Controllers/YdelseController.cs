using EksamensProjektScooterLandBlazor.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Server.Controllers;
using System.Net;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;

namespace EksamensProjektScooterLandBlazor.Server.Controllers

{
    [ApiController]
    [Route("api/ydelseapi")]
    public class YdelseController : ControllerBase
    {
        private readonly IYdelseRepository repository = new YdelseRepositorySql();


        public YdelseController(IYdelseRepository ydelseRepository)
        {
            if (repository == null && ydelseRepository != null)
            {
                repository = ydelseRepository;
                Console.WriteLine("Ydelse Repository initialisered");
            }
        }

        [HttpGet]

        public IEnumerable<Ydelse> GetAllYdelser()
        {
            return repository.GetAllYdelser();
        }

        [HttpGet("{id:int}")]

        public Ydelse GetYdelse(int id)
        {
            var result = repository.GetYdelse(id);
            return result;
        }

        [HttpPost]

        public void AddYdelse(Ydelse ydelse)
        {
            Console.WriteLine("Tilføj ydelse: " + ydelse.ToString());
            repository.AddYdelse(ydelse);
        }

        [HttpDelete("{int:int}")]

        public StatusCodeResult DeleteYdelse(int id)
        {
            Console.WriteLine("Server: Delete ydelse called: id = " + id);

            bool deleted = repository.DeleteYdelse(id);
            if (deleted)
            {
                Console.WriteLine("Server: Ydelse deleted succces");
                int code = (int)HttpStatusCode.OK;
                return new StatusCodeResult(code);
            }
            else
            {
                Console.WriteLine("Server: Ydelse deleted fail - not found");
                int code = (int)HttpStatusCode.NotFound;
                return new StatusCodeResult(code);
            }
        }

        [HttpPut]
        public void UpdateYdelse(Ydelse ydese)
        {
            repository.UpdateYdelse(ydese);
        }
    }
}
