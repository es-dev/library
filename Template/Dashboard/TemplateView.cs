using Library.Code;
using Library.Interfaces;
using Library.Template.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Library.Template.Dashboard
{
	public partial class TemplateView : Library.Template.MVVM.TemplateView
	{
        public TemplateView()
		{
			InitializeComponent();
		}

        private void RefreshCount()
        {
            try
            {
                var items = Items;
                foreach (TemplateItem item in items)
                {
                    var model = (DashboardDto)item.Model;
                    var type = model.TypeSpace;
                    var space = (ISpace)Activator.CreateInstance(type);
                    if (space is IView)
                    {
                        var view = (IView)space;
                        var viewModel = space.ViewModel;
                        if (viewModel != null)
                        {
                            item.CountVisible = model.CountVisible;
                            if (item.CountVisible)
                            {
                                var advancedSearch = view.QueryAdvancedSearch();
                                item.Count = viewModel.Count(null, advancedSearch);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void RefreshItems()
        {
            try
            {
                base.RefreshItems();
                RefreshCount();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void TemplateView_Opened()
        {
            try
            {
                RefreshCount();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
