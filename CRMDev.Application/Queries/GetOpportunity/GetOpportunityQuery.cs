using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetOpportunity
{
    public class GetOpportunityQuery:IRequest<ResultViewModel<OpportunityViewModel>>
    {
        public GetOpportunityQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
