using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;


namespace EksamensProjektScooterLandBlazor.Client.ChildComponents
{
    public partial class RenderProdukt
	{
		[Parameter]
		public Produkt produkt { get; set; }

		private OrdreLinje ordreLinje = new OrdreLinje();

		//bliver brugt nede i Deleteprodukt metoden men den bliver ikke brugt lige nu da det ikke skal kunnes
		//implementeres at man kan slette et produkt
		[Parameter]
		public EventCallback<Produkt> deleteProdukt { get; set; }

		[Parameter]
		public int OrdreId { get; set; }

		[Inject]
		public IOrdreLinjeService ordreLinjeService { get; set; }

		[Parameter]
		public bool OrdreAddBool { get; set; } = false;

		[Parameter]
		public EventCallback Produkttilføjet { get; set; }

		private int ErrorCode { get; set; } = 0;

		private async Task DeleteProdukt()
		{
            // await deleteProdukt.InvokeAsync(produkt);   //// bliver ikke brugt lige nu da det er WIP
            var placeholder = "intet at se her...";
			Console.WriteLine(placeholder);

		}

		private async Task AddProductToOrdre()
		{
			ordreLinje.ProduktID = produkt.ProduktID;
			ordreLinje.Antal = 1;
			ordreLinje.OrdreLinjeDato = DateTime.Now;
			ordreLinje.RabatProcent = 0;
			ordreLinje.OrdreID = OrdreId;
			ErrorCode = await ordreLinjeService.AddOrdreLinje(ordreLinje);

			await Produkttilføjet.InvokeAsync();
		}


		private void NavigateToEditproduktComponent(int produktID)
		{
			NavigationsManager.NavigateTo($"/Editproduktpage/{produktID}");
		}
	}
}
