using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RepositoryContext : DbContext
    {
        protected override void OnConfiguring
      (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "InsurancePremiumDb");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Occupation> Occupations { get; set; }

        public DbSet<Rating> Ratings { get; set; }
    }
}
