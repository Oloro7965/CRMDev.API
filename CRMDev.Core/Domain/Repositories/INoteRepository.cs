using CRMDev.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Repositories
{
    public interface INoteRepository
    {
        //Task<List<Note>> GetAllAsync();
        //Task<Contact> GetByIdAsync(Guid id);
        Task AddAsync(Note note);
        Task SaveChangesAsync();
    }
}
