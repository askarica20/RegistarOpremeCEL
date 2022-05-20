using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarOpremeCEL.Models
{
    public class Oprema
    {
        public int Id { get; set; }
        public string NazivOpreme { get; set; }
        public string VrstaOpreme { get; set; }
        public DateTime DatVrPrimke { get; set; }
        public string NazivProjekta { get; set; }
        public string IzvorFinanciranja { get; set; }
        public string OpisOpreme { get; set; }
        public string OsobaNabave { get; set; }
        public string OsobaPrimke { get; set; }
    }
}
