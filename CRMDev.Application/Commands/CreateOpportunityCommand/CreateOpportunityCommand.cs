using CRMDev.Core.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateOpportunityCommand
{
    public class CreateOpportunityCommand : IRequest<Guid>
    {
        public string Title { get; set; }

        public string Description { get;  set; }

        public DateTime DueDate { get; set; }

        public decimal Costs { get; set; }

        public string Scope { get; set; }

        public string IncludedSupport { get; set; }

        public Guid ContactId { get; set; }
    }
}
