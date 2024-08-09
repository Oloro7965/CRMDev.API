using CRMDev.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Entities
{
    public class Opportunity : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public decimal Costs { get; private set; }
        public string Scope { get; private set; }
        public string IncludedSupport { get; private set; }
        public EFailReason FailedReason { get; private set; }
        public EStatus Status { get; private set; }
        public EStage Stage { get; private set; }
        public Guid ContactId { get; private set; }
        public Contact contact { get; private set; }
        public bool IsDeleted { get; private set; }
        public Opportunity(string title,string description,DateTime dueDate,decimal costs,string scope,string support,Guid contactId)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Costs = costs;
            Scope = scope;
            IncludedSupport = support;
            ContactId = contactId;
            Status = EStatus.Pending;
            Stage = EStage.ContactMade;
            IsDeleted = false;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
        public void Update(string title,string description, DateTime dueDate, decimal costs, string scope, string support)
        {
            Title=title;
            Description=description;
            DueDate=dueDate;
            Costs = costs;
            Scope = scope; 
            IncludedSupport = support;
        }
    }
}
