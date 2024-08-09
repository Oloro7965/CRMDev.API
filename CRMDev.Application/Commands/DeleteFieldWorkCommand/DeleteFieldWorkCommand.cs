using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteFieldWorkCommand
{
    public class DeleteFieldWorkCommand:IRequest<ResultViewModel>
    {
        public DeleteFieldWorkCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
