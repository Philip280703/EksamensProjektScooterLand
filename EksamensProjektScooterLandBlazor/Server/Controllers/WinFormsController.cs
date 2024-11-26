using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class WinFormsController : ControllerBase
	{
		[HttpGet("åbnbackupform")]
		public IActionResult ÅbnBackupForm()
		{
            Console.WriteLine("Åbnbackupform kaldet");
			try
			{
				string path = "EksamensProjektScooterLand\\ScooterLandWinForms\\bin\\Debug\\net8.0-windows\\ScooterLandWinForms.exe";
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
