using System;
using Microsoft.EntityFrameworkCore;

namespace DIOAsp
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        // responsible for configuring Database options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }
    }
}