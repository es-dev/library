using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class OptionButton
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
            this.lblOption = new Gizmox.WebGUI.Forms.Label();
            this.imgOption = new Gizmox.WebGUI.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOption
            // 
            this.lblOption.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblOption.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(30, 0);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(242, 28);
            this.lblOption.TabIndex = 1000;
            this.lblOption.Text = "Option";
            this.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption.Click += new System.EventHandler(this.imgOption_Click);
            // 
            // imgOption
            // 
            this.imgOption.BackColor = System.Drawing.Color.Transparent;
            this.imgOption.Location = new System.Drawing.Point(0, 0);
            this.imgOption.Name = "imgOption";
            this.imgOption.Size = new System.Drawing.Size(30, 30);
            this.imgOption.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.CenterImage;
            this.imgOption.TabIndex = 1001;
            this.imgOption.TabStop = false;
            this.imgOption.Click += new System.EventHandler(this.imgOption_Click);
            // 
            // OptionButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgOption);
            this.Controls.Add(this.lblOption);
            this.Size = new System.Drawing.Size(272, 30);
            ((System.ComponentModel.ISupportInitialize)(this.imgOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblOption;
        private PictureBox imgOption;


    }
}