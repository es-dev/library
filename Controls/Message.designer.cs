using System.Drawing;

namespace Library.Controls
{
	partial class Message
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.imgIcon = new Gizmox.WebGUI.Forms.PictureBox();
            this.lblTitle = new Gizmox.WebGUI.Forms.Label();
            this.lblDescription = new Gizmox.WebGUI.Forms.Label();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(822, 157);
            this.btnConfirm.TabIndex = 999;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 157);
            this.btnCancel.TabIndex = 999;
            // 
            // panelMessage
            // 
            this.panelMessage.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelMessage.Controls.Add(this.lblDescription);
            this.panelMessage.Controls.Add(this.lblTitle);
            this.panelMessage.Controls.Add(this.imgIcon);
            this.panelMessage.DockPadding.Left = 50;
            this.panelMessage.DockPadding.Right = 50;
            this.panelMessage.MinimumSize = new System.Drawing.Size(300, 0);
            this.panelMessage.Size = new System.Drawing.Size(1024, 235);
            this.panelMessage.Controls.SetChildIndex(this.btnConfirm, 0);
            this.panelMessage.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelMessage.Controls.SetChildIndex(this.imgIcon, 0);
            this.panelMessage.Controls.SetChildIndex(this.lblTitle, 0);
            this.panelMessage.Controls.SetChildIndex(this.lblDescription, 0);
            // 
            // imgIcon
            // 
            this.imgIcon.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top;
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.imgIcon.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.imgIcon.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgIcon.Location = new System.Drawing.Point(123, 24);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(48, 48);
            this.imgIcon.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcon.TabIndex = 1;
            this.imgIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(198, 11);
            this.lblTitle.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(712, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom)));
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(204, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(712, 90);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // Message
            // 
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Load += new System.EventHandler(this.MessageControl_Load);
            this.panelMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.PictureBox imgIcon;
        private Gizmox.WebGUI.Forms.Label lblTitle;
        private Gizmox.WebGUI.Forms.Label lblDescription;
	}
}
