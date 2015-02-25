using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class LinkUrl
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
            this.imgReport = new Gizmox.WebGUI.Forms.PictureBox();
            this.editLink = new Gizmox.WebGUI.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // imgReport
            // 
            this.imgReport.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgReport.BackColor = System.Drawing.Color.Transparent;
            this.imgReport.Location = new System.Drawing.Point(305, 0);
            this.imgReport.Name = "imgReport";
            this.imgReport.Size = new System.Drawing.Size(30, 30);
            this.imgReport.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReport.TabIndex = 3;
            this.imgReport.TabStop = false;
            // 
            // editLink
            // 
            this.editLink.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLink.LinkColor = System.Drawing.Color.Blue;
            this.editLink.Location = new System.Drawing.Point(0, 0);
            this.editLink.Name = "editLink";
            this.editLink.Size = new System.Drawing.Size(302, 30);
            this.editLink.TabIndex = 4;
            this.editLink.TabStop = true;
            this.editLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LinkUrl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editLink);
            this.Controls.Add(this.imgReport);
            this.Size = new System.Drawing.Size(340, 30);
            this.Text = "TextCombo";
            ((System.ComponentModel.ISupportInitialize)(this.imgReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgReport;
        private LinkLabel editLink;


    }
}