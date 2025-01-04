using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace EksamensProjektScooterLandBlazor.Client.ChildComponents
{
    public partial class RenderKunde
	{
		[Parameter]
		public Kunde kunde { get; set; }

		public bool showmodal { get; set; } = false;

		public bool showmodal2 { get; set; } = false;

		public string fejlmeddelelse { get; set; }

		private List<Mekaniker> mekanikerListe { get; set; }

		private List<Ordre> ordreListe { get; set; }

		[Inject]
		public IMekanikerService mekanikerService { get; set; }

		[Inject]
		public IOrdreService ordreService { get; set; }

		[Parameter]
		public EventCallback<Kunde> deleteKunde { get; set; }

		protected override async Task OnInitializedAsync()
		{
			mekanikerListe = (await mekanikerService.GetAllMekaniker()).ToList();
			ordreListe = (await ordreService.GetAllOrdrer()).ToList();
		}

		private async Task Showmodal()
		{
			showmodal = !showmodal;
		}

		private async Task Showmodal2()
		{
			showmodal2 = !showmodal2;
		}

		private async Task DeleteKunde()
		{
			Ordre ordre = ordreListe.Find(o => o.KundeiD == kunde.KundeID);

            if(ordre == null)
            {
				await deleteKunde.InvokeAsync(kunde);
				showmodal = !showmodal;  
            }
			else
			{
				showmodal = !showmodal;
				Showmodal2();
			}
		}


		private void NavigateToEditKundeComponenet(int kundeID)
		{
			NavigationManager.NavigateTo($"/Editkundepage/{kundeID}");
		}

		private void NavigateToOrdreOversigtComponent(int KundeID)
		{
			NavigationManager.NavigateTo($"/KundeOrdreOversigtPage/{KundeID}");
		}
	}
}
