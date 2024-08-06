using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Application.ViewModels
{
    public class NoteViewModel
    {
        public NoteViewModel(string content)
        {
            Content = content;
        }

        public string Content { get; private set; }
    }
}
