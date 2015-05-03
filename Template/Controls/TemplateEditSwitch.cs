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
using Library.Interfaces;
using Library.Code;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Controls;
using System.Collections;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditSwitch : EditControl, IGroupControl
    {
        public TemplateEditSwitch()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string group = "OptionGroup1";
        public string Group
        {
            get
            {
                group = editControl.Group;
                return group;
            }
            set
            {
                group = value;
                editControl.Group = group;
            }
        }

        private bool _value = false;
        public new bool Value
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

        private void SetValue(bool value)
        {
            try
            {
                editControl.Value = value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool GetValue()
        {
            try
            {
                var value = (bool)editControl.Value;
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private string text = null;
        public new string Text
        {
            get
            {
                var text = editControl.Text;
                return text;
            }
            set
            {
                text = value;
                editControl.Text = text;
            }
        }

    }
}