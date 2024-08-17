using CRMDev.Application.Queries.GetAllFieldWork;
using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetAllOpportunity
{
    public class GetAllOpportunityQueryHandler : IRequestHandler<GetAllOpportunityQuery, ResultViewModel<List<OpportunityViewModel>>>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public GetAllOpportunityQueryHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }
        
        public async Task<ResultViewModel<List<OpportunityViewModel>>> Handle(GetAllOpportunityQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await _opportunityRepository.GetAllAsync();
            //var users = _dbcontext.Users.Where(u => u.IsActive.Equals(true));
            var OpportunitiesViewModel = opportunities.Select(b => new OpportunityViewModel(b.Title
                 , b.Description,b.DueDate,b.Costs,b.Scope,b.IncludedSupport,b.Status,b.Stage))
                 .ToList();

            return ResultViewModel<List<OpportunityViewModel>>.Success(OpportunitiesViewModel);
        }
    }
}
