using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteContactCommand
{
    public class DeleteContactCommand:IRequest<ResultViewModel>
    {
        public DeleteContactCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
