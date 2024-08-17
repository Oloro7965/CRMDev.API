using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteFieldWorkCommand
{
    public class DeleteFieldWorkCommandHandler : IRequestHandler<DeleteFieldWorkCommand, ResultViewModel>
    {
        private readonly IFieldWorkRepository _fieldWorkRepository;

        public DeleteFieldWorkCommandHandler(IFieldWorkRepository fieldWorkRepository)
        {
            _fieldWorkRepository = fieldWorkRepository;
        }

        public async Task<ResultViewModel> Handle(DeleteFieldWorkCommand request, CancellationToken cancellationToken)
        {
            var FieldWork = await _fieldWorkRepository.GetByIdAsync(request.Id);

            if (FieldWork is null)
            {
                return ResultViewModel.Error("Este campo de atuação não existe");
            }

            FieldWork.Delete();

            await _fieldWorkRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
