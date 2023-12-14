using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pidzha.Domain.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; } = null!;
        public DbSet<EducationalPlan> EducationalPlans { get; set; } = null!;
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<EducationalProgram> EducationalPrograms { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();
        }

    }
}
