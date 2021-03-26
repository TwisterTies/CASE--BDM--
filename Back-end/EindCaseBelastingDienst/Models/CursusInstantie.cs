using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EindCaseBelastingDienst.Models
{
    public class CursusInstantie
    {

        public int CursusInstantieId { get; set; }

        public string CursusTijd { get; set; }
        public IList<Cursus> Cursussen { get; set; }
    }
}
