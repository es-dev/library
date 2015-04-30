using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class CheckButton
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
            this.lblTrue = new Gizmox.WebGUI.Forms.Label();
            this.lblFalse = new Gizmox.WebGUI.Forms.Label();
            this.imgTrue = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgFalse = new Gizmox.WebGUI.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrue
            // 
            this.lblTrue.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblTrue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrue.Location = new System.Drawing.Point(26, 0);
            this.lblTrue.Margin = new Gizmox.WebGUI.Forms.Padding(5, 0, 0, 0);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(112, 28);
            this.lblTrue.TabIndex = 1000;
            this.lblTrue.Text = "TRUE";
            this.lblTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrue.Click += new System.EventHandler(this.imgTrue_Click);
            // 
            // lblFalse
            // 
            this.lblFalse.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblFalse.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblFalse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalse.Location = new System.Drawing.Point(164, 0);
            this.lblFalse.Margin = new Gizmox.WebGUI.Forms.Padding(5, 0, 0, 0);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(108, 28);
            this.lblFalse.TabIndex = 1000;
            this.lblFalse.Text = "FALSE";
            this.lblFalse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFalse.Click += new System.EventHandler(this.imgFalse_Click);
            // 
            // imgTrue
            // 
            this.imgTrue.BackColor = System.Drawing.Color.Transparent;
            this.imgTrue.Location = new System.Drawing.Point(1, 5);
            this.imgTrue.Name = "imgTrue";
            this.imgTrue.Size = new System.Drawing.Size(20, 20);
            this.imgTrue.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrue.TabIndex = 1001;
            this.imgTrue.TabStop = false;
            this.imgTrue.Click += new System.EventHandler(this.imgTrue_Click);
            // 
            // imgFalse
            // 
            this.imgFalse.BackColor = System.Drawing.Color.Transparent;
            this.imgFalse.Location = new System.Drawing.Point(138, 5);
            this.imgFalse.Name = "imgFalse";
            this.imgFalse.Size = new System.Drawing.Size(20, 20);
            this.imgFalse.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFalse.TabIndex = 1001;
            this.imgFalse.TabStop = false;
            this.imgFalse.Click += new System.EventHandler(this.imgFalse_Click);
            // 
            // CheckButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgFalse);
            this.Controls.Add(this.imgTrue);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Size = new System.Drawing.Size(272, 30);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFalse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTrue;
        private Label lblFalse;
        private PictureBox imgTrue;
        private PictureBox imgFalse;


    }
}