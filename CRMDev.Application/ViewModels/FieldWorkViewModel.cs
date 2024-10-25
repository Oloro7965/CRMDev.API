using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class FieldWorkViewModel
    {
        public FieldWorkViewModel(Guid id,string title, string description)
        {
            Id = id;
            Title = title;

            Description = description;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        public string Description { get; private set; }

    }
}
