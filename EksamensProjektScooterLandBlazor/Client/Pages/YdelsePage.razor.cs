using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class YdelsePage
    {
        [Inject]
        public IYdelseService Service { get; set; }

        private List<Ydelse> YdelsesList = new List<Ydelse>();

        private int ErrorCode { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            YdelsesList = (await Service.GetAllYdelser()).ToList();
        }

        // Nyt item som oprettes gennem formen
        private Ydelse newYdelse = new Ydelse();

        public async Task AddYdelseHandler()
        {
            ErrorCode = await Service.AddYdelse(newYdelse);
            Console.WriteLine("Shopping item added: return code: " + ErrorCode);

            // Ryd formen efter tilføjelse
            newYdelse = new Ydelse();
        }


        public async Task RemoveYdelseHandler()
        {

        }

        public async Task UpdateYdelseHandler()
        {

        }

    }
}
