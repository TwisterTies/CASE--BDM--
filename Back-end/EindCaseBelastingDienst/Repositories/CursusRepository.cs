using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EindCaseBelastingDienst.DataAccess;
using EindCaseBelastingDienst.Models;

namespace EindCaseBelastingDienst.Repositories
{
    public class CursusRepository : ICursusRepository
    {
        private readonly CursusContext _context;
        public CursusRepository(CursusContext context)
        {
            this._context = context;
        }

        public void Add(Cursus newCursus)
        {
            _context.Cursussen.Add(newCursus);
            _context.SaveChangesAsync();
        }


    }
}
