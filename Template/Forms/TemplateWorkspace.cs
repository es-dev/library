#region Using
using Gizmox.WebGUI.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Library.Template.MVVM;
using Library.Interfaces;
using Library.Code;
#endregion

namespace Library.Template.Forms
{
    public partial class TemplateWorkspace : TemplateBase, IWorkspace
	{
        private string livello = null;
        public string Livello
        {
            get
            {
                livello = editLivello.Text;
                return livello;
            }
            set
            {
                livello = value;
                editLivello.Text = livello;
            }
        }

        private string statoConnessione = null;
        public string StatoConnessione
        {
            get
            {
                statoConnessione = editStatoConnessione.Text;
                return statoConnessione;
            }
            set
            {
                statoConnessione = value;
                editStatoConnessione.Text = statoConnessione;
            }
        }

        private string nickame = null;
        public string Nickname
        {
            get
            {
                nickame = btnModifyAccount.Text;
                return nickame;
            }
            set
            {
                nickame = value;
                btnModifyAccount.Text = nickame;
            }
        }

        private string ragioneSociale = null;
        public string RagioneSociale
        {
            get
            {
                ragioneSociale = editRagioneSociale.Text;
                return ragioneSociale;
            }
            set
            {
                ragioneSociale = value;
                editRagioneSociale.Text = ragioneSociale;
            }
        }

		public TemplateWorkspace()
		{
			InitializeComponent();            
		}

        public void AddSpace(ISpace space, bool backclosing = false)
        {
            try
            {
                if (space != null)
                {
                    var ownerSpace = space.OwnerSpace;
                    if (ownerSpace == null)
                    {
                        ownerSpace = GetSpace();
                        space.OwnerSpace = ownerSpace;
                    }
                    space.Workspace = this;
                    if(space.TitleSpace!=null)
                        this.Title = space.TitleSpace;
                    container.Controls.Clear();
                    space.Control.Dock = DockStyle.Fill;
                    container.Controls.Add(space.Control);
                    space.Control.BringToFront();
                    space.Open(backclosing);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private ISpace GetSpace()
        {
            try
            {
                ISpace space = null;
                if (container.Controls.Count >= 1)
                    space = (ISpace)container.Controls[0];
                return space;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void RemoveSpace(ISpace space)
        {
            try
            {
                if (space != null)
                    container.Controls.Remove(space.Control);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void CloseSpace(ISpace space)
        {
            try
            {
                if (space != null)
                {
                    space.Close();
                    var ownerSpace = space.OwnerSpace;
                    if (ownerSpace != null)
                    {
                        RemoveSpace(space);
                        AddSpace(ownerSpace, true);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                panelAccount.Visible = !panelAccount.Visible;
                panelAccount.BringToFront();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            try
            {
                panelAccount.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Logout();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual void Logout() { }
    }
}
