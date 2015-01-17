using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Interfaces;

namespace Library.Template.MVVM
{
    public class TemplateViewModel<TEntity, TItem> : IViewModel
    {
        private ISpace space = null;
        public ISpace Space
        {
            get
            {
                return space;
            }
            set
            {
                space = value;
            }
        }

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

        //private int count = 0;
        //public int Count
        //{
        //    get
        //    {                
        //        count = GetCount();
        //        return count;
        //    }
        //}

        public TemplateViewModel(ISpace space)
        {
            try
            {
                this.space = space;
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

        public virtual void Load(int skip, int take, string search=null) {}

        public virtual int GetCount(string search=null) { return 0; }

        public virtual bool Save(object model, bool creating) { return false; }

        public virtual bool Delete(object model) { return false; }

        public virtual object Read(object id) { return null; }

        public void Load(IList<TEntity> objDtos)
        {
            try
            {
                if (objDtos != null)
                {
                    foreach (var objDto in objDtos)
                    {
                        var item = (IItem)Activator.CreateInstance<TItem>();
                        item.Model = objDto;
                        item.OwnerSpace = space;
                        if (space != null)
                        {
                            item.Workspace = space.Workspace;
                            item.ViewModel = space.ViewModel;
                        }
                        items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public void Load(IEnumerable<TEntity> objDtos)
        {
            try
            {
                Load(objDtos.ToList());
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

    }
}
