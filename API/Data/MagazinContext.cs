using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using API.Entitati;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MagazinContext:DbContext
    {
        public MagazinContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Produs> Produs { get; set; }
    }
}