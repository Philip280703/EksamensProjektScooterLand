﻿using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace EksamensProjektScooterLandBlazor.Client.ChildComponents
{
	public partial class RenderKunde
	{
		[Parameter]
		public Kunde kunde { get; set; }
	}
}