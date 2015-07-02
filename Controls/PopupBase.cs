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

#endregion

namespace Library.Controls
{
    public partial class PopupBase : UserControl
    {
       
        private Form parent = null;
        private TypeDirection direction = TypeDirection.Horizontal;

        public PopupBase()
        {
            InitializeComponent();
        }

        public PopupBase(Control owner, TypeDirection direction)
        {
            InitializeComponent();
            try
            {
                this.parent = UtilityWeb.GetParentForm(owner);
                this.direction = direction;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PopupBaseControl_Load(object sender, EventArgs e)
        {
            try
            {
                SetLayoutDirection();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }        

        public new void Show()
        {
            try
            {
                if (parent != null)
                {
                    parent.Controls.Add(this);
                    this.BringToFront();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetLayoutDirection()
        {
            try
            {
                if (parent != null)
                {
                    this.Top = 0;
                    this.Left = 0;
                    this.Width = parent.Width;
                    this.Height = parent.Height;
                    this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    if (direction == TypeDirection.Horizontal)
                    {
                        panelMessage.Top = (this.Height - panelMessage.Height) / 2;
                        panelMessage.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    }
                    else if (direction == TypeDirection.Vertical)
                    {
                        int margin = 150;
                        panelMessage.Top = 0;
                        panelMessage.Left = margin;
                        panelMessage.Width = this.Width - (margin * 2);
                        panelMessage.Height = this.Height;
                        panelMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }        

        public delegate void ConfirmPopupHanlder();

        public event ConfirmPopupHanlder Confirm;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(parent!=null)
                    parent.Controls.Remove(this);
                if (Confirm != null)
                    Confirm();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (parent != null)
                    parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }

    
   
}