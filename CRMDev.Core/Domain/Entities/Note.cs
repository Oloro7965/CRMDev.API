using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class Note : BaseEntity
    {
        public Note(string content,Guid contactId)
        {
            Content = content;

            ContactId = contactId;

        }

        public string Content { get; private set; }

        public Guid ContactId { get; private set; }

        public Contact contact { get; private set; }

    }
}
