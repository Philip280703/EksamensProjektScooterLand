using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
	public class Mekaniker : Medarbejder 
	{
		public int ScooterBrandId { get; set; }

		[ForeignKey("ScooterBrandId")]
		public ScooterBrand ?scooterBrand { get; set; }
	}
}
