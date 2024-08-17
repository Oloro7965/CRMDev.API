using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateFieldWorkCommand
{
    public class CreateFieldWorkCommand:IRequest<Guid>
    {
        public string Title { get; set; }

        public string Description { get;  set; }
    }
}
