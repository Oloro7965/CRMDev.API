using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class Note : BaseEntity
    {
        public string Content { get; private set; }
    }
}
