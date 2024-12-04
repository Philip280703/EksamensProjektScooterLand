using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class Medarbejder
    {
       
        [Key]
        [Required(ErrorMessage = "CPR-nummer er påkrævet ")]
        public string CprNummer { get; set; }

        
        [Required(ErrorMessage = "Adgangskode er påkrævet.")]
        public string Adgangskode { get; set; }



        [Required(ErrorMessage ="Rolle er påkrævet")]
        public string Rolle {  get; set; }


        [Required(ErrorMessage = "Fornavn er påkrævet")]
        [StringLength(30, ErrorMessage = "Fornavn må maksimalt være 30 tegn langt.")]
        public string Fornavn { get; set; }



        [Required(ErrorMessage = "Efternavn er påkrævet.")]
        [StringLength(30, ErrorMessage = "Efternavn må maksimalt være 30 tegn langt.")]
        public string Efternavn { get; set; }

    }
}
