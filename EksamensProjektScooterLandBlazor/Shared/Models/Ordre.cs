using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class Ordre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdreID { get; set; }


        [Required]
        public DateTime SalgsDato { get; set; }


        [Range(0, int.MaxValue, ErrorMessage ="Samelt pris skal være et positivt tal")]
        public double SamletPris {  get; set; }


        [Range(0, int.MaxValue, ErrorMessage ="Betalings sum skal være et positivt tal")]
        public double BetalingsSum { get; set; }


        // fremmednøgle
        public int KundeiD { get; set; }
        // objekt relation til EF
        public Kunde kunde { get; set; }


        // fremmednøgle
        public int MedarbejderCpr { get; set; }
        // objekt relation til EF
        public Medarbejder medarbejder { get; set; }


        //en ordre indeholder en liste af ordelinjer
        public List<OrdreLinje> ordreLinjer { get; private set; } = new List<OrdreLinje>();


    }
}
