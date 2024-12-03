using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EksamensProjektScooterLandBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/kørprogram")]
    public class KørendeprogramController : ControllerBase
    {
        [HttpGet]
        public IActionResult Kørendeprogramtjek(string programnavn)
        {
            try
            {
                var process = Process.GetProcessesByName(programnavn).FirstOrDefault();

                if(process != null)
                {
                    return Ok(true);
                }
                else
                {
                    return Ok(false);    
                }
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
