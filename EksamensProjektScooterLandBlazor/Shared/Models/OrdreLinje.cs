using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class OrdreLinje
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdreLinjeID { get; set; }


        [Required(ErrorMessage ="Antal er påkrævet.")]
        [Range(1,1000, ErrorMessage = "Antal skal være mellem 1 og 1000")]
        public int Antal {  get; set; }


        [Range(1, int.MaxValue, ErrorMessage ="Total skal være postivt.")]
        public int Total { get; set; }

        // fremmednøgle
        public int YdelseID { get; set; }

        // fremmednøgle
        public int ProduktID { get; set; }

        // fremmednøgle
        public int OrdreID { get; set; }



    }
}
