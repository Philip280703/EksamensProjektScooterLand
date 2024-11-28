

using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/mekaniker")]
	public class MekanikerController : ControllerBase
	{
		private readonly IMekanikerRepository repository = new MekanikerRepositorySql();


		public MekanikerController(IMekanikerRepository mekanikerRepository) 
		{ 
			if(repository == null && mekanikerRepository != null)
			{
				repository = mekanikerRepository;
                Console.WriteLine("Mekaniker repository initialized");
			} 
		}

		[HttpGet]
		public IEnumerable<Mekaniker> GetAllMekaniker()
		{
			return repository.GetAllMekaniker();
		}

		[HttpGet("{id:int}")]
		public Mekaniker GetMekaniker(int id) 
		{
			var result = repository.GetMekaniker(id);
			return result;
		}
	}
}
