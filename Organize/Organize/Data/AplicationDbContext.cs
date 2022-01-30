using Microsoft.EntityFrameworkCore;
using Organize.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organize.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
