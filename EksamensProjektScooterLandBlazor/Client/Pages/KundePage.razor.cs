using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
	public partial class KundePage
	{
		[Inject]
		public IKundeService Service { get; set; }

		private List<Kunde> kundeListe = new List<Kunde>();
		public int ErrorCode { get; set; }

		protected override async Task OnInitializedAsync()
		{
			kundeListe = (await Service.GetAllKunder()).ToList();
		}

		public async Task Seeddata()
		{
			Kunde kunde = new Kunde
			{
				Fornavn = "Anders",
				Efternavn = "Hansen",
				ScooterBrandID = 1,
				TelefonNummer = "12345678",
				Email = "anders.hansen@example.com",
				PostNummer = 6064,
				VejNavn = "Hovedgaden",
				HusNummer = "1A",
				Etage = "1",
				Placering = "tv",
				PreferetMekanikerCprNummer = "2904881243",
			};

			/*foreach(var kunde in kunder)
			{*/
				ErrorCode = await Service.AddKunde(kunde);
                Console.WriteLine("Kunde tilføjet: return code: " + ErrorCode);
			//}
		}
	}
}
