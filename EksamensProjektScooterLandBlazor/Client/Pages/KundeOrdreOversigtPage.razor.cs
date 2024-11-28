using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Identity.Client;

namespace EksamensProjektScooterLandBlazor.Client.Pages
{
    public partial class KundeOrdreOversigtPage
    {
        public List<Ordre> ordreList { get; set; } = new List<Ordre>();

        public IOrdreService ordreService { get; set; }

        protected override async void OnInitialized()
        {
            ordreList = (await ordreService.GetAllOrdrer()).ToList();
        }
    }
}
