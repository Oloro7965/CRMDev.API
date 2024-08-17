using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class FieldWorkViewModel
    {
        public FieldWorkViewModel(string title, string description)
        {
            Title = title;

            Description = description;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

    }
}
