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
        // --------- Validere CPR-nummer forklaring -------------- 

        // (0[1-9]|[12][0-9]|3[01]) - 
        // Validere gyldighed af Dato DD.. Ved kombination af 0 og 1-9 value, eller 1 til 2 som ti'er og 0-9 value. dertil 3 som ti'er og 0-1 som en'er værdi

        // (0[1-9]|1[0-2])
        // validere om det er en måned MM. 0 som ti'er og 1-9 som ener eller om værdien er 10-12. dermed en gyldig måned

        // \d{2}
        // Validere om det et år YY. ved at tjekke om cifre er lig 00 - 99

        // \d{4}$
        // Validere om der er 4 cifre til sidst. Specificere at der skal være præcis 4 cifre og ikke tillader flere ved brug ag $-tegn
        [Key]
        [Required(ErrorMessage = "CPR-nummer er påkrævet ")]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])(0[1-9]|1[0-2])\d{2}\d{4}$",
        ErrorMessage = "Skal være et gyldigt CPR nummer (ddMMyyXXXX format)")]
        public string CprNummer { get; set; }

        
        [Required(ErrorMessage = "Adgangskode er påkrævet.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&._])[A-Za-z\d@$!%*?&._]{8,}$",
        ErrorMessage = "Adgangskoden skal indeholde minimum 8 tegn, et stort bogstav, et lille bogstav, et tal og et specialtegn.")]
        public string Adgangskode { get; set; }


        // ----------- Validere Adgangskode forklaring ---------------
        //@"^(?=.*[A-Z])
        // starter et pattern. Her specificeres om adgangskoden indeholder minimum et stort bogstav

        // (?=.*[a-z])
        // Tjekker om adgangskoden indeholder minimum et lille bogstav

        // (?=.*\d)
        // Indeholder det minimum et digit (0-9)

        // (?=.*[@$!%*?&._])
        // Tjekker om det indeholder minimum et af disse specificeret specialtegn

        // [A-Za-z\d@$!%*?&._]{8,}$"
        //Kravsspecefikationerne samlet og opsumeret med en minimumslængde på 8 tegn. $-tegn viser at patern afsluttes og det hele matcher fra start (^) til slut.


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
