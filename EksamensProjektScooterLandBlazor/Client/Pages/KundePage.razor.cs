using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
	public partial class KundePage
	{
		private List<Kunde> kundeListe = new List<Kunde>();
		public int ErrorCode { get; set; }

		[Inject]
		public IKundeService Service { get; set; }

		protected override async Task OnInitializedAsync()
		{
			kundeListe = (await Service.GetAllKunder()).ToList();
		}
	}
}
