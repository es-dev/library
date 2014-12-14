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
using Library.Controls;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditCheckBox : EditControl
    {

        private string textTrue = "SI";
        public string TextTrue
        {
            get
            {
                textTrue = editControl.TextTrue;
                return textTrue;
            }
            set
            {
                textTrue = value;
                editControl.TextTrue = textTrue;
            }
        }

        private string textFalse = "NO";
        public string TextFalse
        {
            get
            {
                textFalse = editControl.TextFalse;
                return textFalse;
            }
            set
            {
                textFalse = value;
                editControl.TextFalse = textFalse;
            }
        }

        public TemplateEditCheckBox()
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

        public new bool? Value
        {
            get
            {
                return (bool?)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }
    }
}