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
            this.container = new Gizmox.WebGUI.Forms.Panel();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.container.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(305, 82);
            this.container.TabIndex = 0;
            // 
            // JQPanel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.container);
            this.Size = new System.Drawing.Size(305, 82);
            this.Text = "JQPanel1";
            this.ResumeLayout(false);

        }

        #endregion

        public Panel container;



    }
}