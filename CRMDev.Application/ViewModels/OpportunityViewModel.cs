using CRMDev.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class OpportunityViewModel
    {
        public OpportunityViewModel(string title, string description, DateTime dueDate, decimal costs, string scope, string includedSupport, EStatus status, EStage stage)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Costs = costs;
            Scope = scope;
            IncludedSupport = includedSupport;
            Status = status;
            Stage = stage;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public decimal Costs { get; private set; }
        public string Scope { get; private set; }
        public string IncludedSupport { get; private set; }
        public EStatus Status { get; private set; }
        public EStage Stage { get; private set; }
    }
}
