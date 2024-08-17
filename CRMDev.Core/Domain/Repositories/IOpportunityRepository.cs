using CRMDev.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Repositories
{
    public interface IOpportunityRepository
    {
        Task<List<Opportunity>> GetAllAsync();

        Task<Opportunity> GetByIdAsync(Guid id);

        Task AddAsync(Opportunity opportunity);

        Task SaveChangesAsync();

    }
}
