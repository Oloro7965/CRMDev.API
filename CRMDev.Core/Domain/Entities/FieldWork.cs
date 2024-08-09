using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class FieldWork : BaseEntity
    {
        public FieldWork(string title, string description)
        {
            Title = title;
            Description = description;
            IsDeleted = false;
        }

        public string Title { get;private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }
        public void Delete() {
            IsDeleted = true;
        }
        public void Update(string description)
        {
            Description = description;
        }
    }
}
