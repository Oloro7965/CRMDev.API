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
        }

        public string Title { get;private set; }
        public string Description { get; private set; }
    }
}
