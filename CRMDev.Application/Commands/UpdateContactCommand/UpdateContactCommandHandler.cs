using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateContactCommand
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, ResultViewModel>
    {
        private readonly IContactRepository _contactRepository;

        public UpdateContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ResultViewModel> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);
            if (contact is null)
            {
                return ResultViewModel.Error("Contato não existe");
            }
            contact.Update(request.Email, request.PhoneNumber, request.Occupation, request.Address);

            //_dbcontext.Update(user);  
            _contactRepository.SaveChangesAsync();

            return ResultViewModel.Success();
        }
    }
}
