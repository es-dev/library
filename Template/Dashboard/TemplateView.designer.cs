using System.Drawing;

namespace Library.Template.Dashboard
{
    partial class TemplateView
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
            this.btnEnterpriseManager = new Library.Controls.ButtonSeparatorV();
            this.btnManualeOperativo = new Library.Controls.ButtonSeparatorV();
            this.btnCreateTicket = new Library.Controls.ButtonSeparatorV();
            this.btnLogAttivita = new Library.Controls.ButtonSeparatorV();
            this.btnSendBug = new Library.Controls.ButtonSeparatorV();
            this.panelCommands.SuspendLayout();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnSendBug);
            this.panelCommands.Controls.Add(this.btnLogAttivita);
            this.panelCommands.Controls.Add(this.btnCreateTicket);
            this.panelCommands.Controls.Add(this.btnManualeOperativo);
            this.panelCommands.Controls.Add(this.btnEnterpriseManager);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnAdd, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnEnterpriseManager, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnManualeOperativo, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnCreateTicket, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnLogAttivita, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSendBug, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1, 210);
            this.btnAdd.Visible = false;
            // 
            // btnEnterpriseManager
            // 
            this.btnEnterpriseManager.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnEnterpriseManager.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterpriseManager.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnEnterpriseManager.ImageButton = "";
            this.btnEnterpriseManager.ImageSeparator = "Images.separator_ht_small.png";
            this.btnEnterpriseManager.Location = new System.Drawing.Point(0, 144);
            this.btnEnterpriseManager.Name = "btnEnterpriseManager";
            this.btnEnterpriseManager.Size = new System.Drawing.Size(100, 72);
            this.btnEnterpriseManager.TabIndex = 2;
            this.btnEnterpriseManager.TextButton = "Enteprise Manager";
            this.btnEnterpriseManager.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnEnterpriseManager_Click);
            // 
            // btnManualeOperativo
            // 
            this.btnManualeOperativo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnManualeOperativo.BackColor = System.Drawing.Color.Transparent;
            this.btnManualeOperativo.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnManualeOperativo.ImageButton = "";
            this.btnManualeOperativo.ImageSeparator = "Images.separator_ht_small.png";
            this.btnManualeOperativo.Location = new System.Drawing.Point(0, 216);
            this.btnManualeOperativo.Name = "btnManualeOperativo";
            this.btnManualeOperativo.Size = new System.Drawing.Size(100, 72);
            this.btnManualeOperativo.TabIndex = 2;
            this.btnManualeOperativo.TextButton = "Manuale operativo";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCreateTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateTicket.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnCreateTicket.ImageButton = "";
            this.btnCreateTicket.ImageSeparator = "Images.separator_ht_small.png";
            this.btnCreateTicket.Location = new System.Drawing.Point(0, 288);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(100, 72);
            this.btnCreateTicket.TabIndex = 2;
            this.btnCreateTicket.TextButton = "Apri un eTicket";
            // 
            // btnLogAttivita
            // 
            this.btnLogAttivita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnLogAttivita.BackColor = System.Drawing.Color.Transparent;
            this.btnLogAttivita.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnLogAttivita.ImageButton = "";
            this.btnLogAttivita.ImageSeparator = "Images.separator_ht_small.png";
            this.btnLogAttivita.Location = new System.Drawing.Point(0, 360);
            this.btnLogAttivita.Name = "btnLogAttivita";
            this.btnLogAttivita.Size = new System.Drawing.Size(100, 72);
            this.btnLogAttivita.TabIndex = 2;
            this.btnLogAttivita.TextButton = "Log attivit� utenti";
            // 
            // btnSendBug
            // 
            this.btnSendBug.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnSendBug.BackColor = System.Drawing.Color.Transparent;
            this.btnSendBug.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnSendBug.ImageButton = "";
            this.btnSendBug.ImageSeparator = "Images.separator_ht_small.png";
            this.btnSendBug.Location = new System.Drawing.Point(0, 432);
            this.btnSendBug.Name = "btnSendBug";
            this.btnSendBug.Size = new System.Drawing.Size(100, 72);
            this.btnSendBug.TabIndex = 2;
            this.btnSendBug.TextButton = "Segnala un bug al team";
            // 
            // TemplateView
            // 
            this.Opened += new Library.Interfaces.OpenHandler(this.TemplateView_Opened);
            this.Controls.SetChildIndex(this.panelOrderBy, 0);
            this.Controls.SetChildIndex(this.panelAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnOrderBy, 0);
            this.Controls.SetChildIndex(this.btnAdvancedSearch, 0);
            this.Controls.SetChildIndex(this.panelCommands, 0);
            this.panelCommands.ResumeLayout(false);
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Controls.ButtonSeparatorV btnLogAttivita;
        private Library.Controls.ButtonSeparatorV btnCreateTicket;
        private Library.Controls.ButtonSeparatorV btnManualeOperativo;
        private Library.Controls.ButtonSeparatorV btnEnterpriseManager;
        private Library.Controls.ButtonSeparatorV btnSendBug;
	}
}
