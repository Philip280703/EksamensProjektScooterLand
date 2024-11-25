﻿using EksamensProjektScooterLandBlazor.Client.Services;
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

      
        private Ydelse YdelseModel = new Ydelse();

        [Parameter]
        public bool AddingOrdreBool { get; set; }


        private int ErrorCode { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            EditContext = new EditContext(YdelseModel);
            YdelsesList = (await Service.GetAllYdelser()).ToList();
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
    }
}
