using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Template.MVVM
{
    public class TemplateViewTypeModel<TView, TItem, TDto> : TemplateViewModel<TView, TItem, Type, TDto>
    {
        public TemplateViewTypeModel()
            : base()
        {

        }
    }
}
