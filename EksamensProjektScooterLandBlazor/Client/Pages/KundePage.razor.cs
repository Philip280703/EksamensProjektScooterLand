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

		public async void Seeddata()
		{
			var kunde = new Kunde { Fornavn = "Mark", Efternavn = "Ruge", Email = "Mark.ruge5@gmail.com", Etage = "S", HusNummer = "14", Placering = "Gul hus i indhak", PostNummer = 6064, ScooterBrandID = 1, PreferetMekanikerCprNummer = "20202020", TelefonNummer = "29906377", VejNavn = "chr jensensvej" };
			ErrorCode = await KundeService.AddKunde(kunde);
		}
	}
}
