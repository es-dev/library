using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class EditData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditData));
            this.editDay = new Gizmox.WebGUI.Forms.TextBox();
            this.editMonth = new Gizmox.WebGUI.Forms.TextBox();
            this.editYear = new Gizmox.WebGUI.Forms.TextBox();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.btnCalendar = new Gizmox.WebGUI.Forms.Button();
            this.panelDate = new Gizmox.WebGUI.Forms.Panel();
            this.panelDate.SuspendLayout();
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
            this.editMonth.Location = new System.Drawing.Point(53, 0);
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
            this.editYear.Location = new System.Drawing.Point(108, 0);
            this.editYear.MaxLength = 4;
            this.editYear.Name = "editYear";
            this.editYear.Size = new System.Drawing.Size(46, 29);
            this.editYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(35, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(89, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "/";
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCalendar.BackgroundImage"));
            this.btnCalendar.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCalendar.CustomStyle = "F";
            this.btnCalendar.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCalendar.Location = new System.Drawing.Point(158, 1);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(24, 23);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // panelDate
            // 
            this.panelDate.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.panelDate.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.panelDate.Controls.Add(this.btnCalendar);
            this.panelDate.Controls.Add(this.editDay);
            this.panelDate.Controls.Add(this.label5);
            this.panelDate.Controls.Add(this.editMonth);
            this.panelDate.Controls.Add(this.label4);
            this.panelDate.Controls.Add(this.editYear);
            this.panelDate.Location = new System.Drawing.Point(0, 0);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(185, 30);
            this.panelDate.TabIndex = 6;
            // 
            // EditData
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelDate);
            this.Size = new System.Drawing.Size(185, 30);
            this.Text = "TemplateEditData";
            this.Load += new System.EventHandler(this.EditData_Load);
            this.panelDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TextBox editDay;
        public TextBox editMonth;
        public TextBox editYear;
        public Label label4;
        public Label label5;
        public Button btnCalendar;
        public Panel panelDate;



    }
}