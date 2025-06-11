using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Entities;
using System.Collections.Generic;

namespace MyResume.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Resume> Resume { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // For SQL Server LocalDB
            optionsBuilder.UseSqlServer(@"Server=(localDb)\DemoDBLocal;Database=MyResumeDb;Trusted_Connection=True;");
        }
    }
}
