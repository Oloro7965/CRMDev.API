using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateOpportunityCommand
{
    public class UpdateOpportunityCommand:IRequest<ResultViewModel>
    {
        public Guid Id { get; set; }
        public string Title { get;  set; }
        public string Description { get;  set; }
        public DateTime DueDate { get; set; }
        public decimal Costs { get; set; }
        public string Scope { get; set; }
        public string IncludedSupport { get;  set; }
    }
}
