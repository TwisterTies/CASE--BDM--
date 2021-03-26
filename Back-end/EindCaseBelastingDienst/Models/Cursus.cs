using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EindCaseBelastingDienst.Models
{
    public class Cursus
    {
        public int CursusId { get; set; }
        public string CursusCode { get; set; }

        public string Naam { get; set; }

        public int Duur { get; set; }

        public int CursusInstantieId { get; set; }

        public CursusInstantie CursusInstantie { get; set; }
    }
}
