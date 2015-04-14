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

#endregion

namespace Library.Template.MVVM
{
    public partial class TemplateSchedulerItem : ScheduleBoxEvent, IItem
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
                control = null;
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

        private bool selected = false;
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

        public TemplateSchedulerItem()
        {
            InitializeComponent();
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        public virtual void BindView(object model) { }

        public virtual void BindModel(object model) { }

        private void AddSpace(IModel space, object obj=null, IViewModel _viewModel=null)
        {
            try
            {
                space.Model = (obj!=null? obj: model);
                space.OwnerItem = this;
                space.OwnerSpace = ownerSpace;
                space.Workspace = workspace;
                space.ViewModel = (_viewModel!=null? _viewModel: viewModel);
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

        public void AddSpace(ISpace space, object obj = null, IViewModel _viewModel = null)
        {
            try
            {
                if (space is IView)
                    AddSpace((IView)space);
                else if (space is IModel)
                    AddSpace((IModel)space, obj, _viewModel);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void OnItemClick(object sender, EventArgs e) 
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
                this.BackgroundColor = Color.RoyalBlue;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public event CloseHandler Closed;
        public void Close()
        {
            try
            {
                if (Closed != null)
                    Closed();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public event OpenHandler Opened;
        public void Open(bool backclosing = false)
        {
            try
            {
                if (Opened != null)
                    Opened();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}