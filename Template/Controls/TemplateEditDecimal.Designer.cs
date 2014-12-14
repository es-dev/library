using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditDecimal
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
            // editControl
            // 
            this.editControl.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editControl.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl.Location = new System.Drawing.Point(100, 1);
            this.editControl.Name = "editControl";
            this.editControl.Size = new System.Drawing.Size(351, 27);
            this.editControl.TabIndex = 3;
            // 
            // TemplateEditNumeric
            // 
            this.Controls.Add(this.editControl);
            this.Text = "TemplateEditNumeric";
            this.Controls.SetChildIndex(this.editControl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Controls.TextBox editControl;

        



    }
}