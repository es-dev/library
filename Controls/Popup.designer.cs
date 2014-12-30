using System.Drawing;

namespace Library.Controls
{
	partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.panelPopup = new Gizmox.WebGUI.Forms.Panel();
            this.imgSeparator = new Gizmox.WebGUI.Forms.PictureBox();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(873, 224);
            this.btnConfirm.TabIndex = 999;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(772, 224);
            this.btnCancel.TabIndex = 999;
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.imgSeparator);
            this.panelMessage.Controls.Add(this.panelPopup);
            this.panelMessage.DockPadding.Left = 50;
            this.panelMessage.DockPadding.Right = 50;
            this.panelMessage.Controls.SetChildIndex(this.btnConfirm, 0);
            this.panelMessage.Controls.SetChildIndex(this.btnCancel, 0);
            this.panelMessage.Controls.SetChildIndex(this.panelPopup, 0);
            this.panelMessage.Controls.SetChildIndex(this.imgSeparator, 0);
            // 
            // panelPopup
            // 
            this.panelPopup.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelPopup.BackColor = System.Drawing.Color.White;
            this.panelPopup.Location = new System.Drawing.Point(1, 0);
            this.panelPopup.Name = "panelPopup";
            this.panelPopup.Size = new System.Drawing.Size(922, 225);
            this.panelPopup.TabIndex = 1;
            // 
            // imgSeparator
            // 
            this.imgSeparator.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgSeparator.BackColor = System.Drawing.Color.Transparent;
            this.imgSeparator.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgSeparator.Image"));
            this.imgSeparator.Location = new System.Drawing.Point(0, 225);
            this.imgSeparator.Name = "imgSeparator";
            this.imgSeparator.Size = new System.Drawing.Size(1024, 11);
            this.imgSeparator.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparator.TabIndex = 12;
            this.imgSeparator.TabStop = false;
            // 
            // Popup
            // 
            this.Load += new System.EventHandler(this.PopupControl_Load);
            this.panelMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel panelPopup;
        private Gizmox.WebGUI.Forms.PictureBox imgSeparator;
	}
}
