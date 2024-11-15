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
        public int KmTalDifference {  get; set; }


        [Range(0, 1, ErrorMessage ="Ledigheden skal enten være 0 for optaget eller 1 for ledig")]
        public bool Ledig {  get; set; }


        [Range(0, 20000, ErrorMessage ="Selvrisiko skal være mellem 0 og 20.000")]
        public double SelvRisiko { get; set; }


        [Range(0.01, 15, ErrorMessage ="Forsikring skal være mellem 0,01 og 15,00 kr. pr. km. kørt")]
        public double ForsikringPrKm { get; set; }


        [Range(1, 100, ErrorMessage ="Antal dage scooteren er lejet skal være mellem 1 og 100")]
        public int AntalDage { get; set; }


        [Range(0.1, 1000, ErrorMessage ="DagsLejePrisen skal være mellem 0.1 og 1000 kr. pr. dag.")]
        public double DagsLejePris { get; set; }


        [Range(1, 10000, ErrorMessage ="Prisen for scooterLeje skal være mellem 1 og 10000 kr.")]
        public double Pris { get; set; }


    }
}
