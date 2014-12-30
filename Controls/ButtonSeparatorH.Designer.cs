using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class ButtonSeparatorH
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
            this.imgSeparator = new Gizmox.WebGUI.Forms.PictureBox();
            this.btnControl = new Gizmox.WebGUI.Forms.Button();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.panelRight = new Gizmox.WebGUI.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSeparator
            // 
            this.imgSeparator.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgSeparator.BackColor = System.Drawing.Color.Transparent;
            this.imgSeparator.Location = new System.Drawing.Point(6, 0);
            this.imgSeparator.Name = "imgSeparator";
            this.imgSeparator.Size = new System.Drawing.Size(4, 26);
            this.imgSeparator.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparator.TabIndex = 0;
            this.imgSeparator.TabStop = false;
            // 
            // btnControl
            // 
            this.btnControl.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnControl.CustomStyle = "F";
            this.btnControl.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnControl.Location = new System.Drawing.Point(0, 0);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(152, 26);
            this.btnControl.TabIndex = 999;
            this.btnControl.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelLeft.Controls.Add(this.btnControl);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(157, 27);
            this.panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelRight.Controls.Add(this.imgSeparator);
            this.panelRight.Location = new System.Drawing.Point(157, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(10, 27);
            this.panelRight.TabIndex = 1;
            // 
            // ButtonSeparatorH
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Size = new System.Drawing.Size(167, 27);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgSeparator;
        private Button btnControl;
        private Panel panelLeft;
        private Panel panelRight;



    }
}