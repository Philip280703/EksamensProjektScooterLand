using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components.Forms;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
	public partial class EditProduktPage
	{
		[Inject]
		public IProduktService ProduktService { get; set; }

		[Inject]
		public NavigationManager navigationManager { get; set; }

		[Parameter]
		public int ProduktId { get; set; }

		private Produkt? produkt;

		private EditContext editContext;

		public int ErrorCode { get; set; }

		private string ErrorMessage;


		protected override async Task OnInitializedAsync()
		{
			produkt = await ProduktService.GetSingleProdukt(ProduktId);

			if (produkt != null)
			{
				editContext = new EditContext(produkt);
			}

		}

		private async void HandleValidSubmit()
		{
			Console.WriteLine("HandlevalidSubmit called...");
			ErrorCode = await ProduktService.UpdateProdukt(produkt);

			if (ErrorCode == 200)
			{
				navigationManager.NavigateTo("/Produkt");

			}
			else
			{
				ErrorMessage = "Der opstod en fejl under opdatering af produktet. Prøv igen!";
			}


		}

		private void HandleInvalidSubmit()
		{
			Console.WriteLine("HandleInvalidSubmit called...");
		}


	}
}
