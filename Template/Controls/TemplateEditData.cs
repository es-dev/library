#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Controls;
using Library.Code;

using Library.Interfaces;
#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditData : EditData, IEditControl, IEditValue<DateTime?>
    {
        public TemplateEditData()
            : base()
        {
            InitializeComponent();
        }
        
        public DateTime? _value = null;
        public new DateTime? Value
        {
            get
            {
                _value = base.Value;
                return _value;
            }
            set
            {
                _value = value;
                base.Value = (DateTime?)_value;
            }
        }

        private string label = null;
        public string Label
        {
            get
            {
                label = UtilityWeb.GetText(editLabel);
                return label;
            }
            set
            {
                label = value;
                UtilityWeb.SetText(editLabel, label);
                UtilityWeb.SetSiteName(this,label);
            }
        }

        private int labelWidth = 108;
        
        public int LabelWidth
        {
            get
            {
                return labelWidth;
            }
            set
            {
                labelWidth = value;
                SetLabelWidth(labelWidth);
            }
        }

        private bool readOnly = false;
        
        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }
            set
            {
                readOnly = value;
                SetReadOnly(readOnly);
            }
        }

        private bool required = false;
        
        public bool Required
        {
            get
            {
                return required;
            }
            set
            {
                required = value;
                bool verified = IsVerified();
                SetVerified(verified);
            }
        }

        public object oldValue = null;
        public bool editing = false;
        
        public bool Editing
        {
            get
            {
                return editing;
            }
            set
            {
                editing = value;
                SetEditing(editing);
                SetReadOnly(!editing && !readOnly);
            }
        }

        public bool changed = false;
        
        public bool Changed
        {
            get
            {
                changed = IsChanged();
                SetChanged(changed);
                return changed;
            }
            set
            {
                changed = value;
                SetChanged(changed);
            }
        }

        public bool verified = true;
        
        public bool Verified
        {
            get
            {
                verified = IsVerified();
                SetVerified(verified);
                return verified;
            }
        }

        private void TemplateEditData_Load(object sender, EventArgs e)
        {
            try
            {
                SetEditing(editing);
                SetReadOnly(!editing && !readOnly);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void SetVerified(bool verified)
        {
            try
            {
                if (imgEdit != null)
                    UtilityWeb.SetImage(editing, changed, verified, imgEdit);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void SetChanged(bool changed)
        {
            try
            {
                if (imgEdit != null)
                    UtilityWeb.SetImage(editing, changed, verified, imgEdit);

            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void SetReadOnly(bool readOnly)
        {
            try
            {
                if (editDay != null && editMonth != null && editYear != null)
                {
                    editDay.ReadOnly = readOnly;
                    editMonth.ReadOnly = readOnly;
                    editYear.ReadOnly = readOnly;
                    btnCalendar.Enabled = !readOnly;
                    InitJQ();
                    ExecuteJQ();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void SetEditing(bool editing)
        {
            try
            {
                if (editing)
                {
                    oldValue = _value;
                }
                else
                {
                    changed = IsChanged();
                    SetChanged(changed);

                    verified = IsVerified();
                    SetVerified(verified);
                }
                UtilityWeb.SetImage(editing, changed, verified, imgEdit);
                UtilityWeb.SetBackColor(editDay, editing);
                UtilityWeb.SetBackColor(editMonth, editing);
                UtilityWeb.SetBackColor(editYear, editing);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsVerified()
        {
            try
            {
                if (editDay != null && editMonth != null && editYear != null)
                {
                    string day = ValueString.Day;
                    string month = ValueString.Month;
                    string year = ValueString.Year;
                    bool compiled = (day != null && day.Length > 0) || (month != null && month.Length > 0) || (year != null && year.Length > 0);
                    bool isDate = UtilityValidation.IsDate(day, month, year);
                    bool verified = (required && compiled && isDate) || (!required && (!compiled || (compiled && isDate)));
                    return verified;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private bool IsChanged()
        {
            try
            {
                if (editDay != null && editMonth != null && editYear != null)
                {
                    string day = ValueString.Day;
                    string month = ValueString.Month;
                    string year = ValueString.Year;
                    string oldDay = "";
                    string oldMonth = "";
                    string oldYear = "";
                    if (oldValue != null)
                    {

                        oldDay = ((DateTime)oldValue).Day.ToString("00");
                        oldMonth = ((DateTime)oldValue).Month.ToString("00");
                        oldYear = ((DateTime)oldValue).Year.ToString("00");
                    }
                    bool changed = (day != oldDay) || (month != oldMonth) || (year != oldYear);
                    return changed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private void SetLabelWidth(int labelWidth)
        {
            try
            {
                if (panelDate != null && imgEdit != null)
                {
                    editLabel.Width = labelWidth;
                    panelDate.Left = editLabel.Left + editLabel.Width;
                    panelDate.Width = this.Width - labelWidth - imgEdit.Width;
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void TemplateEditData_Leave(object sender, EventArgs e)
        {
            try
            {
                if (editing)
                {
                    bool changed = IsChanged();
                    SetChanged(changed);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}