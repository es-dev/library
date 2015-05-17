#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Template.Forms;
using Library.Code;

#endregion

namespace WorkForceService
{
    public partial class Manager : TemplateBase
    {
        public Manager()
        {
            InitializeComponent();
           
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            try
            {
                BindViewWorkForce();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewWorkForce()
        {
            try
            {
                //todo: leggere il workFlow da Application
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}