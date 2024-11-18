using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class ScooterBrand
    {
        [Key]
        public int ScooterBrandID { get; set; }

        [Required]
        public string ScooterBrandNavn { get; set;}

        public List<Mekaniker> mekanikers { get; set; }


		public override string ToString()
		{
			return $"{ScooterBrandID}, {ScooterBrandNavn}";
		}

	}

}
