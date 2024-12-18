﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Links til stackoverflow hvor inspiration er taget fra:
// https://stackoverflow.com/questions/11682470/run-another-local-application-in-asp-net-website/11682671
// https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start?view=net-9.0&redirectedfrom=MSDN#overloads

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/winform")] // Denne rute siger, at alt som starter med "api/WinForms", går til den her controller
	public class WinFormsController : ControllerBase
	{
		[HttpGet] //skal være en GET-anmodning med ruten "api/WinForms/OpenBackupForm"
		// IActionResult er et Interface som angiver, at metoden kan returnere et hvilket som helst HTTP-svar.
		public IActionResult OpenBackupForm()
		{
            Console.WriteLine("Openbackupform kaldet");
			try
			{
				// henter directory
				string currentDirec = Directory.GetCurrentDirectory();
				// splitter ved projekt ref
				string localDirec = currentDirec.Split("EksamensProjektScooterLand\\")[0];
				// path til WinForms exe filen
                string path = "EksamensProjektScooterLand\\ScooterLandWinForms\\bin\\Debug\\net8.0-windows\\ScooterLandWinForms.exe";
				// kombinerer de to path
                string fullPath = localDirec + path;
				// start Winforms
				Process.Start(fullPath);
                Console.WriteLine(fullPath);
				return Ok("Backup Projekt startet");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Fejl: {ex.Message}");
			}
		}
	}
}
