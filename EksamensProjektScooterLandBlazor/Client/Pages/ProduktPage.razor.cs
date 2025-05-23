﻿using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components.Forms;
using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;



namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class ProduktPage
	{
		private List<Produkt> produktListe = new List<Produkt>();

		// Nyt item som oprettes gennem formen
		private Produkt newProdukt = new Produkt();

		public bool visTilføjProdukt { get; set; } = false;

		public int ErrorCode { get; set; } = 0;

		private EditContext EditContext;

		[Inject]
		public IProduktService Service { get; set; }

		[Parameter]
		public bool AddingOrdreBool { get; set; }

		[Parameter]
		public int OrdreID { get; set; }

		[Parameter]
		public EventCallback Produkttilføjet { get; set; }

		List<Produkt> Filtreretprodukter = new();

		protected override void OnInitialized()
		{
			EditContext = new EditContext(newProdukt);
		}

		public async Task tilføjetProdukt()
		{
			await Produkttilføjet.InvokeAsync();
			StateHasChanged();
		}

		public async void DeleteProdukt(Produkt produkt)
		{
			// ønsker ikke hard delete som denne
			// produktListe.Remove(produkt);
			// ErrorCode = await Service.DeleteProdukt(produkt.ProduktID);
			throw new NotImplementedException();
		}

		public void visTilføjProduktSide()
		{
			visTilføjProdukt = !visTilføjProdukt;
		}

		protected override async Task OnInitializedAsync()
		{
			produktListe = (await Service.GetAllProdukt()).ToList();
			Filtreretprodukter = produktListe.ToList();
			visTilføjProdukt = false;
		}

		private void EnsureNonNegative(ChangeEventArgs e)
		{
			if (double.TryParse(e.Value?.ToString(), out var value))
			{
				if (value < 0)
				{
					newProdukt.ProduktPris = 0;
				}
				else
				{
					newProdukt.ProduktPris = value;
				}
			}
		}

		public async Task HandleValidSubmit()
		{

			produktListe.Add(new Produkt());
			ErrorCode = await Service.AddProdukt(newProdukt);
			Console.WriteLine("Shopping item added: return code: " + ErrorCode);


			// Ryd formen efter tilføjelse
			newProdukt = new Produkt();
			EditContext = new EditContext(newProdukt);
			await tilføjetProdukt();

			StateHasChanged();
		}

		



		public async Task HandleInvalidSubmit()
		{
			Console.WriteLine("HandleInvalidSubmit Called...");
		}

		// sortings parametre
		private string currentSortColumn;
		private bool isAscending = true;

		private void SortByColumn(string column)
		{
			if (currentSortColumn == column)
			{
				isAscending = !isAscending; 
			}
			else
			{
				currentSortColumn = column;
				isAscending = true; // Default til ascending for ny kolonne
			}

			
			//Sortere listen dynamisk baseret på kolonne navnet
			produktListe = isAscending
				? produktListe.OrderBy(x => x.GetType().GetProperty(column).GetValue(x)).ToList()
				: produktListe.OrderByDescending(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
		}

		private string SearchText = string.Empty;

		private List<Produkt> FilteretProduktList => string.IsNullOrWhiteSpace(SearchText)
			? produktListe : produktListe.Where(p => p.ProduktNavn.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();

        private string GetSortIndicator(string column)
        {
            if (currentSortColumn == column)
            {
                return new string(isAscending ? "⬆" : "⬇");
            }
            return new string(string.Empty);
        }

		private async void ProduktCallback()
		{
			produktListe = (await Service.GetAllProdukt()).ToList();
            StateHasChanged();
		}

    }
}

