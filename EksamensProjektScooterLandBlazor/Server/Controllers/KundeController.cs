using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/kundeapi")]
	public class KundeController : ControllerBase
	{
		private readonly IKundeRepository Repository = new KundeRepositorySql();

		public KundeController(IKundeRepository kundeRepository)
		{
			if (Repository == null && kundeRepository != null)
			{
				Repository = kundeRepository;
				Console.WriteLine("Repository initialiseret");
			}
		}

		[HttpGet]
		public IEnumerable<Kunde> GetAllKunder()
		{
			return Repository.GetAllKunder();
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteKunde(int id)
		{
			Console.WriteLine("Server: Slet kunde kaldet: id = " + id);

			bool deleted = Repository.DeleteKunde(id);
			if (deleted)
			{
				Console.WriteLine("Server: Kunde slettet success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Kunde ikke slettet - ikke fundet");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

		[HttpPost]
		public void AddKunde(Kunde kunde)
		{
            Console.WriteLine("Tilføj kunde kaldet: " + kunde.ToString());
			Repository.AddKunde(kunde);
		}

		[HttpGet("{id:int}")]
		public Kunde FindKunde(int id)
		{
			var kunde = Repository.FindKunde(id);
			return kunde;
		}

		[HttpPut]
		public void UpdateKunde(Kunde kunde)
		{
			Repository.UpdateKunde(kunde);
		}
	}
}
