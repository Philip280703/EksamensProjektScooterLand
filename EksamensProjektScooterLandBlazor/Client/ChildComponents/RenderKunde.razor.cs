﻿using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace EksamensProjektScooterLandBlazor.Client.ChildComponents
{
	public partial class RenderKunde
	{
		[Parameter]
		public Kunde kunde { get; set; }

		private List<Mekaniker> mekanikerListe { get; set; }

		[Inject]
		public IMekanikerService Service { get; set; }

		protected override async Task OnInitializedAsync()
		{
			mekanikerListe = (await Service.GetAllMekaniker()).ToList();
		}
	}
}
