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
using Library.Code;

#endregion

namespace Library.Template.Forms
{
    public partial class TemplateBase : Form
    {
        private string title = null;
        public string Title
        {
            get
            {
                title = infoTitle.Text;
                return title;
            }
            set
            {
                title = value;
                infoTitle.Text = title;
            }
        }

        private string version = null;
        public string Version
        {
            get
            {
                version = infoVersion.Text;
                return version;
            }
            set
            {
                version = value;
                infoVersion.Text = version;
            }
        }

        public TemplateBase()
        {
            InitializeComponent();
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            try
            {
                panelInfo.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnInformazioni_Click(object sender, EventArgs e)
        {
            try
            {
                panelInfo.Visible = !panelInfo.Visible;
                if (panelInfo.Visible)
                    panelInfo.BringToFront();          
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnInfoAzienda_Click(object sender, EventArgs e)
        {
            try
            {
                Context.Redirect("http://www.es-dev.it");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnSupportoTecnico_Click(object sender, EventArgs e)
        {
            try
            {
                Context.Redirect("http://www.es-dev.it/support");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void bntPortaleWebAziendale_Click(object sender, EventArgs e)
        {
            try
            {
                Context.Redirect("http://www.portaleaziendale.it");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

      
    }
}