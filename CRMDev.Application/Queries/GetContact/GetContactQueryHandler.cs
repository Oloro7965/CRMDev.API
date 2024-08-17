using CRMDev.Application.Queries.GetOpportunity;
using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetContact
{
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, ResultViewModel<ContactViewModel>>
    {
        private readonly IContactRepository _contactRepository;

        public GetContactQueryHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ResultViewModel<ContactViewModel>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);

            if (contact is null)
            {
                return ResultViewModel<ContactViewModel>.Error("Este contato não existe");
            }

            var ContactDetailViewModel = new ContactViewModel(contact.Name
                 , contact.Email,contact.PhoneNumber, contact.Occupation,
                 contact.Notes);

            //var UserDetailViewModel = UserViewModel.FromEntity(user);
            return ResultViewModel<ContactViewModel>.Success(ContactDetailViewModel);
        }
    }
}
