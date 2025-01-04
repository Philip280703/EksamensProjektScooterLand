using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/PostnummerOgBy")]
    public class PostnummerOgByController
    {
        private readonly IPostnummerOgByRepostitory repository = new PostnummerOgByRepositorySql();
        
        public PostnummerOgByController(IPostnummerOgByRepostitory postnummerOgByRepostitory) 
        {
            if (repository == null && postnummerOgByRepostitory != null) 
            { 
                repository = postnummerOgByRepostitory;
                Console.WriteLine("Postnummer repository called..");
            }
        }

        [HttpGet]
        public IEnumerable<PostNummerOgBy> GetAllPostnummerOgByer()
        {
            return repository.GetAllPostnummerOgByer();
        }

        [HttpGet("{id:int}")]
        public PostNummerOgBy GetMekaniker(int id)
        {
            var result = repository.GetPostnummerOgBy(id);
            return result;
        }



    }
}
