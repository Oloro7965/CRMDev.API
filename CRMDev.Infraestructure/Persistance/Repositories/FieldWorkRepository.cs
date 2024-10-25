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
    public class FieldWorkRepository : IFieldWorkRepository
    {
        private readonly CRMDevDbContext _dbcontext;

        public FieldWorkRepository(CRMDevDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(FieldWork field)
        {
            await _dbcontext.WorkFields.AddAsync(field);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<FieldWork>> GetAllAsync()
        {
            return await _dbcontext.WorkFields.ToListAsync();
        }

        public async Task<FieldWork> GetByIdAsync(Guid id)
        {
            return await _dbcontext.WorkFields.SingleOrDefaultAsync(u => u.Id == id);
            //usar singleOrDefault
        }
        public async Task<FieldWork> GetByNameAsync(string name)
        {
            return await _dbcontext.WorkFields.SingleOrDefaultAsync(u => u.Title == name);
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
