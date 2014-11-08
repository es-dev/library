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
using Gizmox.WebGUI.Common.Interfaces;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditNumeric : UserControl, IEditControl, IEditValue<int?>
    {
        const string mask = "---";
        private string JQScript = null;
        protected override void Render(IContext objContext, IResponseWriter objWriter, long lngRequestID)
        {
            try
            {
                base.Render(objContext, objWriter, lngRequestID);
                InitJQ();
                ExecuteJQ();
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
                JQScript = jquery.GetEditText(editValue,mask);
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
                UtilityWeb.SetText(editLabel,label);
                UtilityWeb.SetSiteName(this,label);
            }
        }

        
        private int labelWidth = 108;
        
        public virtual int LabelWidth
        {
            get
            {
                return labelWidth;
            }
            set
            {
                labelWidth = value;
                SetLabelWidth();
            }
        }

        private int? _value = null;
        public int? Value
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

        private void SetValue(int? value)
        {
            try
            {
                UtilityWeb.SetInteger(editValue, value, mask);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private int? GetValue()
        {
            try
            {
                var value = UtilityWeb.GetInteger(editValue, mask);
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private object oldValue = null;
        private bool editing = false;
        
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
                SetReadOnly(!editing || readOnly);
                bool verified = IsVerified(required);
                SetVerified(verified);
            }
        }

        private bool verified = true;
        
        public bool Verified
        {
            get
            {
                verified = IsVerified(required);
                SetVerified(verified);
                return verified;
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
                bool verified = IsVerified(required);
                SetVerified(verified);
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

        private bool changed = false;
        
        public bool Changed
        {
            get
            {
                return changed;
            }
            set
            {
                changed = value;
                SetChanged(changed);
            }
        }

        public TemplateEditNumeric()
        {
            InitializeComponent();
        }

        private void TemplateEditNumeric_Load(object sender, EventArgs e)
        {
            try
            {
                SetEditing(editing);
                SetReadOnly(!editing || readOnly);
                bool verified = IsVerified(required);
                SetVerified(verified);
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
                    oldValue = _value;
                UtilityWeb.SetImage(editing, changed, verified, imgEdit);
                UtilityWeb.SetBackColor(editValue,editing);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsVerified(bool required)
        {
            try
            {
                if (editValue != null)
                {
                    string value = UtilityWeb.GetText(editValue, mask);
                    bool compiled = (value != null && value.Length > 0);
                    bool verified = (required && compiled) || (!required && (!compiled || (compiled)));
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
                if (editValue != null)
                {
                    string value = UtilityWeb.GetText(editValue, mask);
                    bool changed = (value != (string)oldValue);
                    return changed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private void SetVerified(bool verified)
        {
            try
            {
               UtilityWeb.SetImage(editing, changed, verified,imgEdit); 
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetChanged(bool changed)
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

        public virtual void SetLabelWidth()
        {
            try
            {
                if (editValue != null && editLabel != null)
                {
                    editLabel.Width = labelWidth;
                    editValue.Left = editLabel.Left + editLabel.Width;
                    editValue.Width = this.Width - labelWidth - imgEdit.Width;
                }
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
                if (editValue!=null)
                {
                    editValue.ReadOnly = readOnly;
                    InitJQ();
                    ExecuteJQ();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetMultiline(bool multiline)
        {
            try
            {
                if (editValue != null)
                {
                    editValue.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    if (multiline)
                        editValue.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editValue_Leave(object sender, EventArgs e)
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
                Library.Code.UtilityError.Write(ex);
            }
        }

    }
}