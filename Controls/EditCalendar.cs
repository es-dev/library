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
    public partial class EditCalendar : UserControl
    {
        private Control owner = null;
        public EditCalendar(Control owner)
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

        public delegate void CloseMonthCalendarHanlder(DateTime? value);

        
        public event CloseMonthCalendarHanlder Confirm;
        
        public event CloseMonthCalendarHanlder Cancel;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Confirm != null)
                    Confirm(monthCalendar.Value);

                owner.Controls.Remove(this);
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
                if (Cancel != null)
                    Cancel(null);

                owner.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}