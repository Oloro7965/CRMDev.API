using CRMDev.Core.Domain.Entities;
using CRMDev.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Infraestructure.Persistance.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly CRMDevDbContext _dbcontext;

        public ContactRepository(CRMDevDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(Contact contact)
        {
            await _dbcontext.Contacts.AddAsync(contact);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _dbcontext.Contacts.Where(u => u.IsDeleted.Equals(false)).ToListAsync();
        }

        public async Task<Contact> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Contacts.Where(c=>c.IsDeleted.Equals(false))
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
