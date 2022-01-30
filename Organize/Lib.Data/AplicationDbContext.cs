using Microsoft.EntityFrameworkCore;
using Lib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
