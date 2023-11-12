using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marcu_Bogdan_Lab2.Models;

namespace Marcu_Bogdan_Lab2.Data
{
    public class Marcu_Bogdan_Lab2Context : DbContext
    {
        public Marcu_Bogdan_Lab2Context (DbContextOptions<Marcu_Bogdan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Marcu_Bogdan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Marcu_Bogdan_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Marcu_Bogdan_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Marcu_Bogdan_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Marcu_Bogdan_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
