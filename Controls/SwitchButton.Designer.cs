using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class SwitchButton
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
            this.lblSwitch = new Gizmox.WebGUI.Forms.Label();
            this.imgSwitch = new Gizmox.WebGUI.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSwitch
            // 
            this.lblSwitch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblSwitch.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblSwitch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch.Location = new System.Drawing.Point(68, 0);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(204, 28);
            this.lblSwitch.TabIndex = 1000;
            this.lblSwitch.Text = "Option";
            this.lblSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSwitch.Click += new System.EventHandler(this.imgSwitch_Click);
            // 
            // imgSwitch
            // 
            this.imgSwitch.BackColor = System.Drawing.Color.Transparent;
            this.imgSwitch.Location = new System.Drawing.Point(0, 3);
            this.imgSwitch.Name = "imgSwitch";
            this.imgSwitch.Size = new System.Drawing.Size(60, 24);
            this.imgSwitch.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSwitch.TabIndex = 1001;
            this.imgSwitch.TabStop = false;
            this.imgSwitch.Click += new System.EventHandler(this.imgSwitch_Click);
            // 
            // SwitchButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgSwitch);
            this.Controls.Add(this.lblSwitch);
            this.Size = new System.Drawing.Size(272, 30);
            ((System.ComponentModel.ISupportInitialize)(this.imgSwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSwitch;
        private PictureBox imgSwitch;


    }
}