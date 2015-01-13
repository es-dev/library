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
using System.Linq;

#endregion

namespace Library.Controls
{
    public partial class EditControl : UserControl, IEditControl
    {
        private IMaskControl maskControl = null;
        public IMaskControl MaskControl
        {
            set
            {
                maskControl = value;
                SetMaskControlEvents(maskControl);
            }
        }

        private string label = null;
        public string Label
        {
            get
            {
                label = GetLabel();
                return label;
            }
            set
            {
                label = value;
                SetLabel(label);
            }
        }

        private string GetLabel()
        {
            try
            {
                var label = editLabel.Text;
                return label;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetLabel(string label)
        {
            try
            {
                editLabel.Text = label;
                UtilityWeb.SetSiteName(this, label);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private int labelWidth = 100;
        public virtual int LabelWidth
        {
            get
            {
                return labelWidth;
            }
            set
            {
                labelWidth = value;
                SetLayoutControls();
            }
        }

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
            }
        }

        public void SetEditing(bool editing)
        {
            try
            {
                if (editing)
                    oldText = maskControl.Text;
                verified = GetVerified();
                changed = GetChanged();
                SetReadOnly(!editing || readOnly);
                SetRequired(verified);
                SetImage(editing, changed, verified, imgEdit);
                SetBackColor(maskControl, editing);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool verified = true;
        public bool Verified
        {
            get
            {
                verified = GetVerified();
                return verified;
            }
        }

        private bool GetVerified()
        {
            try
            {
                if (maskControl != null)
                {
                    string text = maskControl.Text;
                    bool compiled = (text != null && text.Length > 0);
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
                SetRequired(required);
            }
        }

        private void SetRequired(bool verified)
        {
            try
            {
                if (imgEdit != null)
                {
                    changed = GetChanged();
                    SetImage(editing, changed, verified, imgEdit);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
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
                changed = GetChanged();
                return changed;
            }
            set
            {
                changed = value;
                SetChanged(changed);
            }
        }

        private void SetChanged(bool changed)
        {
            try
            {
                if (imgEdit != null)
                {
                    verified = GetVerified();
                    SetImage(editing, changed, verified, imgEdit);
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private string oldText = "";

        private bool GetChanged()
        {
            try
            {
                if (maskControl != null)
                {
                    string text = maskControl.Text;
                    bool changed = (text != oldText);
                    return changed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }


        public EditControl()
        {
            InitializeComponent();
        }

        private void EditControl_Load(object sender, EventArgs e)
        {
            try
            {
                SetLayoutControls();
                SetEditing(editing);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetBackColor(IMaskControl editValue, bool editing)
        {
            try
            {
                if (editValue != null)
                    editValue.BackColor = (editing ? Color.WhiteSmoke : Color.Transparent);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetImage(bool editing, bool changed, bool verified, PictureBox imgEdit)
        {
            try
            {
                imgEdit.Visible = false;
                if (editing)
                {
                    if (verified)
                    {
                        if (changed)
                        {
                            imgEdit.Image = "Images.edit_lightblue.png";
                            imgEdit.Visible = true;
                        }
                        else
                            imgEdit.Image = "";
                    }
                    else
                    {
                        imgEdit.Image = "Images.edit_red.png";
                        imgEdit.Visible = true;
                    }
                }
                else
                    imgEdit.Image = "";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void SetLayoutControls()
        {
            try
            {
                if (maskControl != null && editLabel != null && imgEdit!=null)
                {
                    imgEdit.Left = this.Width - imgEdit.Width;
                    editLabel.Width = labelWidth;
                    maskControl.Left = editLabel.Left + editLabel.Width;
                    maskControl.Width = this.Width - labelWidth - imgEdit.Width;
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
                if (maskControl!=null)
                {
                    maskControl.ReadOnly= readOnly;
                    SetReadOnlyColor(maskControl, readOnly);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetReadOnlyColor(IMaskControl control, bool readOnly)
        {
            try
            {
                if (readOnly)
                {
                    var editTextControls = (from q in control.Controls.OfType<Gizmox.WebGUI.Forms.TextBox>()  select q).ToList();
                    foreach (var editText in editTextControls)
                    {
                        var jquery = new UtilityJQuery();
                        var jqscript = jquery.GetReadOnly(editText);
                        if (jqscript != null && jqscript.Length > 0)
                            InvokeScript(jqscript);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void SetMaskControlEvents(IMaskControl maskControl)
        {
            try
            {
                if (maskControl != null)
                {
                    maskControl.Leave -= maskControl_Leave;
                    maskControl.Leave += maskControl_Leave;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
       
        private void maskControl_Leave(object sender, EventArgs e)
        {
            try
            {
                if (editing)
                {
                    changed = GetChanged();
                    SetChanged(changed);
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void EditControl_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                SetLayoutControls();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }


        private object _value = null;
        public object Value
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

        private void SetValue(object _value)
        {
            try
            {
                maskControl.Value = _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private object GetValue()
        {
            try
            {
                var _value = maskControl.Value;
                return _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}