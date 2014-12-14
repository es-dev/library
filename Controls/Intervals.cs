#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;

#endregion

namespace Library.Controls
{
    public partial class Intervals : UserControl
    {
        private TimeSpan interval = new TimeSpan(0, 15, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
            set
            {
                interval = value;
            }
        }

        private TimeSpan startInterval = new TimeSpan(7, 00, 00);
        public TimeSpan StartInterval
        {
            get
            {
                return startInterval;
            }
            set
            {
                startInterval = value;
            }
        }

        private TimeSpan endInterval = new TimeSpan(21, 00, 00);
        public TimeSpan EndInterval
        {
            get
            {
                return endInterval;
            }
            set
            {
                endInterval = value;
            }
        }

        private Control owner = null;

        public Intervals(Control owner)
        {
            InitializeComponent();
            try
            {
                this.owner = owner;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void Intervals_Load(object sender, EventArgs e)
        {
            try
            {
                btnConfirm.Enabled = false;
                for (var time = startInterval; time <= endInterval; time = time.Add(interval))
                {
                    var item = new ListViewItem();
                    var hours = time.Hours;
                    var minutes = time.Minutes;
                    var text = hours.ToString("00") + ":" + minutes.ToString("00");
                    item.Tag = time;
                    item.SubItems.Add(text);
                    listIntervals.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ConfirmlHanlder(TimeSpan? value);
        public event ConfirmlHanlder Confirm;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = listIntervals.SelectedItem;
                if (selectedItem != null)
                {
                    var interval = (TimeSpan)selectedItem.Tag;
                    if (Confirm != null)
                        Confirm(interval);

                    UtilityWeb.RemoveJQControl(this);
                    if (owner.CanFocus)
                        owner.Focus();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                UtilityWeb.RemoveJQControl(this);
                if (owner.CanFocus)
                    owner.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void listIntervals_ItemCheck(object objSender, ItemCheckEventArgs objArgs)
        {
            try
            {
                UtilityWeb.SetCheckItems(listIntervals, objArgs);
                btnConfirm.Enabled = (listIntervals.SelectedItem != null);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       

    }
}