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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateWorkspace));
            this.btnAccount = new Gizmox.WebGUI.Forms.Button();
            this.toolStripSeparator3 = new Gizmox.WebGUI.Forms.ToolStripSeparator();
            this.lblAzienda = new Gizmox.WebGUI.Forms.Label();
            this.editRagioneSociale = new Gizmox.WebGUI.Forms.Label();
            this.editStatoConnessione = new Gizmox.WebGUI.Forms.Label();
            this.lblStatoConnessione = new Gizmox.WebGUI.Forms.Label();
            this.imgSeparatorV = new Gizmox.WebGUI.Forms.PictureBox();
            this.btnCloseAccount = new Gizmox.WebGUI.Forms.Button();
            this.btnLogout = new Gizmox.WebGUI.Forms.Button();
            this.lblDatiUtente = new Gizmox.WebGUI.Forms.Label();
            this.btnModifyAccount = new Gizmox.WebGUI.Forms.Button();
            this.editLivello = new Gizmox.WebGUI.Forms.Label();
            this.lblLivello = new Gizmox.WebGUI.Forms.Label();
            this.lblTitleAccount = new Gizmox.WebGUI.Forms.Label();
            this.imgAccount = new Gizmox.WebGUI.Forms.PictureBox();
            this.panelAccount = new Gizmox.WebGUI.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparatorV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).BeginInit();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            // 
            // panelInfo
            // 
            this.panelInfo.Location = new System.Drawing.Point(407, 41);
            // 
            // bntPortaleWebAziendale
            // 
            this.bntPortaleWebAziendale.Location = new System.Drawing.Point(453, 3);
            // 
            // btnSupportoTecnico
            // 
            this.btnSupportoTecnico.Location = new System.Drawing.Point(606, 3);
            // 
            // btnInformazioni
            // 
            this.btnInformazioni.Location = new System.Drawing.Point(716, 3);
            // 
            // editTitle
            // 
            this.editTitle.Location = new System.Drawing.Point(453, 42);
            this.editTitle.Size = new System.Drawing.Size(462, 32);
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
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // lblAzienda
            // 
            this.lblAzienda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzienda.ForeColor = System.Drawing.Color.DimGray;
            this.lblAzienda.Location = new System.Drawing.Point(83, 134);
            this.lblAzienda.Name = "lblAzienda";
            this.lblAzienda.Size = new System.Drawing.Size(58, 18);
            this.lblAzienda.TabIndex = 1;
            this.lblAzienda.Text = "Azienda:";
            // 
            // editRagioneSociale
            // 
            this.editRagioneSociale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRagioneSociale.ForeColor = System.Drawing.Color.Black;
            this.editRagioneSociale.Location = new System.Drawing.Point(141, 134);
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.Size = new System.Drawing.Size(250, 18);
            this.editRagioneSociale.TabIndex = 1;
            this.editRagioneSociale.Text = "Nessuna azienda";
            // 
            // editStatoConnessione
            // 
            this.editStatoConnessione.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStatoConnessione.ForeColor = System.Drawing.Color.Black;
            this.editStatoConnessione.Location = new System.Drawing.Point(124, 106);
            this.editStatoConnessione.Name = "editStatoConnessione";
            this.editStatoConnessione.Size = new System.Drawing.Size(261, 18);
            this.editStatoConnessione.TabIndex = 1;
            this.editStatoConnessione.Text = "Non connesso";
            // 
            // lblStatoConnessione
            // 
            this.lblStatoConnessione.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatoConnessione.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatoConnessione.Location = new System.Drawing.Point(83, 106);
            this.lblStatoConnessione.Name = "lblStatoConnessione";
            this.lblStatoConnessione.Size = new System.Drawing.Size(45, 18);
            this.lblStatoConnessione.TabIndex = 1;
            this.lblStatoConnessione.Text = "Stato:";
            // 
            // imgSeparatorV
            // 
            this.imgSeparatorV.BackColor = System.Drawing.Color.Transparent;
            this.imgSeparatorV.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgSeparatorV.Image"));
            this.imgSeparatorV.Location = new System.Drawing.Point(74, 50);
            this.imgSeparatorV.Name = "imgSeparatorV";
            this.imgSeparatorV.Size = new System.Drawing.Size(4, 105);
            this.imgSeparatorV.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparatorV.TabIndex = 8;
            this.imgSeparatorV.TabStop = false;
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCloseAccount.CustomStyle = "F";
            this.btnCloseAccount.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCloseAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAccount.ForeColor = System.Drawing.Color.Black;
            this.btnCloseAccount.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCloseAccount.Image"));
            this.btnCloseAccount.Location = new System.Drawing.Point(359, 3);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(32, 32);
            this.btnCloseAccount.TabIndex = 2;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(270, 158);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 26);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Disconnetti";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDatiUtente
            // 
            this.lblDatiUtente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatiUtente.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatiUtente.Location = new System.Drawing.Point(83, 78);
            this.lblDatiUtente.Name = "lblDatiUtente";
            this.lblDatiUtente.Size = new System.Drawing.Size(51, 18);
            this.lblDatiUtente.TabIndex = 1;
            this.lblDatiUtente.Text = "Utente:";
            // 
            // btnModifyAccount
            // 
            this.btnModifyAccount.CustomStyle = "F";
            this.btnModifyAccount.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnModifyAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyAccount.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnModifyAccount.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnModifyAccount.Image"));
            this.btnModifyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyAccount.Location = new System.Drawing.Point(136, 74);
            this.btnModifyAccount.Name = "btnModifyAccount";
            this.btnModifyAccount.Size = new System.Drawing.Size(152, 25);
            this.btnModifyAccount.TabIndex = 2;
            this.btnModifyAccount.Text = "    Modifica profilo";
            // 
            // editLivello
            // 
            this.editLivello.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLivello.ForeColor = System.Drawing.Color.Black;
            this.editLivello.Location = new System.Drawing.Point(132, 50);
            this.editLivello.Name = "editLivello";
            this.editLivello.Size = new System.Drawing.Size(242, 18);
            this.editLivello.TabIndex = 1;
            this.editLivello.Text = "Non definito";
            // 
            // lblLivello
            // 
            this.lblLivello.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivello.ForeColor = System.Drawing.Color.DimGray;
            this.lblLivello.Location = new System.Drawing.Point(83, 50);
            this.lblLivello.Name = "lblLivello";
            this.lblLivello.Size = new System.Drawing.Size(51, 18);
            this.lblLivello.TabIndex = 1;
            this.lblLivello.Text = "Livello:";
            // 
            // lblTitleAccount
            // 
            this.lblTitleAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAccount.Location = new System.Drawing.Point(80, 1);
            this.lblTitleAccount.Name = "lblTitleAccount";
            this.lblTitleAccount.Size = new System.Drawing.Size(269, 33);
            this.lblTitleAccount.TabIndex = 1;
            this.lblTitleAccount.Text = "Il tuo profilo utente";
            // 
            // imgAccount
            // 
            this.imgAccount.BackColor = System.Drawing.Color.Transparent;
            this.imgAccount.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgAccount.Image"));
            this.imgAccount.Location = new System.Drawing.Point(3, 2);
            this.imgAccount.Name = "imgAccount";
            this.imgAccount.Size = new System.Drawing.Size(64, 64);
            this.imgAccount.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAccount.TabIndex = 0;
            this.imgAccount.TabStop = false;
            // 
            // panelAccount
            // 
            this.panelAccount.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelAccount.BackColor = System.Drawing.Color.White;
            this.panelAccount.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Silver);
            this.panelAccount.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panelAccount.Controls.Add(this.lblAzienda);
            this.panelAccount.Controls.Add(this.editRagioneSociale);
            this.panelAccount.Controls.Add(this.editStatoConnessione);
            this.panelAccount.Controls.Add(this.lblStatoConnessione);
            this.panelAccount.Controls.Add(this.imgSeparatorV);
            this.panelAccount.Controls.Add(this.btnCloseAccount);
            this.panelAccount.Controls.Add(this.btnLogout);
            this.panelAccount.Controls.Add(this.lblDatiUtente);
            this.panelAccount.Controls.Add(this.btnModifyAccount);
            this.panelAccount.Controls.Add(this.editLivello);
            this.panelAccount.Controls.Add(this.lblLivello);
            this.panelAccount.Controls.Add(this.lblTitleAccount);
            this.panelAccount.Controls.Add(this.imgAccount);
            this.panelAccount.Location = new System.Drawing.Point(517, 42);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(399, 194);
            this.panelAccount.TabIndex = 8;
            this.panelAccount.Visible = false;
            // 
            // TemplateWorkspace
            // 
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.btnAccount);
            this.Controls.SetChildIndex(this.editTitle, 0);
            this.Controls.SetChildIndex(this.bntPortaleWebAziendale, 0);
            this.Controls.SetChildIndex(this.btnSupportoTecnico, 0);
            this.Controls.SetChildIndex(this.btnInformazioni, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.btnAccount, 0);
            this.Controls.SetChildIndex(this.panelAccount, 0);
            this.Controls.SetChildIndex(this.panelInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparatorV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.ToolStripSeparator toolStripSeparator3;
        private Gizmox.WebGUI.Forms.Label lblAzienda;
        private Gizmox.WebGUI.Forms.Label editRagioneSociale;
        private Gizmox.WebGUI.Forms.Label editStatoConnessione;
        private Gizmox.WebGUI.Forms.Label lblStatoConnessione;
        private Gizmox.WebGUI.Forms.PictureBox imgSeparatorV;
        private Gizmox.WebGUI.Forms.Button btnCloseAccount;
        private Gizmox.WebGUI.Forms.Button btnLogout;
        private Gizmox.WebGUI.Forms.Label lblDatiUtente;
        private Gizmox.WebGUI.Forms.Button btnModifyAccount;
        private Gizmox.WebGUI.Forms.Label editLivello;
        private Gizmox.WebGUI.Forms.Label lblLivello;
        private Gizmox.WebGUI.Forms.Label lblTitleAccount;
        private Gizmox.WebGUI.Forms.PictureBox imgAccount;
        private Gizmox.WebGUI.Forms.Button btnAccount;
        public Gizmox.WebGUI.Forms.Panel panelAccount;
	}
}
