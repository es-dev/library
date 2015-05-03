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
using Library.Interfaces;
using Library.Template.Controls;

#endregion

namespace Library.Controls
{
    public partial class SwitchButton : UserControl, IMaskControl, IGroupControl
    {
        private string group = "SwitchGroup1";
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        private bool readOnly = false;
        public bool ReadOnly
        {
            get
            {
                readOnly = GetReadOnly();
                return readOnly;
            }
            set
            {
                readOnly = value;
                SetReadOnly(readOnly);
            }
        }

        private void SetReadOnly(bool readOnly)
        {
            try
            {
                imgSwitch.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
                lblSwitch.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool GetReadOnly()
        {
            try
            {
                var readOnly = !imgSwitch.Enabled;
                return readOnly;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private Color backColor = Color.Transparent;
        public override Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                SetBackColor(backColor);
            }
        }

        private void SetBackColor(Color backColor)
        {
            try
            {
                base.BackColor = backColor;
                imgSwitch.BackColor = backColor;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string text = null;
        public override string Text
        {
            get
            {
                text = GetText();
                return text;
            }
            set
            {
                text = value;
                SetText(text);
            }
        }

        private void SetText(string text)
        {
            try
            {
                lblSwitch.Text = text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetText()
        {
            try
            {
                var text = lblSwitch.Text;
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                _value = (bool?)value;
                SetValue(_value);
            }
        }

        private object GetValue()
        {
            try
            {
                bool? _value = null;
                if (imgSwitch != null)
                    _value = (bool?)imgSwitch.Tag;
                
                return _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetValue(object _value)
        {
            try
            {
                if (_value != null)
                {
                    var value = (bool)_value;
                    SetTrueFalse(value);
                    if(value)
                        UtilityWeb.SetEditGroupControls(this, !value);
                }
                else
                    SetTrueFalse(false);
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        public SwitchButton()
        {
            InitializeComponent();
        }

        private void SetTrueFalse(bool value)
        {
            try
            {
                imgSwitch.Image = (value ? "Images.switch_on.png" : "Images.switch_off.png");
                imgSwitch.Tag = value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        
        private void imgSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!readOnly)
                {
                    var value = (bool?)imgSwitch.Tag;
                    if (value == true)
                        SetValue(null);
                    else
                        SetValue(true);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string mask = "";
        public string Mask
        {
            get
            {
                return mask;
            }
            set
            {
                mask = value;
            }
        }
    }
}