using System.Drawing;

namespace Library.Template.Forms
{
	partial class TemplateWorkspace
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
            this.btnAccount = new Gizmox.WebGUI.Forms.Button();
            this.container = new Gizmox.WebGUI.Forms.Panel();
            this.toolStripSeparator3 = new Gizmox.WebGUI.Forms.ToolStripSeparator();
            this.progressBar = new Gizmox.WebGUI.Forms.ToolStripProgressBar();
            this.lblProgressBar = new Gizmox.WebGUI.Forms.ToolStripLabel();
            this.SuspendLayout();
            // 
            // bntPortaleWebAziendale
            // 
            this.bntPortaleWebAziendale.Location = new System.Drawing.Point(455, 3);
            // 
            // btnSupportoTecnico
            // 
            this.btnSupportoTecnico.Location = new System.Drawing.Point(607, 3);
            // 
            // btnInformazioni
            // 
            this.btnInformazioni.Location = new System.Drawing.Point(716, 3);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.progressBar,
            this.lblProgressBar});
            // 
            // infoTitle
            // 
            this.infoTitle.Location = new System.Drawing.Point(455, 42);
            this.infoTitle.Size = new System.Drawing.Size(461, 32);
            // 
            // panelInfo
            // 
            this.panelInfo.Location = new System.Drawing.Point(407, 41);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnAccount.CustomStyle = "F";
            this.btnAccount.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.Location = new System.Drawing.Point(815, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(101, 38);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account utente";
            // 
            // container
            // 
            this.container.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.container.Location = new System.Drawing.Point(0, 84);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1024, 659);
            this.container.TabIndex = 7;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(0, 0);
            // 
            // TemplateWorkspace
            // 
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.container);
            this.Controls.SetChildIndex(this.container, 0);
            this.Controls.SetChildIndex(this.bntPortaleWebAziendale, 0);
            this.Controls.SetChildIndex(this.btnSupportoTecnico, 0);
            this.Controls.SetChildIndex(this.btnInformazioni, 0);
            this.Controls.SetChildIndex(this.infoTitle, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.btnAccount, 0);
            this.Controls.SetChildIndex(this.panelInfo, 0);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel container;
        private Gizmox.WebGUI.Forms.ToolStripProgressBar progressBar;
        private Gizmox.WebGUI.Forms.ToolStripLabel lblProgressBar;
        public Gizmox.WebGUI.Forms.Button btnAccount;
        private Gizmox.WebGUI.Forms.ToolStripSeparator toolStripSeparator3;
	}
}
