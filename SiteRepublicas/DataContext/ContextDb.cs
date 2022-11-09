using Microsoft.EntityFrameworkCore;
using SiteRepublicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteRepublicas.DataContext
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {

        }
        public DbSet<Republicas> Republicas { get; set; }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Republicas>().HasKey(c => c.Id);

        }

    }
}
