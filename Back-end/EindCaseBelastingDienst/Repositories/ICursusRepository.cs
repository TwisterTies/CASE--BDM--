using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EindCaseBelastingDienst.Models;

namespace EindCaseBelastingDienst.Repositories
{
    public interface ICursusRepository
    {
        void Add(Cursus newCursus);
    }
}
