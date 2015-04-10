using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.MVVM
{
    partial class TemplateSchedulerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateSchedulerView));
            this.infoTitle = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands = new Gizmox.WebGUI.Forms.Panel();
            this.btnMonth = new Library.Controls.ButtonSeparatorV();
            this.btnWeek = new Library.Controls.ButtonSeparatorV();
            this.btnDay = new Library.Controls.ButtonSeparatorV();
            this.btnHome = new Library.Controls.ButtonSeparatorV();
            this.btnClose = new Library.Controls.ButtonSeparatorV();
            this.btnRefresh = new Library.Controls.ButtonSeparatorV();
            this.btnAdd = new Library.Controls.ButtonSeparatorV();
            this.txtSearch = new Gizmox.WebGUI.Forms.SearchTextBox();
            this.btnOrderBy = new Library.Controls.ButtonSeparatorH();
            this.btnAdvancedSearch = new Library.Controls.ButtonSeparatorH();
            this.imgSeparator = new Gizmox.WebGUI.Forms.PictureBox();
            this.editCount = new Gizmox.WebGUI.Forms.Label();
            this.scheduleBox = new Gizmox.WebGUI.Forms.ScheduleBox();
            this.dtDate = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).BeginInit();
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
            this.infoTitle.Size = new System.Drawing.Size(460, 39);
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
            this.panelCommands.Controls.Add(this.btnMonth);
            this.panelCommands.Controls.Add(this.btnWeek);
            this.panelCommands.Controls.Add(this.btnDay);
            this.panelCommands.Controls.Add(this.btnHome);
            this.panelCommands.Controls.Add(this.btnClose);
            this.panelCommands.Controls.Add(this.btnRefresh);
            this.panelCommands.Controls.Add(this.btnAdd);
            this.panelCommands.Location = new System.Drawing.Point(0, 0);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(101, 659);
            this.panelCommands.TabIndex = 1;
            // 
            // btnMonth
            // 
            this.btnMonth.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnMonth.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnMonth.ImageButton = "Images.add24.png";
            this.btnMonth.ImageSeparator = "Images.separator_ht_small.png";
            this.btnMonth.Location = new System.Drawing.Point(0, 360);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(101, 72);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.TextButton = "Mese";
            this.btnMonth.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnWeek.BackColor = System.Drawing.Color.Transparent;
            this.btnWeek.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnWeek.ImageButton = "Images.add24.png";
            this.btnWeek.ImageSeparator = "Images.separator_ht_small.png";
            this.btnWeek.Location = new System.Drawing.Point(0, 288);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(101, 72);
            this.btnWeek.TabIndex = 1;
            this.btnWeek.TextButton = "Settimana";
            this.btnWeek.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnWeek_Click);
            // 
            // btnDay
            // 
            this.btnDay.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnDay.BackColor = System.Drawing.Color.Transparent;
            this.btnDay.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnDay.ImageButton = "Images.add24.png";
            this.btnDay.ImageSeparator = "Images.separator_ht_small.png";
            this.btnDay.Location = new System.Drawing.Point(0, 216);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(101, 72);
            this.btnDay.TabIndex = 1;
            this.btnDay.TextButton = "Giorno";
            this.btnDay.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnDay_Click);
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
            // btnOrderBy
            // 
            this.btnOrderBy.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnOrderBy.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderBy.ImageButton = "";
            this.btnOrderBy.ImageSeparator = "Images.separator_vr.png";
            this.btnOrderBy.Location = new System.Drawing.Point(574, 39);
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
            this.btnAdvancedSearch.Location = new System.Drawing.Point(718, 39);
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
            this.editCount.Location = new System.Drawing.Point(574, 1);
            this.editCount.Name = "editCount";
            this.editCount.Size = new System.Drawing.Size(438, 17);
            this.editCount.TabIndex = 0;
            this.editCount.Text = "Voci presenti in archivio (0)";
            this.editCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scheduleBox
            // 
            this.scheduleBox.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.scheduleBox.DisplayMonthHeader = false;
            this.scheduleBox.FirstDate = new System.DateTime(2015, 4, 9, 21, 56, 39, 719);
            this.scheduleBox.FirstDayOfWeek = Gizmox.WebGUI.Forms.Day.Monday;
            this.scheduleBox.HourFormat = Gizmox.WebGUI.Forms.ScheduleBoxHourFormat.Clock12H;
            this.scheduleBox.Location = new System.Drawing.Point(101, 79);
            this.scheduleBox.Name = "scheduleBox";
            this.scheduleBox.Size = new System.Drawing.Size(923, 580);
            this.scheduleBox.TabIndex = 13;
            this.scheduleBox.View = Gizmox.WebGUI.Forms.ScheduleBoxView.Week;
            this.scheduleBox.WorkEndHour = 17;
            this.scheduleBox.WorkStartHour = 9;
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.dtDate.CustomFormat = "";
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.dtDate.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(434, 39);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(127, 25);
            this.dtDate.TabIndex = 14;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona una data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TemplateSchedulerView
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.scheduleBox);
            this.Controls.Add(this.editCount);
            this.Controls.Add(this.imgSeparator);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.infoTitle);
            this.Size = new System.Drawing.Size(1024, 659);
            this.Load += new System.EventHandler(this.TemplateSchedulerView_Load);
            this.panelCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label infoTitle;
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
        private ScheduleBox scheduleBox;
        public Library.Controls.ButtonSeparatorV btnMonth;
        public Library.Controls.ButtonSeparatorV btnWeek;
        public Library.Controls.ButtonSeparatorV btnDay;
        private DateTimePicker dtDate;
        private Label label1;


    }
}