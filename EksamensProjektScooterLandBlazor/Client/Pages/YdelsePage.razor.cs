using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class YdelsePage
    {
        [Inject]
        public IYdelseService Service { get; set; }

        private List<Ydelse> YdelsesList = new List<Ydelse>();

        private EditContext EditContext;

        private bool btnVisibility = true;

        public bool visAddYdelse { get; set; } = false;
      
        private Ydelse YdelseModel = new Ydelse();

        [Parameter]
        public bool AddingOrdreBool { get; set; }

        [Parameter]
        public int Ordreid {  get; set; }

        [Parameter]
        public EventCallback ydelseTilføjet { get; set; }

        private int ErrorCode { get; set; } = 0;

        private bool RenderYdelse = false;

        protected override async Task OnInitializedAsync()
        {
            EditContext = new EditContext(YdelseModel);
            YdelsesList = (await Service.GetAllYdelser()).ToList();
            visAddYdelse = false;
        }

        private async void HandleValidSubmit()
        {
            Console.WriteLine("HandleValidSubmit Called...");

            YdelsesList.Add(YdelseModel);
            YdelseModel = new Ydelse();
            EditContext = new EditContext(YdelseModel);
            await AddYdelseHandler();

            StateHasChanged();
        }
        private void HandleInvalidSubmit()
        {
            Console.WriteLine("HandleInvalidSubmit Called...");

        }

        // Nyt ydelse oprettes
       private async Task ydelseTilføj()
        {
                await ydelseTilføjet.InvokeAsync();
        }

        public async Task AddYdelseHandler()
        {
            ErrorCode = await Service.AddYdelse(YdelseModel);
            Console.WriteLine("Ydelse tilføjet: return code: " + ErrorCode);
            // Ryder formen efter tilføjelse
            YdelseModel = new Ydelse();
            StateHasChanged();
        }

        public async Task DeleteYdelseHandler()
        {

        }

        public async Task UpdateYdelseHandler()
        {
            ErrorCode = await Service.UpdateYdelse(YdelseModel);
            Console.WriteLine("Ydelse opdateret: return code: " + ErrorCode);
            YdelseModel = new Ydelse();
            StateHasChanged();
        }

        private void OpenAddYdelse()
        {
            visAddYdelse = !visAddYdelse;
        }


		// sortings parametre
		private string currentSortColumn;
		private bool isAscending = true;

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
			YdelsesList = isAscending
				? YdelsesList.OrderBy(x => x.GetType().GetProperty(column).GetValue(x)).ToList()
				: YdelsesList.OrderByDescending(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
		}

        private string SearchText = string.Empty;

        private List<Ydelse> FilteretYdelseList => string.IsNullOrWhiteSpace(SearchText) 
            ? YdelsesList : YdelsesList.Where(y=>y.YdelseNavn.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();

 
	}
}
