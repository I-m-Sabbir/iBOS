using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperation
{
    public class dbAkijFoodDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;
        public dbAkijFoodDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = migrationAssemblyName;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<tblColdDrinks>()
                .HasKey(c => c.intColdDrinksId);

            base.OnModelCreating(builder);
        }

        public DbSet<tblColdDrinks> tblColdDrinks { get; set; }
    }
}
