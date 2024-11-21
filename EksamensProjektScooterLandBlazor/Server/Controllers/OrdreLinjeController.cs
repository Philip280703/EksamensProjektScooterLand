using EksamensProjektScooterLandBlazor.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/OrdreLinjeapi")]
	public class OrdreLinjeController : ControllerBase
	{

		private readonly IOrdreLinjeRepository Repository = new OrdreLinjeRepositorySql();

		public OrdreLinjeController(IOrdreLinjeRepository ordreLinjeRepository)
		{
			if (ordreLinjeRepository == null && ordreLinjeRepository != null)
			{
				Repository = ordreLinjeRepository;
				Console.WriteLine("Repository initialized");
			}
		}

		[HttpGet]
		public IEnumerable<OrdreLinje> GetAllOrdreLinjer()
		{
			Console.WriteLine("Get All OrderLinjer kaldet");
			return Repository.GetAllOrdreLinjer();
		}

		[HttpGet("{id:int}")]
		public OrdreLinje GetOrdreLinje(int id)
		{
			var ordre = Repository.GetOrdreLinje(id);
			return ordre;
		}

		[HttpPost]
		public void AddOrdreLinje(OrdreLinje ordrelinje)
		{
			Console.WriteLine("Tilføj ordrelinje kaldet:");
			Repository.AddOrdreLinje(ordrelinje);
		}

		[HttpPut]
		public void UpdateOrdreLinje(OrdreLinje ordreLinje)
		{
			Repository.UpdateOrdreLinje(ordreLinje);
		}

		[HttpDelete]
		public void DeleteOrdreLinje(int id)
		{
			Repository.DeleteOrdreLinje(id);
		}



	}
}
