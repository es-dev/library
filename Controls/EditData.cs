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
using Library.Code;
using Gizmox.WebGUI.Common.Interfaces;

#endregion

namespace Library.Controls
{
    public partial class EditData : UserControl
    {
        const string mask = "--"; //todo: prevedere mask per anno
        private string JQScript = null;
        protected override void Render(IContext objContext, IResponseWriter objWriter, long lngRequestID)
        {
            try
            {
                InitJQ();
                ExecuteJQ();
                base.Render(objContext, objWriter, lngRequestID);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void InitJQ()
        {
            try
            {
                var jquery = new UtilityJQuery();
                JQScript = jquery.GetEditData(editDay, editMonth, editYear,mask);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void ExecuteJQ()
        {
            try
            {
                if (!DesignMode)
                {
                    if (JQScript != null && JQScript.Length > 0)
                        InvokeScript(JQScript);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private DateTime? _value = null;
        public DateTime? Value
        {
            get
            {
                _value = GetValue();
                return _value;
            }
            set
            {
                _value = value;
                SetValue(_value);
            }
        }

        private ValueDate valueString= null;
        public ValueDate ValueString
        {
            get
            {
                valueString = GetValueString();
                return valueString;
            }
        }
        
        public EditData()
        {
            InitializeComponent();
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private DateTime? GetValue()
        {
            try
            {
                if (editDay != null && editMonth != null && editYear != null)
                {
                    string day = ValueString.Day;
                    string month = ValueString.Month;
                    string year = ValueString.Year;
                    var value = UtilityValidation.GetDate(day, month, year);
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private ValueDate GetValueString()
        {
            try
            {
                string day = GetText(editDay, mask);
                string month = GetText(editMonth, mask);
                string year = GetText(editYear, mask);
                var valueString = new ValueDate(day, month, year);
                return valueString;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public class ValueDate
        {
            public string Day = null;
            public string Month = null;
            public string Year = null;

            public ValueDate(string day, string month, string year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }
        }

        private void SetValue(DateTime? value)
        {
            try
            {
                if (editDay != null && editMonth != null && editYear != null)
                {
                    if (value != null)
                    {
                        var date = (DateTime)value;
                        editDay.Text = date.Day.ToString("00");
                        editMonth.Text = date.Month.ToString("00");
                        editYear.Text = date.Year.ToString("00");
                    }
                    else
                    {
                        editDay.Text = mask;
                        editMonth.Text = mask;
                        editYear.Text = mask;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        static string GetText(Control control, string mask = null)
        {
            try
            {
                if (control != null)
                {
                    string text = control.Text;
                    if (mask != null)
                        text = text.Replace(mask, null);
                    return text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        EditCalendar calendar = null;
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                var parent = this.Parent;
                if (parent != null)
                {
                    calendar = new EditCalendar(parent);
                    calendar.Confirm += Calendar_Confirm;
                    calendar.Cancel += Calendar_Cancel;   
                    calendar.Top = this.Top + parent.Top+this.Height;
                    calendar.Left = this.Left + parent.Left;
                    calendar.BackColor = Color.White;
                    parent.Controls.Add(calendar);
                    calendar.BringToFront();
                    btnCalendar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        void Calendar_Confirm(DateTime? date)
        {
            try
            {
                SetValue(date);
                btnCalendar.Enabled = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void Calendar_Cancel(DateTime? date)
        {
            try
            {
                if(btnCalendar!=null)
                    btnCalendar.Enabled = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        void Calendar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime? date = (sender as MonthCalendar).Value;
                SetValue(date);
                var parent = this.Parent;
                if(parent!=null)
                {
                    parent.Controls.Remove(calendar);
                    calendar = null;
                    btnCalendar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        
    }
}