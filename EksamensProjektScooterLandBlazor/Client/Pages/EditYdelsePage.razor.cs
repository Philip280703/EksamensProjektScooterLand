using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components.Forms;
using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class EditYdelsePage
	{
		[Inject]
		public IYdelseService YdelseService { get; set; }

		[Parameter]
		public int YdelseID { get; set; }

		private Ydelse? ydelse;

		private EditContext editContext;
		public int ErrorCode { get; set; }
		private string ErrorMessage;

		protected override async Task OnInitializedAsync()
		{
			ydelse = await YdelseService.GetYdelse(YdelseID);
			editContext = new EditContext(ydelse);
		}

		private async Task HandleValidSubmit()
		{
			Console.WriteLine("HandlevalidSubmit called...");
			ErrorCode = await YdelseService.UpdateYdelse(ydelse);

			if (ErrorCode == 200)
			{
				NavigationManager.NavigateTo("/YdelsePage");
			}
			else
			{
				ErrorMessage = "Der opstod en fejl under opdatering af kunde. Prøv igen";
			}
		}

		private void HandleInvalidSubmit()
		{
			Console.WriteLine("HandleInvalidSubmit called...");
		}
	}
}
