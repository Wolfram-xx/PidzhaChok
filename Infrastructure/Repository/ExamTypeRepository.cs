using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Pidzha.Domain;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal class ExamTypeRepository : IExamTypeRepository
    {
        private readonly DataContext _context;
        public DataContext Unit
        {
            get
            {
                return _context;
            }
        }
        public async Task<List<ExamType>> GetAll()
        {
            return await _context.ExamTypes.Include(p => p.Name)
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<ExamType> GetByType(string type)
        {
            return await _context.ExamTypes
                .Where(p => p.Name == type)
                .Include(p => p.Name)
                .FirstOrDefaultAsync();
        }
    }
  }

