using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteOpportunityCommand
{
    public class DeleteOpportunityCommand:IRequest<ResultViewModel>
    {
        public Guid Id { get; set; }
    }
}
