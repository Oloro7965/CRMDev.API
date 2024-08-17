using CRMDev.Application.ViewModels;
using CRMDev.Core.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.Commands.UpdateStageCommand
{
    public class UpdateStageCommand: IRequest<ResultViewModel>
    {
        public Guid Id { get; set; }
        public EStage ChangeToStatus { get; set; }
    }
}
