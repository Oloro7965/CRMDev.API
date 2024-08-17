using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateFieldWorkCommand
{
    public class UpdateFieldWorkCommandHandler : IRequestHandler<UpdateFieldWorkCommand, ResultViewModel>
    {
        private readonly IFieldWorkRepository _fieldWorkRepository;

        public UpdateFieldWorkCommandHandler(IFieldWorkRepository fieldWorkRepository)
        {
            _fieldWorkRepository = fieldWorkRepository;
        }

        public async Task<ResultViewModel> Handle(UpdateFieldWorkCommand request, CancellationToken cancellationToken)
        {
            var fieldwork = await _fieldWorkRepository.GetByIdAsync(request.Id);

            if (fieldwork is null)
            {
                return ResultViewModel.Error("Contato não existe");
            }

            fieldwork.Update(request.Description);

            //_dbcontext.Update(user);  
            _fieldWorkRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
