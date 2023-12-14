using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pidzha.Domain;

namespace Infrastructure.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<ExamType> ExamTypes { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=PidzhaDB;Integrated Security=True");
        }

    }
}
