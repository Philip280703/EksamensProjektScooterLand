﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
	internal class Mekaniker : Medarbejder 
	{
		// fremmednøgle
		[Required(ErrorMessage = "Scooter brand ID af ekspertise er påkrævet. (0 for ikke mekaniker medarbejder)")]
		[Range(1, 100, ErrorMessage = "Indtast gyldigt ScooterBrandID.")]
		public int ScooterBrandIDEkspertise { get; set; }
	}
}
