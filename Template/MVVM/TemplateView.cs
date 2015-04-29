#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using Library.Template.Forms;
using Library.Template.MVVM;
using Library.Interfaces;
using Library.Code;

#endregion

namespace Library.Template.MVVM
{
    public partial class TemplateView : UserControl, IView
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
                var pagingControls = GetPagingControls(items);
                container.PagingControls = pagingControls;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public IList<Control> GetPagingControls(IList<IItem> items)
        {
            try
            {
                if (items != null)
                {
                    var pagingControls = new List<Control>();
                    foreach (var item in items)
                    {
                        item.OwnerSpace = this;
                        item.Workspace = this.Workspace;
                        pagingControls.Add(item.Control);
                    }
                    return pagingControls;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                container.Count = count;
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

        public TemplateView()
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

        private void TemplateView_Load(object sender, EventArgs e)
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

        public void LoadItems()
        {
            try
            {
                string search = txtSearch.Text;
                var advancedSearch = QueryAdvancedSearch();
                var orderBy = QueryOrderBy();
                viewModel.Load(skip, take, search, advancedSearch, orderBy);
                this.Count = viewModel.Count(search, advancedSearch);
                this.Items = viewModel.Items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public object QueryAdvancedSearch()
        {
            try
            {
                var advancedSearch = (Func<object, bool>)(q => QueryAdvancedSearch(q));
                return advancedSearch;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public object QueryOrderBy()
        {
            try
            {
                var orderBy = (Func<object, object>)(q => QueryOrderBy(q));
                return orderBy;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public virtual bool QueryAdvancedSearch(object model) { return true; }

        public virtual object QueryOrderBy(object model) { return null; }

        public virtual void Init() { }

        private void SetLayout()
        {
            try
            {
                btnClose.Visible = (ownerSpace != null);
                if (txtSearch.CanFocus)
                    txtSearch.Focus();

                var advancedSearchConotrols = GetAdvancedSearchControls();
                var orderByConotrols = GetAdvancedSearchControls();
                bool enableAdvancedSearch = (advancedSearchConotrols.Count >= 1);
                bool enableOrderBy = (orderByConotrols.Count >= 1);

                btnOrderBy.Enabled = enableOrderBy;
                btnAdvancedSearch.Enabled = enableAdvancedSearch;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private IList<Control> GetAdvancedSearchControls()
        {
            try
            {
                var controls = (from Control q in panelAdvancedSearch.Controls where (string)q.Tag != "advancedSearch" select q).ToList();
                return controls;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IList<Control> GetorderByControls()
        {
            try
            {
                var controls = (from Control q in panelAdvancedSearch.Controls where (string)q.Tag != "orderBy" select q).ToList();
                return controls;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
        public void Open(bool backclosing = false)
        {
            try
            {
                if(backclosing)
                    RefreshItems();
                else
                {
                    if (Opened != null)
                        Opened();
                }

                SetVisibility();
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

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                panelOrderBy.Visible = false;
                panelAdvancedSearch.Visible = !panelAdvancedSearch.Visible;
                if (panelAdvancedSearch.Visible)
                    panelAdvancedSearch.BringToFront();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloselAdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                panelAdvancedSearch.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnConfirmAdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
                panelAdvancedSearch.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancelAdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAdvancedSearch();
                RefreshItems();
                panelAdvancedSearch.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void ClearAdvancedSearch() 
        {
            try
            {
                var controls = GetAdvancedSearchControls();
                ClearEditControls(controls); 
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void ClearEditControls(IList<Gizmox.WebGUI.Forms.Control> controls)
        {
            try
            {
                foreach (var control in controls)
                {
                    if (control is IEditControl)
                    {
                        var editControl = (IEditControl)control;
                        editControl.Value = null;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void AddNewModel()
        {
            try
            {
                var model = viewModel.GetDto();
                var space = viewModel.GetModel(model);
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                panelOrderBy.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnConfirmOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
                panelOrderBy.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancelOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                ClearOrderBy();
                RefreshItems();
                panelOrderBy.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void ClearOrderBy() 
        {
            try
            {
                var controls = GetorderByControls();
                ClearEditControls(controls);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                panelAdvancedSearch.Visible = false;
                panelOrderBy.Visible = !panelOrderBy.Visible;
                if (panelOrderBy.Visible)
                    panelOrderBy.BringToFront();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}