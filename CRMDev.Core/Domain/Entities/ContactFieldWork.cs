using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class ContactFieldWork:BaseEntity
    {
        public ContactFieldWork(Guid contactId, Guid fieldWorkId)
        {
            ContactId = contactId;
            FieldWorkId = fieldWorkId;
        }

        public Guid ContactId { get; private set; }
        public Guid FieldWorkId { get; private set; }
    }
}
