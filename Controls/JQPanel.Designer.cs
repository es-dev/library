using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class JQPanel
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
            this.jqContainer = new Gizmox.WebGUI.Forms.Panel();
            this.SuspendLayout();
            // 
            // jqContainer
            // 
            this.jqContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.jqContainer.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.jqContainer.Location = new System.Drawing.Point(0, 0);
            this.jqContainer.Name = "jqContainer";
            this.jqContainer.Size = new System.Drawing.Size(305, 82);
            this.jqContainer.TabIndex = 0;
            // 
            // JQPanel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.jqContainer);
            this.Size = new System.Drawing.Size(305, 82);
            this.Text = "JQPanel1";
            this.ResumeLayout(false);

        }

        #endregion

        public Panel jqContainer;







    }
}