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
    public class OpportunityRepository : IOpportunityRepository
    {
        private readonly CRMDevDbContext _dbcontext;

        public OpportunityRepository(CRMDevDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(Opportunity opportunity)
        {
            await _dbcontext.Opportunities.AddAsync(opportunity);

            await SaveChangesAsync();
        }

        public async Task<List<Opportunity>> GetAllAsync()
        {
            return await _dbcontext.Opportunities.ToListAsync();
        }

        public async Task<Opportunity> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Opportunities.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
