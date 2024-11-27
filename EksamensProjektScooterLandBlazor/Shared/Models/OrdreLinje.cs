﻿using System;
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

        [Required]
        public DateTime OrdreLinjeDato { get; set; }


        [Required(ErrorMessage ="Antal er påkrævet.")]
        [Range(1,1000, ErrorMessage = "Antal skal være mellem 1 og 1000")]
        public int Antal {  get; set; }

        // bruges til dagsleje på scooterleje ordrelinje.
        public int ?AntalEkstra { get; set; }


        [Range(0, 99, ErrorMessage ="Rabat skal være mellem 0 og 99 procent, skrives i hele tal")]
        public int ?RabatProcent { get; set; }


        // fremmednøgle
        public int ?YdelseID { get; set; }
        // objekt relation til EF
        public Ydelse ?ydelse { get; set; }


        // fremmednøgle
        public int ?ProduktID { get; set; }
        // objekt relation til EF
        public Produkt ?produkt { get; set; }


        // fremmednøgle
        public int ?ScooterLejeID { get; set; }
        // objekt relation til EF
        public ScooterLeje ?scooterLeje { get; set; }


        // fremmednøgle
        public int OrdreID { get; set; }

        // objekt relation til EF
        public Ordre ?ordre { get; set; }


    }
}
