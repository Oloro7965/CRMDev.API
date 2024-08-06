using CRMDev.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Repositories
{
    public interface IFieldWorkRepository
    {
        Task<List<FieldWork>> GetAllAsync();
        //Task<FieldWork> GetByIdAsync(Guid id);
        Task AddAsync(FieldWork field);
        Task SaveChangesAsync();
    }
}
