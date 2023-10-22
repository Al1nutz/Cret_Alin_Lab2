using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cret_Alin_Lab2.Models;

namespace Cret_Alin_Lab2.Data
{
    public class Cret_Alin_Lab2Context : DbContext
    {
        public Cret_Alin_Lab2Context (DbContextOptions<Cret_Alin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cret_Alin_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cret_Alin_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
