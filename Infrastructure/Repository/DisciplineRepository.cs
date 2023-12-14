using Infrastructure.Data;
using Infrastructure.Interfaces;
using Pidzha.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal class DisciplineRepository : IDisciplineRepository
    {
        private readonly DataContext _context;
        public DataContext Unit
        {
            get
            {
                return _context;
            }
        }
        public DisciplineRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Discipline>> GetAll()
        {
            return await _context.Disciplines
                .Include(p => p.Hours)
                .OrderBy(p => p.Name).ToListAsync();
        }



    }
}

