using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class ScooterLeje
    {
        [Key]
        public int ScooterID { get; set; }


        [Required(ErrorMessage = "Scooterens kilometertal er påkrævet.")]
        [Range(1, int.MaxValue, ErrorMessage = "Kilometer tal skal være postivt.")]
        public int KmTal {  get; set; }


        [Range(0, 1, ErrorMessage ="Ledigheden skal enten være 0 for optaget eller 1 for ledig")]
        public bool Ledig {  get; set; }


        [Range(0, 20000, ErrorMessage ="Selvrisiko skal være mellem 0 og 20.000")]
        public decimal SelvRisiko { get; set; }

        [Range(0.01, 15, ErrorMessage ="Forsikring skal være mellem 0,01 og 15,00 kr. pr. km. kørt")]
        public decimal ForsikringPrKm { get; set; }


    }
}
