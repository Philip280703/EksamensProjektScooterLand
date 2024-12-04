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
                // Filter the list based on the selected ScooterBrandID
                FilteretKundeListe = kundeListe.Where(k => k.ScooterBrandID == sortedScooterBrandID).ToList();
            }
            else
            {
                // Reset to the full list if no valid ScooterBrandID is selected
                FilteretKundeListe = kundeListe;
            }
        }



        // sortings parametre
        private string currentSortColumn;
        private bool isAscending = true;
        private string UiValue { get; set; } = "";

        private void SortByColumn(string column)
        {
            if (currentSortColumn == column)
            {
                isAscending = !isAscending; // Toggle sorting direction
            }
            else
            {
                currentSortColumn = column;
                isAscending = true; // Default to ascending for new column
            }

            // Sort the list dynamically based on the column name
            kundeListe = isAscending
                ? kundeListe.OrderBy(x => x.GetType().GetProperty(column).GetValue(x)).ToList()
                : kundeListe.OrderByDescending(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
        }

        // der bruges MarkupString til at rendere HTML i blazor kode. Det bliver brugt i ønsket om at bruge blazor bootsratp ikonerne 
        private MarkupString GetSortIndicator(string columnName)
        {
            if (currentSortColumn == columnName)
            {
                // Returnere MarkupString som enten er bi bi-chevron-up eller bi bi-chevron-down, som er pilene. Bootstrap ikonerne
                return new MarkupString(isAscending ? "<i class='bi bi-chevron-up'></i>" : "<i class='bi bi-chevron-down'></i>");
            }
            return new MarkupString(string.Empty);
        }
    }
    // Uden brug af MarkupString ville de specifikke pile fra blazor bootsrap ikke kunne indlæses ordentligt på vores websted. 


}
