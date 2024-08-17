using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetAllFieldWork
{
    public class GetAllFieldWorkQueryHandler : IRequestHandler<GetAllFieldWorkQuery, ResultViewModel<List<FieldWorkViewModel>>>
    {
        private readonly IFieldWorkRepository _fieldWorkRepository;

        public GetAllFieldWorkQueryHandler(IFieldWorkRepository fieldWorkRepository)
        {
            _fieldWorkRepository = fieldWorkRepository;
        }

        public async Task<ResultViewModel<List<FieldWorkViewModel>>> Handle(GetAllFieldWorkQuery request, CancellationToken cancellationToken)
        {
            var fieldworks = await _fieldWorkRepository.GetAllAsync();
            //var users = _dbcontext.Users.Where(u => u.IsActive.Equals(true));
            var fieldViewModel = fieldworks.Select(b => new FieldWorkViewModel(b.Title
                 ,b.Description))
                 .ToList();

            return ResultViewModel<List<FieldWorkViewModel>>.Success(fieldViewModel);
        }
    }
}
