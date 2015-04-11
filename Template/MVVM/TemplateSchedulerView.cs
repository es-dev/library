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
                if (items != null)
                {
                    scheduleBox.Events.Clear();
                    foreach (ScheduleBoxEvent item in items) //todo: prevedere posizionamento automatico per orario assente
                        scheduleBox.Events.Add(item);
                }
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

        private void TemplateSchedulerView_Load(object sender, EventArgs e)
        {
            try
            {
                SetDefaultValue();
                LoadItems();
                SetLayout();                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetDefaultValue()
        {
            try
            {
                var date = DateTime.Today;
                dtDate.Value = date;                
                scheduleBox.View = ScheduleBoxView.Week;
                scheduleBox.FirstDate = date;
                scheduleBox.WorkStartHour = 8;
                scheduleBox.WorkEndHour = 18;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private DateTime lowDate = DateTime.MaxValue;
        private DateTime highDate = DateTime.MinValue;

        public void LoadItems()
        {
            try
            {
                string search = txtSearch.Text;
                var start = scheduleBox.FirstDate;
                var end = GetEnd(start);
                if (highDate<lowDate)
                {
                    viewModel.Fill(start, end, search);
                    lowDate = start.AddDays(-1);
                    highDate = end.AddDays(1);
                }
                else
                {
                    if (start < lowDate)
                    {
                        viewModel.Fill(start, lowDate, search);
                        lowDate = start.AddDays(-1);
                    }
                    if(end>highDate)
                    {
                        viewModel.Fill(highDate, end, search);
                        highDate = end.AddDays(1);
                    }
                }
                this.Count = viewModel.GetCount(search);
                this.Items = viewModel.Items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private DateTime GetEnd(DateTime start)
        {
            try
            {
                int days = GetScheduleDays();
                var end = start.AddDays(days);
                return end;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private int GetScheduleDays()
        {
            try
            {
                int days = 0;
                var view = scheduleBox.View;
                if (view == ScheduleBoxView.Day)
                    days = 1;
                else if (view == ScheduleBoxView.FullMonth || view == ScheduleBoxView.Month)
                    days = 30;
                else if (view == ScheduleBoxView.FullWeek || view == ScheduleBoxView.Week)
                    days = 7;
                return days;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public virtual void Init() { }

        private void SetLayout()
        {
            try
            {
                adding = false;
                SetAdding(adding);
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
                lowDate = DateTime.MaxValue;
                highDate = DateTime.MinValue;
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

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var date = dtDate.Value;
                scheduleBox.FirstDate = date;
                LoadItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            try
            {
                scheduleBox.View = ScheduleBoxView.Day;
                LoadItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            try
            {
                scheduleBox.View = ScheduleBoxView.FullWeek;
                LoadItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            try
            {
                scheduleBox.View = ScheduleBoxView.Month;
                LoadItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void scheduleBox_EventClick(object sender, ScheduleBox.ScheduleBoxEventArgs e)
        {
            try
            {
                var item = GetItem(e.Event);
                if (item != null)
                    item.OnItemClick(sender, e);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private TemplateSchedulerItem GetItem(ScheduleBoxEvent _event)
        {
            try
            {
                var item = (from q in items where q == _event select q).FirstOrDefault();
                return (TemplateSchedulerItem)item;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

      
    }
}