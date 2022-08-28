using Compro_Intern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Daaataaa
{
    public class IntContext:DbContext
    {
        public IntContext(DbContextOptions<IntContext> options) : base(options)
        {

        }


        public DbSet<RegInt> Regs { get; set; }

        public DbSet<IntRec> Recs { get; set; }
        public DbSet<IntDesg> Desgs { get; set; }
        public DbSet<IntReql> Ls { get; set; }
        public DbSet<IntStat> Sts { get; set; }
        public DbSet<IntWhr> Hrs { get; set; }


    }
}
