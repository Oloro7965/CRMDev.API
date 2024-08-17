using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetContact
{
    public class GetContactQuery: IRequest<ResultViewModel<ContactViewModel>>
    {
        public GetContactQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
