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
        public int PostNummer {  get; set; }

        public string ByNavn { get; set; }
    }
}
