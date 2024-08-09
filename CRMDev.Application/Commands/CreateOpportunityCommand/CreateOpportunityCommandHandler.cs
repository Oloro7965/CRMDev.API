using CRMDev.Core.Domain.Entities;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateOpportunityCommand
{
    public class CreateOpportunityCommandHandler : IRequestHandler<CreateOpportunityCommand, Guid>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public CreateOpportunityCommandHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public async Task<Guid> Handle(CreateOpportunityCommand request, CancellationToken cancellationToken)
        {
            var opportunity = new Opportunity(request.Title,request.Description,request.DueDate
                ,request.Costs,request.Scope,request.IncludedSupport,request.ContactId);

            await _opportunityRepository.AddAsync(opportunity);

            return opportunity.Id;
        }
    }
}
