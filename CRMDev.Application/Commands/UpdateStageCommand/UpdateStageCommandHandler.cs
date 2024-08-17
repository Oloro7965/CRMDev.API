using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateStageCommand
{
    public class UpdateStageCommandHandler : IRequestHandler<UpdateStageCommand, ResultViewModel>
    {
        private readonly IOpportunityRepository _opportunityRepository;

        public UpdateStageCommandHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        public async Task<ResultViewModel> Handle(UpdateStageCommand request, CancellationToken cancellationToken)
        {
            var opportunity = await _opportunityRepository.GetByIdAsync(request.Id);

            if (opportunity is null)
            {
                return ResultViewModel.Error("Oportunidade não existe");
            }

            opportunity.UpdateStage(request.ChangeToStatus);

            //_dbcontext.Update(user);  
            _opportunityRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
