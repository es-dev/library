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

		public TemplateWorkspace()
		{
			InitializeComponent();            
		}

        public void AddSpace(ISpace space)
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
                    space.Control.Dock = DockStyle.Fill;
                    this.Title = space.TitleSpace;
                    container.Controls.Clear();
                    container.Controls.Add(space.Control);
                    space.Control.BringToFront();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public ISpace GetSpace()
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

        public void RemoveSpace(ISpace space)
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
                    var ownerSpace = space.OwnerSpace;
                    if (ownerSpace != null)
                    {
                        RemoveSpace(space);
                        AddSpace(ownerSpace);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
