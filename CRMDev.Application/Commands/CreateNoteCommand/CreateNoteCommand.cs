using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateNoteCommand
{
    public class CreateNoteCommand:IRequest<Guid>
    {
        public string Content { get;  set; }
    }
}
