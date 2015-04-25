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
	public partial class TemplateItem : Library.Template.MVVM.TemplateItem
	{
        public TemplateItem()
        {
            InitializeComponent();
        }

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (DashboardDto)model;
                    infoTitle.Text = obj.Title;
                    infoCodice.Text = obj.SubTitle;
                    infoDescription.Text = obj.Description;
                    var image= obj.Image;
                    infoImage.Image = (image==null? "" : image);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (DashboardDto)model;
                    obj.Title = infoTitle.Text;
                    obj.SubTitle = infoCodice.Text;
                    obj.Description = infoDescription.Text;
                    var image = infoImage.Image;
                    obj.Image = (image == null ? "" : image.File);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (DashboardDto)item.Model;
                    if (obj != null)
                    {
                        var type = obj.TypeSpace;
                        if (type != null)
                        {
                            var space = (ISpace)Activator.CreateInstance(type);
                            space.Title = obj.Title;
                            AddSpace(space);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
