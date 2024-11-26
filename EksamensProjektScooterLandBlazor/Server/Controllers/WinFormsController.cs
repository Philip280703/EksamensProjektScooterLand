using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")] // Denne rute siger, at alt som starter med "api/WinForms", går til den her controller
	public class WinFormsController : ControllerBase
	{
		[HttpGet("åbnbackupform")] //skal være en GET-anmodning med ruten "api/WinForms/åbnbackupform"
		// IActionResult er et Interface som angiver, at metoden kan returnere et hvilket som helst HTTP-svar. 
		public IActionResult ÅbnBackupForm()
		{
            Console.WriteLine("Åbnbackupform kaldet");
			try
			{
				string path = "EksamensProjektScooterLand\\ScooterLandWinForms\\bin\\Debug\\net8.0-windows\\ScooterLandWinForms.exe";
				//Forsøg på at åbne WinForms-applikation, hvis filen findes.
				Process.Start("C:\\Users\\markr\\source\\repos\\"+path);
				return Ok("Backup Projekt startet");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Fejl: {ex.Message}");
			}
		}
	}
}
