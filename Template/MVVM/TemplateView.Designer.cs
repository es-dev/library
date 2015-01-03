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
            this.btnClose = new Library.Controls.ButtonSeparatorV();
            this.btnRefresh = new Library.Controls.ButtonSeparatorV();
            this.btnAdd = new Library.Controls.ButtonSeparatorV();
            this.txtSearch = new Gizmox.WebGUI.Forms.SearchTextBox();
            this.container = new Library.Controls.PagingContainer();
            this.btnOrderBy = new Library.Controls.ButtonSeparatorH();
            this.btnAdvancedSearch = new Library.Controls.ButtonSeparatorH();
            this.imgSeparator = new Gizmox.WebGUI.Forms.PictureBox();
            this.editCount = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTitle
            // 
            this.infoTitle.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.infoTitle.Location = new System.Drawing.Point(101, 0);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(473, 47);
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
            this.panelCommands.Controls.Add(this.btnClose);
            this.panelCommands.Controls.Add(this.btnRefresh);
            this.panelCommands.Controls.Add(this.btnAdd);
            this.panelCommands.Location = new System.Drawing.Point(0, 68);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(101, 591);
            this.panelCommands.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnClose.ImageButton = "Images.left24.png";
            this.btnClose.ImageSeparator = "Images.separator_ht_small.png";
            this.btnClose.Location = new System.Drawing.Point(0, 0);
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
            this.btnRefresh.Location = new System.Drawing.Point(0, 519);
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
            this.btnAdd.Location = new System.Drawing.Point(0, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 72);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TextButton = "Nuovo";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Silver);
            this.txtSearch.CustomStyle = "STB";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.Location = new System.Drawing.Point(872, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 25);
            this.txtSearch.TabIndex = 0;
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
            this.btnOrderBy.Location = new System.Drawing.Point(574, 2);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(144, 27);
            this.btnOrderBy.TabIndex = 9;
            this.btnOrderBy.TextButton = "Ordina per...";
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnAdvancedSearch.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvancedSearch.ImageButton = "";
            this.btnAdvancedSearch.ImageSeparator = "Images.separator_vr.png";
            this.btnAdvancedSearch.Location = new System.Drawing.Point(718, 2);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(151, 27);
            this.btnAdvancedSearch.TabIndex = 10;
            this.btnAdvancedSearch.TextButton = "Ricerca avanzata...";
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
            this.editCount.Location = new System.Drawing.Point(574, 38);
            this.editCount.Name = "editCount";
            this.editCount.Size = new System.Drawing.Size(438, 17);
            this.editCount.TabIndex = 0;
            this.editCount.Text = "Voci presenti in archivio (0)";
            this.editCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TemplateView
            // 
            this.BackColor = System.Drawing.Color.Transparent;
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


    }
}