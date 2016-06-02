using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatheAsp.Models
{
    public class Bioscoop
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Plaats { get; set; }
        public string Adres { get; set; }
        public string PostCode { get; set; }
        public bool Lift { get; set; }
        public bool RolstoelMogelijkheid { get; set; }
        public bool Ringleiding { get; set; }
        public string Geluidssysteem { get; set; }
        public string Openingstijden { get; set; }
    }
}
