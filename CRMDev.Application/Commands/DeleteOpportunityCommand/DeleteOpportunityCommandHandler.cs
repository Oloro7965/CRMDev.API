using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteOpportunityCommand
{
    public class DeleteOpportunityCommandHandler : IRequestHandler<DeleteOpportunityCommand, ResultViewModel>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public DeleteOpportunityCommandHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public async Task<ResultViewModel> Handle(DeleteOpportunityCommand request, CancellationToken cancellationToken)
        {
            var opportunity = await _opportunityRepository.GetByIdAsync(request.Id);

            if (opportunity is null)
            {
                return ResultViewModel.Error("Esta oportunidade não existe");
            }

            opportunity.Delete();

            await _opportunityRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
