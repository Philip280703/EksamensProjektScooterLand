using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class ScooterBrand
    {
        [Key]
        public int ScooterBrandID { get; set; }

        [Required]
        public string ScooterBrandNavn { get; set;}


	}

}
