using CRMDev.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateContactCommand
{
    public class CreateContactCommand:IRequest<Guid>
    {
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        

    }
}
