using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.DeleteContactCommand
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, ResultViewModel>
    {
        private readonly IContactRepository _contactRepository;

        public DeleteContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ResultViewModel> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);
            if (contact is null)
            {
                return ResultViewModel.Error("Este Contato não existe");
            }
            contact.Delete();

            await _contactRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
