using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetFieldWork
{
    public class GetFieldWorkQuery: IRequest<ResultViewModel<FieldWorkViewModel>>
    {
        public GetFieldWorkQuery(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
    }
}
