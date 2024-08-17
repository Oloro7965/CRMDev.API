using CRMDev.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetAllFieldWork
{
    public class GetAllFieldWorkQuery: IRequest<ResultViewModel<List<FieldWorkViewModel>>>
    {
    }
}
