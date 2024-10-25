using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(string name, string email,string password,string phoneNumber, string occupation, string document, string address, Guid fielWorkId)
        {
            Name = name;

            Email = email;
            Password = password;

            PhoneNumber = phoneNumber;

            Occupation = occupation;

            Document = document;

            Address = address;

            Notes = new List<Note>();

            Opportunities = new List<Opportunity>();

            FielWorkId = fielWorkId;

            //WorkFields = new List<FieldWork>();
            IsDeleted = false;
        }

        public string Name { get; private set; }

        public string Email { get; private set; }
        public string Password { get; private set; }

        public string PhoneNumber { get; private set; }

        public string Occupation { get; private set; }

        public string Document { get; private set; }

        public string Address { get; private set; }

        public List<Note> Notes { get; private set; }

        public FieldWork FieldWork { get; private set; }

        public Guid FielWorkId { get; private set; }

        public List<Opportunity> Opportunities { get; private set; }

        public bool IsDeleted { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
        }
        public void Update(string email, string phoneNumber, string occupation, string address)
        {
            Email=email;

            PhoneNumber=phoneNumber;

            Occupation=occupation;

            Address=address;

        }
    }
}
