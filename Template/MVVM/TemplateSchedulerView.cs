#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using Library.Template.Forms;
using Library.Template.MVVM;
using Library.Interfaces;
using Library.Code;
#endregion

namespace Library.Template.MVVM
{
    public partial class TemplateSchedulerView : UserControl, IView
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

        private ISpace ownerSpace= null;
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

        private IList<IItem> items = null;
        public IList<IItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items=value;
                SetItems(items);
            }
        }

        private void SetItems(IList<IItem> items)
        {
            try
            {
                var events = GetEvents(items);
                scheduleBox.Events.Clear();
                foreach(ScheduleBoxEvent _event in events)
                    scheduleBox.Events.Add(_event);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IItem selectedItem = null;
        public IItem SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                ClearSelection(selectedItem);
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

        private Gizmox.WebGUI.Forms.Control control = null;
        public Gizmox.WebGUI.Forms.Control Control
        {
            get
            {
                control = (Control)this;
                return control;
            }
        }

        private string title = null;
        public string Title
        {
            get
            {
                title = infoTitle.Text;
                return title;
            }
            set
            {
                title = value;
                SetTitle(title);
            }
        }

        private void SetTitle(string title)
        {
            try
            {
                infoTitle.Text = (title != null ? title.ToUpper() : null);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private int take = 10;
        public int Take
        {
            get
            {
                return take;
            }
            set
            {
                take = value;
            }
        }

        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                SetCount(count);
            }
        }

        private void SetCount(int count)
        {
            try
            {
                editCount.Text = "Voci trovate in archivio (" + count.ToString() + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool adding = true;
        public bool Adding
        {
            get
            {
                return adding;
            }
            set
            {
                adding = value;
                SetAdding(adding);
            }
        }

        public TemplateSchedulerView()
        {
            InitializeComponent();
            try
            {
                Init();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public virtual string TitleSpace { get; set; }

        private int skip = 0;

        private void TemplateSchedulerView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItems();
                SetLayout();                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetAdding(bool adding)
        {
            try
            {
                btnAdd.Enabled = adding;
                btnAdd.Visible = adding;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void LoadItems()
        {
            try
            {
                string search = txtSearch.Text;
                viewModel.Load(skip, take, search);
                this.Count = viewModel.GetCount(search);
                this.Items = viewModel.Items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public IList<ScheduleBoxEvent> GetEvents(IList<IItem> items)
        {
            try
            {
                if (items != null)
                {
                    var events = new List<ScheduleBoxEvent>();
                    foreach (ScheduleBoxEvent item in items)
                        events.Add(item);

                    return events;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }     

        public virtual void Init() { }

        private void SetLayout()
        {
            try
            {
                btnClose.Visible = (ownerSpace != null);
                if (txtSearch.CanFocus)
                    txtSearch.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
       
        public virtual void RefreshItems()
        {
            try
            {
                skip = 0;
                viewModel.Items.Clear();
                LoadItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void RemoveItem(IItem item)
        {
            try
            {
                bool removed = viewModel.Items.Remove(item);  //todo: revisione eliminazione ownerItem tramite ricerca per Id dell'Item
                if (removed)
                {
                    this.Count -= 1;
                    this.Items = viewModel.Items;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void AddSpace(IModel space)
        {
            try
            {
                space.OwnerSpace = this;
                space.Workspace = workspace;
                space.ViewModel = viewModel;
                if (ownerSpace != null)
                    space.TitleSpace = ownerSpace.TitleSpace;
                workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ClearSelection(IItem selectedItem)
        {
            try
            {
                foreach(var item in this.Items)
                {
                    if (item != selectedItem)
                        item.Selected = false;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (workspace != null)
                    workspace.CloseSpace(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void container_CanLoad()
        {
            try
            {
                skip += take;
                viewModel.Load(skip, take);
                this.Items = viewModel.Items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
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
        public void Open()
        {
            try
            {
                SetVisibility();
                if (Opened != null)
                    Opened();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetVisibility()
        {
            try
            {
                var parentOwner = UtilitySpace.GetParentOwner(this);
                btnHome.Visible = (parentOwner != null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void txtSearch_Search(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void txtSearch_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            try
            {
                var search=txtSearch.Text;
                if(search==null || search.Length==0)
                    RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void txtSearch_Clear(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                var rootSpace = UtilitySpace.GetRootSpace(this);
                if (rootSpace != null)
                {
                    this.ownerSpace = rootSpace;
                    if(workspace!=null)
                        workspace.CloseSpace(this);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}