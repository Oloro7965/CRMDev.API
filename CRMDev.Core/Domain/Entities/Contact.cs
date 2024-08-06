using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(string name, string email, string phoneNumber, string occupation, string document, string address, string notes)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
            Document = document;
            Address = address;
            Notes = new List<Note>();
            IsDeleted = false;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Occupation { get; private set; }
        public string? Document { get; private set; }
        public string? Address { get; private set; }
        public List<Note> Notes { get; private set; }
        public bool IsDeleted { get; private set; }
    }
}
