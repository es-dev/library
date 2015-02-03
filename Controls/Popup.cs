using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Library.Controls;
using Gizmox.WebGUI.Forms;
using Library.Code;
using Library.Code.Enum;

namespace Library.Controls
{
    public partial class Popup : PopupBase
    {
        public Popup() : base()
        {
            InitializeComponent();
        }

        public Popup(Control owner, TypeDirection direction) : base(owner, direction)
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PopupControl_Load(object sender, EventArgs e)
        {
            try
            {
                panelPopup.Top = 0;
                panelPopup.Width = panelMessage.Width;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void Show(Control control)
        {
            try
            {
                if (control != null)
                {                    
                    control.Dock = DockStyle.Fill;
                    panelPopup.Controls.Add(control);
                    control.BringToFront();
                    this.BringToFront();
                    if(control.CanFocus)
                        control.Focus();
                }
                base.Show();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
