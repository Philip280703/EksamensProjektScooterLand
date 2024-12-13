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

        [Inject]
        public IScooterBrandService ScooterBrandService { get; set; }

        private Kunde KundeModel = new Kunde();
        private List<ScooterBrand> scooterBrandListe = new List<ScooterBrand>();
        private List<Kunde> FilteretKundeListe = new List<Kunde>();

        private int ?sortedScooterBrandID {  get; set; } 
        
        private List<Kunde> kundeListe = new List<Kunde>();
		public int ErrorCode { get; set; }

		protected override async Task OnInitializedAsync()
		{
			kundeListe = (await KundeService.GetAllKunder()).ToList();
            scooterBrandListe = (await ScooterBrandService.GetAll()).ToList();
            FilteretKundeListe = kundeListe;

		}

		public async void DeleteKunde(Kunde kunde)
		{
			kundeListe.Remove(kunde);
			ErrorCode = await KundeService.DeleteKunde(kunde.KundeID);
		}

		public async void UpdateKunde(Kunde kunde)
		{

		}

        private void FilterKundeListeByScooter()
        {
            if (sortedScooterBrandID.HasValue && sortedScooterBrandID > 0)
            {
                //Filtrere listen baseret på den valgte scooterBrandID
                FilteretKundeListe = kundeListe.Where(k => k.ScooterBrandID == sortedScooterBrandID).ToList();
            }
            else
            {
                //Nulstilller til den fulde liste hvis der ikk er valgt nogen valide ScooterbrandID
                FilteretKundeListe = kundeListe;
            }
        }

        private string SearchText = string.Empty;

        private List<Kunde> FilteretKundeList => string.IsNullOrWhiteSpace(SearchText)
            ? FilteretKundeListe : FilteretKundeListe.Where(k =>
            k.Fornavn.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
            k.Efternavn.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
        ).ToList();



        // sortings parametre
        private string currentSortingColumn;
        private bool isAscending = true;

        private void SortByColumn(string column)
        {
            if (currentSortingColumn == column)
            {
                isAscending = !isAscending; // set til modsat af sidst
            }
            else
            {
                currentSortingColumn = column;
                isAscending = true; // Default til ascending for ny kolonne
            }

            // Sorter listen baseret på den valgte kolonne
            FilteretKundeListe = isAscending
                ? FilteretKundeListe.OrderBy(x => x.GetType().GetProperty(column).GetValue(x)).ToList()
                : FilteretKundeListe.OrderByDescending(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
        }


        private string GetSortIndicator(string columnName)
        {
            if (currentSortingColumn == columnName)
            {
                return new string(isAscending ? "⬆" : "⬇");
            }
            return new string(string.Empty);
        }
    }
}
