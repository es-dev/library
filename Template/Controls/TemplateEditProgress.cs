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
    public partial class TemplateEditProgress : EditControl
    {

        public TemplateEditProgress()
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

        public new decimal? Value
        {
            get
            {
                return (decimal?)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }


    }
}