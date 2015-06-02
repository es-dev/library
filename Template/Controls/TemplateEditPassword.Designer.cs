using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;
using Library.Code;

namespace Library.Template.Controls
{
    partial class TemplateEditPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editControl = new Library.Controls.TextBox();
            this.SuspendLayout();
            // 
            // editLabel
            // 
            this.editLabel.TabIndex = 999;
            // 
            // editControl
            // 
            this.editControl.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editControl.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editControl.BackColor = System.Drawing.Color.Transparent;
            this.editControl.Behavior = Library.Code.TypeBehavior.Text;
            this.editControl.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl.Location = new System.Drawing.Point(100, 0);
            this.editControl.Mask = "---";
            this.editControl.Name = "editControl";
            this.editControl.ReadOnly = false;
            this.editControl.Size = new System.Drawing.Size(350, 30);
            this.editControl.TabIndex = 0;
            this.editControl.Text = null;
            this.editControl.Value = null;
            // 
            // TemplateEditPassword
            // 
            this.Controls.Add(this.editControl);
            this.Text = "";
            this.Controls.SetChildIndex(this.editControl, 0);
            this.Controls.SetChildIndex(this.editLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Controls.TextBox editControl;

    }
}