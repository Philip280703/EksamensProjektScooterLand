using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class Kunde
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KundeID { get; set; }


        [Required(ErrorMessage ="Fornavn er påkrævet")]
        [StringLength(30, ErrorMessage = "Fornavn må maksimalt være 30 tegn langt.")]
        public string Fornavn { get; set; }


        [Required(ErrorMessage = "Efternavn er påkrævet.")]
        [StringLength(30, ErrorMessage = "Efternavn må maksimalt være 30 tegn langt.")]
        public string Efternavn { get; set; }


        [Required(ErrorMessage = "Scooter brand ID er påkrævet.")]
        [Range(1, 100, ErrorMessage = "Indtast gyldigt ScooterBrandID.")]
        public int ScooterBrandID { get; set; }


        [Required(ErrorMessage = "Telefonnummer er påkrævet")]
        [Phone(ErrorMessage = "Telefonnummeret er ugyldigt.")]
        public string TelefonNummer { get; set; }


        [Required(ErrorMessage = "Email er påkrævet")]
        [EmailAddress(ErrorMessage = "Email-adressen er ugyldig.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Postnummer er påkrævet.")]
        [Range(1000, 9990, ErrorMessage = "Postnummeret skal være et gyldigt dansk postnummer")]
        public int PostNummer { get; set; }


        [Required(ErrorMessage = "Vejnavn er påkrævet.")]
        public string VejNavn { get; set; }


        [Required(ErrorMessage = "Husnummer er påkrævet.")]
        [StringLength(4, ErrorMessage = "Skal være et gyldigt husnummer")]
        public string HusNummer { get; set; }

        [StringLength(2, ErrorMessage ="Skal være gyldig etage. maks 2 tegn.")]
        public string ?Etage { get; set; } 

        [StringLength(2, ErrorMessage = "Skal være gyldig placering. maks 2 tegn. (tv, th, mf)")]
        public string ?Placering { get; set; } 

     
        public string PreferetMekanikerCprNummer { get; set; } 


		[ForeignKey("PreferetMekanikerCprNummer")]
		public Mekaniker ?Mekaniker { get; set; }


        [ForeignKey("PostNummer")]
        public PostNummerOgBy ?PostNummerOgBy { get; set; }


        public Kunde()
        {
           
        }

        public override string ToString()
        {
            return $"{KundeID} {Fornavn} {Efternavn} {TelefonNummer} {Email}";
        }
    }
}
