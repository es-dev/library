using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Interfaces;
using System.Linq.Expressions;
using System.Collections;

namespace Library.Template.MVVM
{
    public class TemplateViewModel<TView, TItem, TModel, TDto> : IViewModel
    {
        private IList<IItem> items = null;
        public IList<IItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        public TemplateViewModel()
        {
            try
            {
                Init();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void Init() 
        {
            try
            {
                items = new List<IItem>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void Load(int skip, int take, string search = null, object advancedSearch=null) { }

        public virtual int Count(string search=null, object advancedSearch=null) { return 0; }

        public virtual bool Save(object model, bool creating) { return false; }

        public virtual bool Delete(object model) { return false; }

        public virtual object Read(object id) { return null; }

        public virtual void Fill(object start, object end, string search) {}

        public void Load(IEnumerable objs) 
        {
            try
            {
                if (objs != null)
                {
                    foreach (var obj in objs)
                    {
                        var item = (IItem)Activator.CreateInstance<TItem>();
                        item.ViewModel = this;
                        item.Model = obj;
                        
                        items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public void Update(object model, object newModel)
        {
            try
            {
                var pKeyName=UtilityPOCO.PrimaryKeyName;
                var pKeyValue = UtilityPOCO.GetValue(newModel, pKeyName);
                UtilityPOCO.SetValue(model, pKeyName, pKeyValue);

                var dtoKeyName = UtilityPOCO.DtoKeyName;
                var dtoKeyValue = UtilityPOCO.GetValue(newModel, dtoKeyName);
                UtilityPOCO.SetValue(model, dtoKeyName, dtoKeyValue);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public IView GetView()
        {
            try
            {
                var space = (IView)Activator.CreateInstance<TView>();
                space.ViewModel = this;
                return space;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IItem GetItem(object model)
        {
            try
            {
                var space = (IItem)Activator.CreateInstance<TItem>();
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

        public IModel GetModel(object model)
        {
            try
            {
                if (typeof(TModel) != typeof(Type))
                {
                    var space = (IModel)Activator.CreateInstance<TModel>();
                    space.ViewModel = this;
                    space.Model = model;
                    return space;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public object GetDto()
        {
            try
            {
                var obj = Activator.CreateInstance<TDto>();
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
