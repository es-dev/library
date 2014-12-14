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
    public partial class TemplateEditData : EditControl
    {
        public TemplateEditData()
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

        public new DateTime? Value
        {
            get
            {
                return (DateTime?)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }
    }
}