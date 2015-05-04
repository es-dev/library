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

namespace Library.Template.Scheduler
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
                SetBoldDates(items);
            }
        }

        private void SetItems(IList<IItem> items)
        {
            try
            {
                if (items != null)
                {
                    scheduleBox.Events.Clear();
                    CheckEventTime(items);
                    foreach (ScheduleBoxEvent item in items) 
                        scheduleBox.Events.Add(item);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckEventTime(IList<IItem> items) //effettua un'assegnazione automatica del TimeOfDay per le date prive di ore, minuti, secondi
        {
            try
            {
                if (items != null)
                {
                    var date = (from TemplateItem q in items where q.Start.TimeOfDay == TimeSpan.Zero select q.Start).Distinct().ToList();
                    foreach(var data in date)
                    {
                        var start = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
                        var end = new DateTime(data.Year, data.Month, data.Day, 23, 59, 59);
                        var itemsOfDay = (from TemplateItem q in items where start<=q.Start && q.Start<=end select q).ToList();
                        var hour = scheduleBox.WorkStartHour;
                        var minute = 0;
                        for (int i = 0; i < itemsOfDay.Count; i += 1)
                        {
                            var itemOfDay = itemsOfDay[i];
                            var dataOfDay = itemOfDay.Start;
                            itemOfDay.Start = dataOfDay.AddHours(hour).AddMinutes(minute);
                            itemOfDay.End = itemOfDay.Start.AddHours(1);
                            hour += 2;
                            if (hour > scheduleBox.WorkEndHour)
                            {
                                hour = scheduleBox.WorkStartHour;
                                minute += 30;
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

        private void TemplateSchedulerView_Load(object sender, EventArgs e)
        {
            try
            {
                SetDefault();
                LoadItems();
                SetLayout();                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetDefault()
        {
            try
            {
                var date = DateTime.Today;
                dtDate.CalendarFirstDayOfWeek = Day.Monday;
                dtDate.Value = date;
                monthCalendar.FirstDayOfWeek = Day.Monday;
                monthCalendar.Value = date;
                scheduleBox.HourFormat = ScheduleBoxHourFormat.Clock24H;
                scheduleBox.View = ScheduleBoxView.FullWeek;
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
                var advancedSearch = QueryAdvancedSearch();
                string search = txtSearch.Text;

                var firstDate = scheduleBox.FirstDate;
                var start = new DateTime(firstDate.Year,firstDate.Month,1); //start all'inizio del mese
                var lastDate = GetLastDate(firstDate);
                var year = lastDate.Year;
                var month = lastDate.Month;
                var end = new DateTime(year, month, DateTime.DaysInMonth(year,month)); //end alla fine del mese

                if (highDate<lowDate)
                {
                    viewModel.Fill(start, end, search, advancedSearch);
                    lowDate = start.AddDays(-1);
                    highDate = end.AddDays(1);
                }
                else
                {
                    if (start < lowDate)
                    {
                        viewModel.Fill(start, lowDate, search, advancedSearch);
                        lowDate = start.AddDays(-1);
                    }
                    if(end>highDate)
                    {
                        viewModel.Fill(highDate, end, search, advancedSearch);
                        highDate = end.AddDays(1);
                    }
                }
                this.Count = viewModel.Count(search, advancedSearch);
                this.Items = viewModel.Items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private DateTime GetLastDate(DateTime firstDate)
        {
            try
            {
                int days = GetScheduleDays(firstDate);
                var lastDate = firstDate.AddDays(days);
                return lastDate;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private int GetScheduleDays(DateTime firstDate)
        {
            try
            {
                int days = 0;
                var view = scheduleBox.View;
                if (view == ScheduleBoxView.Day)
                    days = 1;
                else if (view == ScheduleBoxView.FullWeek || view == ScheduleBoxView.Week)
                    days = 7;
                else if (view == ScheduleBoxView.FullMonth || view == ScheduleBoxView.Month)
                {
                    var year = firstDate.Year;
                    var month = firstDate.Month;
                    days = DateTime.DaysInMonth(year, month);
                }
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

                var advancedSearchConotrols = GetAdvancedSearchControls();
                bool enableAdvancedSearch = (advancedSearchConotrols.Count >= 1);

                btnOrderBy.Enabled = false; //ordinamento disabilitato per l'agenda
                btnAdvancedSearch.Enabled = enableAdvancedSearch;
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
        public void Open(bool backclosing = false)
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

        private TemplateItem GetItem(ScheduleBoxEvent _event)
        {
            try
            {
                var item = (from q in items where q == _event select q).FirstOrDefault();
                return (TemplateItem)item;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void btnShowCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                monthCalendar.Value = dtDate.Value;
                UtilityWeb.AddJQControl(btnShowCalendar, panelCalendar, JQTypePosition.Docked);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetBoldDates(IList<IItem> items)
        {
            try
            {
                if(items!=null)
                {
                    var boldDates = (from TemplateItem q in items select q.Start).ToArray();
                    monthCalendar.BoldedDates = boldDates;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void panelCalendar_Leave(object sender, EventArgs e)
        {
            try
            {
                panelCalendar.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                dtDate.Value = monthCalendar.Value;
                UtilityWeb.RemoveJQControl(panelCalendar);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnTodayCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                monthCalendar.Value = DateTime.Today;
                dtDate.Value = monthCalendar.Value;
                UtilityWeb.RemoveJQControl(panelCalendar);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                var firstDate = scheduleBox.FirstDate;
                var days = GetScheduleDays(firstDate);
                var date = firstDate.AddDays(-days);
                dtDate.Value = date;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var firstDate = scheduleBox.FirstDate;
                var days = GetScheduleDays(firstDate);
                var date = firstDate.AddDays(days);
                dtDate.Value = date;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual bool QueryAdvancedSearch(object model) { return true; }

        public virtual object QueryOrderBy(object model) { return null; }

        public object QueryAdvancedSearch() { return null; }

        public OrderBy QueryOrderBy() { return null; }

        private void btnCancelCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                UtilityWeb.RemoveJQControl(panelCalendar);

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
                SetAdvancedSearch();
                UtilityWeb.RemoveJQControl(panelAdvancedSearch);
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
                UtilityWeb.ClearEditControls(controls);
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
                UtilityWeb.RemoveJQControl(panelAdvancedSearch);
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
                SetAdvancedSearch();
                RefreshItems();
                UtilityWeb.RemoveJQControl(panelAdvancedSearch);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetAdvancedSearch()
        {
            try
            {
                var controls = GetAdvancedSearchControls();
                var performed = ((from IEditControl q in controls where q.Value != null select q).Count() >= 1);
                btnAdvancedSearch.TextButton = (performed ? "Filtri impostati..." : "Ricerca avanzata...");
                btnAdvancedSearch.ForeColorButton = (performed ? Color.Red : btnAdvancedSearch.OriginalForeColor);
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

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UtilityWeb.AddJQControl(btnAdvancedSearch, panelAdvancedSearch, JQTypePosition.Docked);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
       
    }
}