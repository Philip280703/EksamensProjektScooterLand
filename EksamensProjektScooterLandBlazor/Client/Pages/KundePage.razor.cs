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

	}
}
