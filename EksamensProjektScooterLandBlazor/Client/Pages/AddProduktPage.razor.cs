using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components.Forms;
using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class AddProduktPage
	{

		[Inject]
		public NavigationManager navigationManager { get; set; }

		[Parameter]
		public EventCallback TilføjProdukt { get; set; }

        private Produkt ProduktModel = new Produkt();
		private EditContext editContext;

		[Inject]
		public IProduktService produktService { get; set; }

		public int ErrorCode { get; set; }

		protected override async Task OnInitializedAsync()
		{
			editContext = new EditContext(ProduktModel);

		}

		private async void HandleValidSubmit()
		{
			Console.WriteLine("HandleValidSubmit called...");
			ErrorCode = await produktService.AddProdukt(ProduktModel);

			if (ErrorCode == 200)
			{
				
				editContext = new EditContext(ProduktModel);

				

				navigationManager.NavigateTo("/Produkt");
				TilføjProdukt.InvokeAsync();
			}

		}

		private void HandleInvalidSubmit()
		{
			Console.WriteLine("HandleInvalidSubmit called..");
		}
	}
}
