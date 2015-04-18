using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Template.Scheduler 
{
    public class TemplateViewModel<TDto, TItem> : Library.Template.MVVM.TemplateViewModel<TDto, TItem>
    {
        public TemplateViewModel(ISpace space) : base(space)
        {
        }
    }
}
