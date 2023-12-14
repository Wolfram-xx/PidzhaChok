using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Interfaces;
using Infrastructure.Data;
using System.Reflection.Metadata;
using Pidzha.Domain;

namespace Infrastructure.Repository
{
    internal class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;
        public DataContext Unit
        {
            get
            {
                return _context;
            }
        }

        public async Task<Teacher> GetTeacher(string name)
        {
            return await _context.Teachers
                .Where(p => p.Name == name)
                .Include(p => p.Name)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await _context.Teachers.Include(p => p.Name)
                .OrderBy(p => p.Name).ToListAsync();
        }



        public Task<Teacher> Get(string name)
        {
            throw new NotImplementedException();
        }

        Task<List<Discipline>> IBaseRepository<Discipline>.GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
