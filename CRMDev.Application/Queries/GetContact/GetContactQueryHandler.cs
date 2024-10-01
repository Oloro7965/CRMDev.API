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
        private readonly IFieldWorkRepository _workRepository;

        public GetContactQueryHandler(IContactRepository contactRepository, IFieldWorkRepository workRepository)
        {
            _contactRepository = contactRepository;
            _workRepository = workRepository;
        }

        public async Task<ResultViewModel<ContactViewModel>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);
            var fieldwork = await _workRepository.GetByIdAsync(contact.FielWorkId);
            if (contact is null)
            {
                return ResultViewModel<ContactViewModel>.Error("Este contato não existe");
            }

            var ContactDetailViewModel = new ContactViewModel(contact.Name
                 , contact.Email,contact.PhoneNumber, contact.Occupation,
                 contact.Notes,contact.FielWorkId,contact.FieldWork.Title);

            //var UserDetailViewModel = UserViewModel.FromEntity(user);
            return ResultViewModel<ContactViewModel>.Success(ContactDetailViewModel);
        }
    }
}
