using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.MVVM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateView));
            this.infoTitle = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands = new Gizmox.WebGUI.Forms.Panel();
            this.btnHome = new Library.Controls.ButtonSeparatorV();
            this.btnClose = new Library.Controls.ButtonSeparatorV();
            this.btnRefresh = new Library.Controls.ButtonSeparatorV();
            this.btnAdd = new Library.Controls.ButtonSeparatorV();
            this.txtSearch = new Gizmox.WebGUI.Forms.SearchTextBox();
            this.container = new Library.Controls.PagingContainer();
            this.btnOrderBy = new Library.Controls.ButtonSeparatorH();
            this.btnAdvancedSearch = new Library.Controls.ButtonSeparatorH();
            this.imgSeparator = new Gizmox.WebGUI.Forms.PictureBox();
            this.editCount = new Gizmox.WebGUI.Forms.Label();
            this.panelAdvancedSearch = new Gizmox.WebGUI.Forms.Panel();
            this.lblTitleAdvancedSearch = new Gizmox.WebGUI.Forms.Label();
            this.btnCancelAdvancedSearch = new Gizmox.WebGUI.Forms.Button();
            this.btnCloseAdvancedSearch = new Gizmox.WebGUI.Forms.Button();
            this.btnConfirmAdvancedSearch = new Gizmox.WebGUI.Forms.Button();
            this.btnCancelOrderBy = new Gizmox.WebGUI.Forms.Button();
            this.btnCloseOrderBy = new Gizmox.WebGUI.Forms.Button();
            this.btnConfirmOrderBy = new Gizmox.WebGUI.Forms.Button();
            this.panelOrderBy = new Gizmox.WebGUI.Forms.Panel();
            this.lblTitleOrderBy = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
            this.panelAdvancedSearch.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoTitle
            // 
            this.infoTitle.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.infoTitle.Location = new System.Drawing.Point(110, 0);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(460, 68);
            this.infoTitle.TabIndex = 4;
            this.infoTitle.Text = "TITLE";
            // 
            // panelCommands
            // 
            this.panelCommands.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.panelCommands.BackColor = System.Drawing.Color.Transparent;
            this.panelCommands.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("panelCommands.BackgroundImage"));
            this.panelCommands.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.panelCommands.Controls.Add(this.btnHome);
            this.panelCommands.Controls.Add(this.btnClose);
            this.panelCommands.Controls.Add(this.btnRefresh);
            this.panelCommands.Controls.Add(this.btnAdd);
            this.panelCommands.Location = new System.Drawing.Point(0, 0);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(101, 659);
            this.panelCommands.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnHome.ImageButton = "Images.home24.png";
            this.btnHome.ImageSeparator = "Images.separator_ht_small.png";
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 72);
            this.btnHome.TabIndex = 1;
            this.btnHome.TextButton = "Home";
            this.btnHome.Visible = false;
            this.btnHome.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnHome_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnClose.ImageButton = "Images.left24.png";
            this.btnClose.ImageSeparator = "Images.separator_ht_small.png";
            this.btnClose.Location = new System.Drawing.Point(0, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 72);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextButton = "Indietro";
            this.btnClose.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnRefresh.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnRefresh.ImageButton = "Images.refresh24.png";
            this.btnRefresh.ImageSeparator = "Images.separator_ht_small.png";
            this.btnRefresh.Location = new System.Drawing.Point(0, 587);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 72);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TextButton = "Refresh";
            this.btnRefresh.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnAdd.ImageButton = "Images.add24.png";
            this.btnAdd.ImageSeparator = "Images.separator_ht_small.png";
            this.btnAdd.Location = new System.Drawing.Point(0, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 72);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TextButton = "Nuovo";
            this.btnAdd.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Silver);
            this.txtSearch.CustomStyle = "STB";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.Location = new System.Drawing.Point(872, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Search += new System.EventHandler(this.txtSearch_Search);
            this.txtSearch.Clear += new System.EventHandler(this.txtSearch_Clear);
            this.txtSearch.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSearch_EnterKeyDown);
            // 
            // container
            // 
            this.container.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.container.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Gainsboro);
            this.container.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.container.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.container.Count = 0;
            this.container.Location = new System.Drawing.Point(101, 79);
            this.container.Name = "container";
            this.container.PagingControls = null;
            this.container.Size = new System.Drawing.Size(923, 580);
            this.container.TabIndex = 8;
            this.container.Text = "PagingContainer";
            this.container.CanLoad += new Library.Controls.PagingContainer.CanLoadHanlder(this.container_CanLoad);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnOrderBy.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderBy.ImageButton = "";
            this.btnOrderBy.ImageSeparator = "Images.separator_vr.png";
            this.btnOrderBy.Location = new System.Drawing.Point(574, 39);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.OriginalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnOrderBy.Size = new System.Drawing.Size(144, 27);
            this.btnOrderBy.TabIndex = 9;
            this.btnOrderBy.TextButton = "Ordina per...";
            this.btnOrderBy.Click += new Library.Controls.ButtonSeparatorH.ButtonSeparatorClick(this.btnOrderBy_Click);
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnAdvancedSearch.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvancedSearch.ImageButton = "";
            this.btnAdvancedSearch.ImageSeparator = "Images.separator_vr.png";
            this.btnAdvancedSearch.Location = new System.Drawing.Point(718, 39);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.OriginalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnAdvancedSearch.Size = new System.Drawing.Size(151, 27);
            this.btnAdvancedSearch.TabIndex = 10;
            this.btnAdvancedSearch.TextButton = "Ricerca avanzata...";
            this.btnAdvancedSearch.Click += new Library.Controls.ButtonSeparatorH.ButtonSeparatorClick(this.btnAdvancedSearch_Click);
            // 
            // imgSeparator
            // 
            this.imgSeparator.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgSeparator.BackColor = System.Drawing.Color.Transparent;
            this.imgSeparator.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgSeparator.Image"));
            this.imgSeparator.Location = new System.Drawing.Point(101, 68);
            this.imgSeparator.Name = "imgSeparator";
            this.imgSeparator.Size = new System.Drawing.Size(923, 11);
            this.imgSeparator.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparator.TabIndex = 12;
            this.imgSeparator.TabStop = false;
            // 
            // editCount
            // 
            this.editCount.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCount.BackColor = System.Drawing.Color.Transparent;
            this.editCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCount.ForeColor = System.Drawing.Color.DarkRed;
            this.editCount.Location = new System.Drawing.Point(574, 1);
            this.editCount.Name = "editCount";
            this.editCount.Size = new System.Drawing.Size(438, 17);
            this.editCount.TabIndex = 0;
            this.editCount.Text = "Voci presenti in archivio (0)";
            this.editCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAdvancedSearch
            // 
            this.panelAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelAdvancedSearch.BackColor = System.Drawing.Color.White;
            this.panelAdvancedSearch.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.LightGray);
            this.panelAdvancedSearch.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panelAdvancedSearch.Controls.Add(this.lblTitleAdvancedSearch);
            this.panelAdvancedSearch.Controls.Add(this.btnCancelAdvancedSearch);
            this.panelAdvancedSearch.Controls.Add(this.btnCloseAdvancedSearch);
            this.panelAdvancedSearch.Controls.Add(this.btnConfirmAdvancedSearch);
            this.panelAdvancedSearch.Location = new System.Drawing.Point(433, 68);
            this.panelAdvancedSearch.Name = "panelAdvancedSearch";
            this.panelAdvancedSearch.Size = new System.Drawing.Size(433, 249);
            this.panelAdvancedSearch.TabIndex = 13;
            this.panelAdvancedSearch.Visible = false;
            // 
            // lblTitleAdvancedSearch
            // 
            this.lblTitleAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblTitleAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdvancedSearch.Location = new System.Drawing.Point(6, 4);
            this.lblTitleAdvancedSearch.Name = "lblTitleAdvancedSearch";
            this.lblTitleAdvancedSearch.Size = new System.Drawing.Size(397, 44);
            this.lblTitleAdvancedSearch.TabIndex = 1;
            this.lblTitleAdvancedSearch.Tag = "advancedSearch";
            this.lblTitleAdvancedSearch.Text = "Seleziona uno o più filtri di ricerca...";
            // 
            // btnCancelAdvancedSearch
            // 
            this.btnCancelAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancelAdvancedSearch.CustomStyle = "F";
            this.btnCancelAdvancedSearch.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancelAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdvancedSearch.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancelAdvancedSearch.Image"));
            this.btnCancelAdvancedSearch.Location = new System.Drawing.Point(129, 206);
            this.btnCancelAdvancedSearch.Name = "btnCancelAdvancedSearch";
            this.btnCancelAdvancedSearch.Size = new System.Drawing.Size(158, 30);
            this.btnCancelAdvancedSearch.TabIndex = 0;
            this.btnCancelAdvancedSearch.Tag = "advancedSearch";
            this.btnCancelAdvancedSearch.Text = "Azzera filtri";
            this.btnCancelAdvancedSearch.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelAdvancedSearch.Click += new System.EventHandler(this.btnCancelAdvancedSearch_Click);
            // 
            // btnCloseAdvancedSearch
            // 
            this.btnCloseAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCloseAdvancedSearch.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCloseAdvancedSearch.BackgroundImage"));
            this.btnCloseAdvancedSearch.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCloseAdvancedSearch.CustomStyle = "F";
            this.btnCloseAdvancedSearch.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCloseAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAdvancedSearch.Location = new System.Drawing.Point(405, 2);
            this.btnCloseAdvancedSearch.Name = "btnCloseAdvancedSearch";
            this.btnCloseAdvancedSearch.Size = new System.Drawing.Size(24, 24);
            this.btnCloseAdvancedSearch.TabIndex = 0;
            this.btnCloseAdvancedSearch.Tag = "advancedSearch";
            this.btnCloseAdvancedSearch.Click += new System.EventHandler(this.btnCloselAdvancedSearch_Click);
            // 
            // btnConfirmAdvancedSearch
            // 
            this.btnConfirmAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnConfirmAdvancedSearch.CustomStyle = "F";
            this.btnConfirmAdvancedSearch.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirmAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdvancedSearch.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirmAdvancedSearch.Image"));
            this.btnConfirmAdvancedSearch.Location = new System.Drawing.Point(295, 206);
            this.btnConfirmAdvancedSearch.Name = "btnConfirmAdvancedSearch";
            this.btnConfirmAdvancedSearch.Size = new System.Drawing.Size(122, 30);
            this.btnConfirmAdvancedSearch.TabIndex = 0;
            this.btnConfirmAdvancedSearch.Tag = "advancedSearch";
            this.btnConfirmAdvancedSearch.Text = "Conferma";
            this.btnConfirmAdvancedSearch.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmAdvancedSearch.Click += new System.EventHandler(this.btnConfirmAdvancedSearch_Click);
            // 
            // btnCancelOrderBy
            // 
            this.btnCancelOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancelOrderBy.CustomStyle = "F";
            this.btnCancelOrderBy.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancelOrderBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrderBy.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancelOrderBy.Image"));
            this.btnCancelOrderBy.Location = new System.Drawing.Point(104, 207);
            this.btnCancelOrderBy.Name = "btnCancelOrderBy";
            this.btnCancelOrderBy.Size = new System.Drawing.Size(187, 30);
            this.btnCancelOrderBy.TabIndex = 0;
            this.btnCancelOrderBy.Tag = "orderBy";
            this.btnCancelOrderBy.Text = "Azzera ordinamento";
            this.btnCancelOrderBy.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelOrderBy.Click += new System.EventHandler(this.btnCancelOrderBy_Click);
            // 
            // btnCloseOrderBy
            // 
            this.btnCloseOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCloseOrderBy.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCloseOrderBy.BackgroundImage"));
            this.btnCloseOrderBy.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCloseOrderBy.CustomStyle = "F";
            this.btnCloseOrderBy.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCloseOrderBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOrderBy.Location = new System.Drawing.Point(403, 2);
            this.btnCloseOrderBy.Name = "btnCloseOrderBy";
            this.btnCloseOrderBy.Size = new System.Drawing.Size(24, 24);
            this.btnCloseOrderBy.TabIndex = 0;
            this.btnCloseOrderBy.Tag = "orderBy";
            this.btnCloseOrderBy.Click += new System.EventHandler(this.btnCloseOrderBy_Click);
            // 
            // btnConfirmOrderBy
            // 
            this.btnConfirmOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnConfirmOrderBy.CustomStyle = "F";
            this.btnConfirmOrderBy.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirmOrderBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrderBy.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirmOrderBy.Image"));
            this.btnConfirmOrderBy.Location = new System.Drawing.Point(299, 207);
            this.btnConfirmOrderBy.Name = "btnConfirmOrderBy";
            this.btnConfirmOrderBy.Size = new System.Drawing.Size(118, 30);
            this.btnConfirmOrderBy.TabIndex = 0;
            this.btnConfirmOrderBy.Tag = "orderBy";
            this.btnConfirmOrderBy.Text = "Conferma";
            this.btnConfirmOrderBy.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmOrderBy.Click += new System.EventHandler(this.btnConfirmOrderBy_Click);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelOrderBy.BackColor = System.Drawing.Color.White;
            this.panelOrderBy.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.LightGray);
            this.panelOrderBy.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panelOrderBy.Controls.Add(this.lblTitleOrderBy);
            this.panelOrderBy.Controls.Add(this.btnCancelOrderBy);
            this.panelOrderBy.Controls.Add(this.btnCloseOrderBy);
            this.panelOrderBy.Controls.Add(this.btnConfirmOrderBy);
            this.panelOrderBy.Location = new System.Drawing.Point(283, 69);
            this.panelOrderBy.Name = "panelOrderBy";
            this.panelOrderBy.Size = new System.Drawing.Size(433, 249);
            this.panelOrderBy.TabIndex = 13;
            this.panelOrderBy.Visible = false;
            // 
            // lblTitleOrderBy
            // 
            this.lblTitleOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblTitleOrderBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOrderBy.Location = new System.Drawing.Point(4, 3);
            this.lblTitleOrderBy.Name = "lblTitleOrderBy";
            this.lblTitleOrderBy.Size = new System.Drawing.Size(397, 44);
            this.lblTitleOrderBy.TabIndex = 1;
            this.lblTitleOrderBy.Tag = "orderBy";
            this.lblTitleOrderBy.Text = "Seleziona un tipo di ordinamento...";
            // 
            // TemplateView
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelAdvancedSearch);
            this.Controls.Add(this.panelOrderBy);
            this.Controls.Add(this.editCount);
            this.Controls.Add(this.imgSeparator);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.container);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.infoTitle);
            this.Size = new System.Drawing.Size(1024, 659);
            this.Load += new System.EventHandler(this.TemplateView_Load);
            this.panelCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).EndInit();
            this.panelAdvancedSearch.ResumeLayout(false);
            this.panelOrderBy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label infoTitle;
        private Library.Controls.PagingContainer container;
        public Panel panelCommands;
        public Library.Controls.ButtonSeparatorV btnAdd;
        private PictureBox imgSeparator;
        public SearchTextBox txtSearch;
        public Library.Controls.ButtonSeparatorH btnOrderBy;
        public Library.Controls.ButtonSeparatorH btnAdvancedSearch;
        public Library.Controls.ButtonSeparatorV btnRefresh;
        public Library.Controls.ButtonSeparatorV btnClose;
        private Label editCount;
        public Library.Controls.ButtonSeparatorV btnHome;
        public Panel panelAdvancedSearch;
        public Panel panelOrderBy;
        public Button btnCloseAdvancedSearch;
        public Button btnConfirmAdvancedSearch;
        public Button btnCancelAdvancedSearch;
        public Button btnCancelOrderBy;
        public Button btnCloseOrderBy;
        public Button btnConfirmOrderBy;
        public Label lblTitleAdvancedSearch;
        public Label lblTitleOrderBy;


    }
}