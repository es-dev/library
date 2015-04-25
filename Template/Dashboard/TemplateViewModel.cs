using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Template.Dashboard;
using System.Collections;

namespace Library.Template.Dashboard
{
    public class TemplateViewModel<TView, TItem> : Library.Template.MVVM.TemplateViewTypeModel<TView, TItem, DashboardDto>
    {

        public TemplateViewModel()
            : base() 
        {

        }

        public override void Load(int skip, int take, string search=null)
        {
            try
            {
                var objs = LoadDashboards(skip, take);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search=null)
        {
            try
            {
                var query = QueryDashboards();
                int count = query.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        
        private IList<DashboardDto> LoadDashboards(int skip, int take)
        {
            try
            {
                var query = QueryDashboards();
                var objs = query.Skip(skip).Take(take).ToList();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public virtual IQueryable<DashboardDto> QueryDashboards() { return null; }
    }
}