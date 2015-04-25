using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Template.Scheduler 
{
    public class TemplateViewModel<TView, TItem> : Library.Template.MVVM.TemplateViewTypeModel<TView, TItem, SchedulerDto>
    {
        public TemplateViewModel() : base()
        {

        }
    }
}
