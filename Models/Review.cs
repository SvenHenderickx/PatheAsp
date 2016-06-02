﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatheAsp.Controllers;

namespace PatheAsp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public int AantalSterren { get; set; }
        public Account Plaatser { get; set; }

        public Account(int id, string tekst, int aantalSterren, Account plaatser)
        {
            this.Id = id;
            this.Tekst = tekst;
            this.AantalSterren = aantalSterren;
            this.Plaatser = plaatser;
        }
    }
}
