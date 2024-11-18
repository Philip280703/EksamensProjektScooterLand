using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/produktapi")]
	public class ProduktController : ControllerBase
	{
		private readonly IProduktRepository repository = new ProduktRepositorySql();

		public ProduktController(IProduktRepository produktRepository) 
		{ 
			if (repository == null && produktRepository != null)
			{
				repository = produktRepository;
				Console.WriteLine("Repository initialiseret");
			}
		}

		[HttpGet]
		public IEnumerable<Produkt> GetAllProdukt()
		{
			return repository.GetAllProdukt();
		}

		[HttpGet("{id:int}")]
		public Produkt GetProdukt(int id)
		{
			var produkt = repository.GetProdukt(id);
			return produkt;
		}

		[HttpPost]
		public void AddProdukt(Produkt produkt)
		{
			Console.WriteLine("Tilføj produkt kaldet: " + produkt.ToString());
			repository.AddProdukt(produkt);
		}



		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteProdukt(int id)
		{
			Console.WriteLine("Server: Slet produkt kaldet: id = " + id);

			bool deleted = repository.DeleteProdukt(id);
			if (deleted)
			{
				Console.WriteLine("Server: produktet slettet sucess");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Produkt ikke slettet - ikke fundet");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);

			}
		}

		[HttpPut]
		public void Updateprodukt(Produkt produkt)
		{
			repository.UpdateProdukt(produkt);
		}
	}
}
