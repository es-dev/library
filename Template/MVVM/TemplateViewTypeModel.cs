using Library.Code;
using Library.Interfaces;
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

        public IModel GetModel<TModel>(object model)
        {
            try
            {
                var space = (IModel)Activator.CreateInstance<TModel>();
                space.ViewModel = this;
                space.Model = model;
                return space;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
