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

        // fremmednøgle
        public int KundeID { get; set; }


        [Range(0, int.MaxValue, ErrorMessage ="Samelt pris skal være et positivt tal")]
        public decimal SamletPris {  get; set; }


        [Range(0, int.MaxValue, ErrorMessage ="Betalings sum skal være et positivt tal")]
        public decimal BetalingsSum { get; set; }


        // fremmednøgle
        public int MedarbejderID { get; set; }


    }
}
