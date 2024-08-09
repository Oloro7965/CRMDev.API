using CRMDev.Core.Domain.Entities;
using CRMDev.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.CreateFieldWorkCommand
{
    public class CreateFieldWorkCommandHandler : IRequestHandler<CreateFieldWorkCommand, Guid>
    {
        private readonly IFieldWorkRepository _fieldWorkRepository;

        public CreateFieldWorkCommandHandler(IFieldWorkRepository fieldWorkRepository)
        {
            _fieldWorkRepository = fieldWorkRepository;
        }

        public async Task<Guid> Handle(CreateFieldWorkCommand request, CancellationToken cancellationToken)
        {
            var WorkField = new FieldWork(request.Title, request.Description);

            await _fieldWorkRepository.AddAsync(WorkField);

            return WorkField.Id;
        }
    }
}
