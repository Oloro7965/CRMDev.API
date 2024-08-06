using CRMDev.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class ContactViewModel
    {
        public ContactViewModel(string name, string email, string phoneNumber, string occupation, List<Note> notes)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
            Notes = notes;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get;private set; }
        public string Occupation { get; private set; }
        public List<Note> Notes { get; private set; }
    }
}
