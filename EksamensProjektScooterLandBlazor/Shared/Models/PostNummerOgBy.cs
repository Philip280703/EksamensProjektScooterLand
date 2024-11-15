using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjektScooterLandBlazor.Shared.Models
{
    public class PostNummerOgBy
    {
        [Key]
        public int Postnummer {  get; set; }

        public string ByNavn { get; set; }


        public override string ToString()
        {
            return $"postnummer = {Postnummer}, by = {ByNavn}";
        }

    }
}
