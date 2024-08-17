using CRMDev.Core.Domain.Entities;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateContactCommand
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Guid>
    {
        private readonly IContactRepository _contactRepository;

        public CreateContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<Guid> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = new Contact(request.Name, request.Email, request.PhoneNumber, request.Occupation, 
                request.Document, request.Address,request.FielWorkId);

            await _contactRepository.AddAsync(contact);

            return contact.Id;
        }
    }
}
