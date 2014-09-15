#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using Library.Interfaces;
using Library.Code;
using Library.Controls;
using Library.Template.Controls;

#endregion

namespace Library.Template.MVVM
{
    public partial class TemplateItem : UserControl, IItem
    {
        private IWorkspace workspace = null;
        public IWorkspace Workspace
        {
            get
            {
                return workspace;
            }
            set
            {
                workspace = value;
            }
        }

        private IViewModel viewModel = null;
        public IViewModel ViewModel
        {
            get
            {
                return viewModel;
            }
            set
            {
                viewModel = value;
            }
        }

        private ISpace ownerSpace = null;
        public ISpace OwnerSpace
        {
            get
            {
                return ownerSpace;
            }
            set
            {
                ownerSpace = value;
            }
        }

        private Gizmox.WebGUI.Forms.Control control = null;
        public Gizmox.WebGUI.Forms.Control Control
        {
            get
            {
                control = (Control)this;
                return control;
            }
        }

        private object model = null;
        public object Model
        {
            get
            {
                BindModel(model);
                return model;
            }
            set
            {
                model = value;
                BindView(model);
            }
        }

        private bool selected= false;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                SetSelected(selected);
            }
        }
       
        public virtual string Title { get; set; }

        public virtual string TitleSpace { get; set; }


        public delegate void ItemClickHandler(IItem item);
        public event ItemClickHandler ItemClick;

        public TemplateItem()
        {
            InitializeComponent();           
        }

        private void TemplateItem_Load(object sender, EventArgs e)
        {
            try
            {
                RegisterItemClickEvent(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public virtual void BindView(object model) { }

        public virtual void BindModel(object model) { }

        private void RegisterItemClickEvent(Control control)
        {
            try
            {
                control.Cursor = Cursors.Hand;
                control.Click += new EventHandler(OnItemClick);
                if (control.HasChildren)
                {
                    foreach (Control child in control.Controls)
                        RegisterItemClickEvent(child);
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void AddSpace(IModel space)
        {
            try
            {
                space.Model = model;
                space.OwnerItem = this;
                space.OwnerSpace = ownerSpace;
                space.Workspace = workspace;
                space.ViewModel = viewModel;
                if(ownerSpace!=null)
                    space.TitleSpace = ownerSpace.TitleSpace;
                workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void AddSpace(IView space)
        {
            try
            {
                workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void AddSpace(ISpace space)
        {
            try
            {
                if (space is IView)
                    AddSpace((IView)space);
                else if (space is IModel)
                    AddSpace((IModel)space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void OnItemClick(object sender, EventArgs e)
        {
            try
            {
                var view=(IView)ownerSpace;
                if (view != null)
                {
                    var control = view.Control;
                    if (control != null)
                    {
                        var popup = UtilityWeb.GetPopup(control);
                        if(popup!=null)
                        { 
                            this.selected = !selected;
                            view.SelectedItem = this;
                            SetSelected(selected);
                        }
                        else
                        {
                            if (ItemClick != null)
                                ItemClick(this);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void SetSelected(bool selected)
        {
            try
            {
                this.BorderColor = (selected ? new BorderColor(Color.FromArgb(0,45,100)) : new BorderColor(Color.Transparent));
                this.BorderStyle = (selected ? BorderStyle.FixedSingle : BorderStyle.None);
                this.BorderWidth = (selected ? 2 : 0);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}