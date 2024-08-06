using CRMDev.Core.Domain.Entities;
using CRMDev.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Infraestructure.Persistance.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly CRMDevDbContext _dbcontext;

        public NoteRepository(CRMDevDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(Note note)
        {
            await _dbcontext.Notes.AddAsync(note);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
