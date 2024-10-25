using CRMDev.Application.Queries.GetContact;
using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Queries.GetFieldWork
{
    public class GetFieldWorkQueryHandler : IRequestHandler<GetFieldWorkQuery, ResultViewModel<FieldWorkViewModel>>
    {
        private readonly IFieldWorkRepository _fieldWorkRepository;

        public GetFieldWorkQueryHandler(IFieldWorkRepository fieldWorkRepository)
        {
            _fieldWorkRepository = fieldWorkRepository;
        }

        public async Task<ResultViewModel<FieldWorkViewModel>> Handle(GetFieldWorkQuery request, CancellationToken cancellationToken)
        {
            var fieldwork = await _fieldWorkRepository.GetByNameAsync(request.Title);
           
            if (fieldwork is null)
            {
                return ResultViewModel<FieldWorkViewModel>.Error("Este campo de atuação não existe");
            }

            var FieldWorkDetailViewModel = new FieldWorkViewModel(fieldwork.Id
                 ,fieldwork.Title,fieldwork.Description);

            //var UserDetailViewModel = UserViewModel.FromEntity(user);
            return ResultViewModel<FieldWorkViewModel>.Success(FieldWorkDetailViewModel);
        }
    }
}
