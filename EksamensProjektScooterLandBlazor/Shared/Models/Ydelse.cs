using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class Ydelse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YdelseID { get; set; }


        [Required(ErrorMessage = "Ydelsen skal have et navn")]
        [StringLength(30, ErrorMessage ="Ydelsesnavnet må maksimalt være på 30 tegn.")]
        public string YdelseNavn { get; set; }

        [Required(ErrorMessage = "Estimeret tid for ydelsen skal udfyldes.")]
        [Range(0.25, 10, ErrorMessage ="Tiden skal være mellem 0,25 (15 min) og 10 (timer).")]
        public double EstimeretTid { get; set; }


        [Required(ErrorMessage = "Pris er påkrævet.")]
        [Range(1, int.MaxValue, ErrorMessage ="Prisen skal være positiv")]
        public double Pris {  get; set; }

        
    }
}
