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
        private Gizmox.WebGUI.Common.Resources.ResourceHandle backgroundImage = null;
        public override Gizmox.WebGUI.Common.Resources.ResourceHandle BackgroundImage
        {
            get
            {
                backgroundImage = base.BackgroundImage;
                return backgroundImage;
            }
            set
            {
                backgroundImage = value;
                SetBackgroundImage(backgroundImage);
            }
        }

        private void SetBackgroundImage(Gizmox.WebGUI.Common.Resources.ResourceHandle backgroundImage)
        {
            try
            {
                base.BackgroundImage = backgroundImage;
                container.BackgroundImage = backgroundImage;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string title = null;
        public string Title
        {
            get
            {
                title = editTitle.Text;
                return title;
            }
            set
            {
                title = value;
                editTitle.Text = title;
            }
        }

        private string version = null;
        public string Version
        {
            get
            {
                version = editVersion.Text;
                return version;
            }
            set
            {
                version = value;
                editVersion.Text = version;
            }
        }

        private string softwareHouse = "ESD - Engineering System Development";
        public string SoftwareHouse
        {
            get
            {
                softwareHouse = editSoftwareHouse.Text;
                return softwareHouse;
            }
            set
            {
                softwareHouse = value;
                editSoftwareHouse.Text = softwareHouse;
            }
        }

        private string urlHomePortal = "http://www.es-dev.it.it";
        public string UrlHomePortal
        {
            get
            {
                return urlHomePortal;
            }
            set
            {
                urlHomePortal = value;
            }
        }
        private string logoSoftware = null;
        public string LogoSoftware
        {
            get
            {
                return logoSoftware;
            }
            set
            {
                logoSoftware = value;
                imgLogoSoftware.Image = logoSoftware;
            }
        }

        private string logoESD = null;
        public string LogoESD
        {
            get
            {
                return logoESD;
            }
            set
            {
                logoESD = value;
                imgLogoESD.Image = logoESD;
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
                Context.Redirect(urlHomePortal);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

      
    }
}