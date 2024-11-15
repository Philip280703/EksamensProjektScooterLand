using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class Produkt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProduktID { get; set; }


        [Required(ErrorMessage = "Produktnavn er påkrævet.")]
        [StringLength(50, ErrorMessage ="Produktnavnet må ikke overstige 50 tegn")]
        public string ProduktNavn { get; set; }


        [Required(ErrorMessage = "Produkt prisen er påkrævet")]
        [Range(0.1 ,double.MaxValue, ErrorMessage ="Prisen skal være positiv.")]
        public double ProduktPris { get; set; } = 0;
    }
}
