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


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditNumeric : EditControl
    {

        public TemplateEditNumeric()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
                editControl.Behavior = Library.Controls.TextBox.TypeBehavior.Numeric;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private int? _value = null;
        public new int? Value
        {
            get
            {
                return (int?)editControl.Value; ;
            }
            set
            {
                editControl.Value = value;
            }
        }


    }
}