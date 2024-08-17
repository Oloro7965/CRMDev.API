using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetAllContacts
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQuery, ResultViewModel<List<ContactViewModel>>>
    {
        private readonly IContactRepository _contactRepository;

        public GetAllContactsQueryHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ResultViewModel<List<ContactViewModel>>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _contactRepository.GetAllAsync();
            //var users = _dbcontext.Users.Where(u => u.IsActive.Equals(true));
            var contactViewModel = contacts.Select(b => new ContactViewModel(b.Name
                 , b.Email,b.PhoneNumber,b.Occupation,b.Notes))
                 .ToList();

            return ResultViewModel<List<ContactViewModel>>.Success(contactViewModel);
        }
    }
}
