using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class ButtonSeparatorV
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
            this.panelTop = new Gizmox.WebGUI.Forms.Panel();
            this.panelBottom = new Gizmox.WebGUI.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSeparator
            // 
            this.imgSeparator.BackColor = System.Drawing.Color.Transparent;
            this.imgSeparator.Location = new System.Drawing.Point(0, 1);
            this.imgSeparator.Name = "imgSeparator";
            this.imgSeparator.Size = new System.Drawing.Size(100, 7);
            this.imgSeparator.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSeparator.TabIndex = 0;
            this.imgSeparator.TabStop = false;
            // 
            // btnControl
            // 
            this.btnControl.CustomStyle = "F";
            this.btnControl.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnControl.Location = new System.Drawing.Point(6, 4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(86, 51);
            this.btnControl.TabIndex = 0;
            this.btnControl.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageAboveText;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.btnControl);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(100, 62);
            this.panelTop.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.imgSeparator);
            this.panelBottom.Location = new System.Drawing.Point(0, 62);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(100, 10);
            this.panelBottom.TabIndex = 2;
            // 
            // ButtonSeparatorV
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Size = new System.Drawing.Size(100, 72);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgSeparator;
        private Button btnControl;
        private Panel panelTop;
        private Panel panelBottom;


    }
}