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
using Library.Controls;
using Library.Code.Enum;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditLink : EditControl
    {

        public TemplateEditLink()
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

        private string _value = null; 
        public new string Value
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
        
        private void SetValue(string value)
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

        private string GetValue()
        {
            try
            {
                string value = (string)editControl.Value;
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string url = null;
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                SetUrl(url);
            }
        }

        private void SetUrl(string url)
        {
            try
            {
                editControl.Url = url;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetTypeReport(string url)
        {
            throw new NotImplementedException();
        }


    }
}