using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
	public partial class KundePage
	{
		[Inject]
		public IKundeService KundeService { get; set; }

		private List<Kunde> kundeListe = new List<Kunde>();
		public int ErrorCode { get; set; }

		protected override async Task OnInitializedAsync()
		{
			kundeListe = (await KundeService.GetAllKunder()).ToList();
		}

		public async void DeleteKunde(Kunde kunde)
		{
			kundeListe.Remove(kunde);
			ErrorCode = await KundeService.DeleteKunde(kunde.KundeID);
		}

		public async void UpdateKunde(Kunde kunde)
		{

		}

		public async void Add()
		{
			var kunde = new Kunde { Fornavn = "mark", Efternavn = "ruge", Email = "mark.ruge5@gmail.com", Etage = "2", HusNummer = "14", Placering = "venstre", PostNummer = 6064, PreferetMekanikerCprNummer = "2904881243", ScooterBrandID = 1, TelefonNummer = "29906377", VejNavn = "Chr jensensvej" };
			ErrorCode = await KundeService.AddKunde(kunde);
			if(ErrorCode == 200)
			{
				kundeListe.Add(kunde);
			}
		}
	}
}
