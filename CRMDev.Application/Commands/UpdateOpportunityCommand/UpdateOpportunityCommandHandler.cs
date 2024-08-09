using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateOpportunityCommand
{
    public class UpdateOpportunityCommandHandler : IRequestHandler<UpdateOpportunityCommand, ResultViewModel>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public UpdateOpportunityCommandHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public async Task<ResultViewModel> Handle(UpdateOpportunityCommand request, CancellationToken cancellationToken)
        {
            var opportunity = await _opportunityRepository.GetByIdAsync(request.Id);
            if (opportunity is null)
            {
                return ResultViewModel.Error("Contato não existe");
            }
            opportunity.Update(request.Title,request.Description,request.DueDate
                ,request.Costs,request.Scope,request.IncludedSupport);

            //_dbcontext.Update(user);  
            _opportunityRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
