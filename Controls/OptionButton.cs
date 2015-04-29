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
    public partial class OptionButton : UserControl, IMaskControl
    {
        private string group = "Option1";
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
                imgOption.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
                lblOption.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
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
                var readOnly = !imgOption.Enabled;
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
                imgOption.BackColor = backColor;
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
                lblOption.Text = text;
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
                var text = lblOption.Text;
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
                if (imgOption != null)
                    _value = (bool?)imgOption.Tag;
                
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
                }
                else
                    SetTrueFalse(false);
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        public OptionButton()
        {
            InitializeComponent();
        }
       
        private void SetTrueFalse(bool value)
        {
            try
            {
                imgOption.Image = (value ? "Images.on.png" : "Images.off.png");
                imgOption.Tag = value;

                if (value)
                {
                    var container = this.Parent.Parent;
                    if (container != null)
                    {
                        var optionControls = (from Control q in container.Controls where q is TemplateEditOption && q != this.Parent select q).ToList();
                        if (optionControls != null)
                        {
                            var _group = group;
                            var optionGroups = (from TemplateEditOption q in optionControls where q.Group == _group select q).ToList();
                            if (optionGroups != null)
                            {
                                foreach (var optionGroup in optionGroups)
                                    optionGroup.Value = false;
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

        private void imgOption_Click(object sender, EventArgs e)
        {
            try
            {
                if (!readOnly)
                {
                    var value = (bool?)imgOption.Tag;
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