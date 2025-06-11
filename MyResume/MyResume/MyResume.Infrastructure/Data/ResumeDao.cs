using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Entities;
using MyResume.Domain.Interfaces;

namespace MyResume.Infrastructure.Data
{
    public class ResumeDao : IResumeDao
    {
        private readonly AppDbContext _context;
        public async Task<IEnumerable<Resume>> GetResumesAsync(int Id)
        {
            return await _context.Resume
                .Where(r => r.Id == Id)
                .ToListAsync();
        }
    }
}
