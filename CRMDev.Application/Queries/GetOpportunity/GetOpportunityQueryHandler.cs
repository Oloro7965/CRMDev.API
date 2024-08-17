using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetOpportunity
{
    public class GetOpportunityQueryHandler : IRequestHandler<GetOpportunityQuery, ResultViewModel<OpportunityViewModel>>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public GetOpportunityQueryHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public async Task<ResultViewModel<OpportunityViewModel>> Handle(GetOpportunityQuery request, CancellationToken cancellationToken)
        {
            //var user = _dbcontext.Users.FirstOrDefault(u => u.Id == request.Id);
            var opportunity = await _opportunityRepository.GetByIdAsync(request.Id);

            if (opportunity is null)
            {
                return ResultViewModel<OpportunityViewModel>.Error("Esta oportunidade não existe");
            }

            var OpportunityDetailViewModel = new OpportunityViewModel(opportunity.Title
                 ,opportunity.Description, opportunity.DueDate, opportunity.Costs,
                 opportunity.Scope, opportunity.IncludedSupport, opportunity.Status, opportunity.Stage);

            //var UserDetailViewModel = UserViewModel.FromEntity(user);
            return ResultViewModel<OpportunityViewModel>.Success(OpportunityDetailViewModel);
        }
    }
}
