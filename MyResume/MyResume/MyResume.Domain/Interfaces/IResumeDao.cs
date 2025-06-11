using MyResume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Interfaces
{
    public interface IResumeDao
    {
        Task<IEnumerable<Resume>> GetResumesAsync(int Id);
    }
}
