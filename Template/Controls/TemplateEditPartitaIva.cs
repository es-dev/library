#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;
using Library.Interfaces;

using Gizmox.WebGUI.Common.Interfaces;
using Library.Controls;
using Library.Code.Enum;

#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditPartitaIva : EditControl
    {

        public TemplateEditPartitaIva()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
                editControl.Behavior = TypeBehavior.PartitaIva;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public new string Value
        {
            get
            {
                return (string)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }

             
    }
}