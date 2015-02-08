using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class DateCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateCalendar));
            this.editDay = new Gizmox.WebGUI.Forms.TextBox();
            this.editMonth = new Gizmox.WebGUI.Forms.TextBox();
            this.editYear = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSeparator1 = new Gizmox.WebGUI.Forms.Label();
            this.lblSeparator2 = new Gizmox.WebGUI.Forms.Label();
            this.btnCalendar = new Gizmox.WebGUI.Forms.Button();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.SuspendLayout();
            // 
            // editDay
            // 
            this.editDay.BackColor = System.Drawing.Color.Transparent;
            this.editDay.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editDay.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editDay.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.editDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editDay.Location = new System.Drawing.Point(0, 0);
            this.editDay.MaxLength = 2;
            this.editDay.Name = "editDay";
            this.editDay.Size = new System.Drawing.Size(31, 29);
            this.editDay.TabIndex = 0;
            this.editDay.TextAlign = Gizmox.WebGUI.Forms.HorizontalAlignment.Center;
            // 
            // editMonth
            // 
            this.editMonth.BackColor = System.Drawing.Color.Transparent;
            this.editMonth.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editMonth.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editMonth.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.editMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editMonth.Location = new System.Drawing.Point(54, 0);
            this.editMonth.MaxLength = 2;
            this.editMonth.Name = "editMonth";
            this.editMonth.Size = new System.Drawing.Size(31, 29);
            this.editMonth.TabIndex = 1;
            // 
            // editYear
            // 
            this.editYear.BackColor = System.Drawing.Color.Transparent;
            this.editYear.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editYear.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editYear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.editYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editYear.Location = new System.Drawing.Point(107, 0);
            this.editYear.MaxLength = 4;
            this.editYear.Name = "editYear";
            this.editYear.Size = new System.Drawing.Size(46, 29);
            this.editYear.TabIndex = 2;
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparator1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblSeparator1.Location = new System.Drawing.Point(34, 0);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(17, 29);
            this.lblSeparator1.TabIndex = 999;
            this.lblSeparator1.Text = "/";
            this.lblSeparator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparator2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblSeparator2.Location = new System.Drawing.Point(88, 0);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(16, 29);
            this.lblSeparator2.TabIndex = 999;
            this.lblSeparator2.Text = "/";
            this.lblSeparator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCalendar.BackgroundImage"));
            this.btnCalendar.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCalendar.CustomStyle = "F";
            this.btnCalendar.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCalendar.Location = new System.Drawing.Point(160, 2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(24, 23);
            this.btnCalendar.TabIndex = 999;
            this.btnCalendar.TabStop = false;
            this.toolTip.SetToolTip(this.btnCalendar, "Fai clic per selezionare una data dal calendario...");
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // DateCalendar
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editMonth);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.editDay);
            this.Controls.Add(this.lblSeparator2);
            this.Controls.Add(this.editYear);
            this.Controls.Add(this.lblSeparator1);
            this.Size = new System.Drawing.Size(192, 30);
            this.Text = "TemplateEditData";
            this.Load += new System.EventHandler(this.EditDateCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Gizmox.WebGUI.Forms.TextBox editDay;
        public Gizmox.WebGUI.Forms.TextBox editMonth;
        public Gizmox.WebGUI.Forms.TextBox editYear;
        public Label lblSeparator1;
        public Label lblSeparator2;
        public Button btnCalendar;
        private ToolTip toolTip;



    }
}