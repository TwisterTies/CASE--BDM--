using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EindCaseBelastingDienst.Models;

namespace EindCaseBelastingDienst.DataAccess
{
    public class CursusContext : DbContext
    {
        public CursusContext(DbContextOptions<CursusContext> options): base(options)
        {

        }

        public DbSet<Cursus> Cursussen { get; set; }

        public DbSet<CursusInstantie> CursusInstanties { get; set; }

    }
}
