using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.monthCalendar = new Gizmox.WebGUI.Forms.MonthCalendar();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnConfirm = new Gizmox.WebGUI.Forms.Button();
            this.btnGoToday = new Gizmox.WebGUI.Forms.Button();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.monthCalendar.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.monthCalendar.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionEnd = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            this.monthCalendar.SelectionRange = new Gizmox.WebGUI.Forms.SelectionRange(new System.DateTime(2014, 7, 25, 0, 0, 0, 0), new System.DateTime(2014, 7, 25, 0, 0, 0, 0));
            this.monthCalendar.SelectionStart = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            this.monthCalendar.Size = new System.Drawing.Size(227, 162);
            this.monthCalendar.TabIndex = 999;
            this.monthCalendar.TodayDate = new System.DateTime(2014, 12, 7, 0, 0, 0, 0);
            this.monthCalendar.Value = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancel.BackgroundImage"));
            this.btnCancel.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCancel.CustomStyle = "F";
            this.btnCancel.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(173, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.TabIndex = 999;
            this.toolTip.SetToolTip(this.btnCancel, "Annulla");
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirm.BackgroundImage"));
            this.btnConfirm.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnConfirm.CustomStyle = "F";
            this.btnConfirm.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(200, 165);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(24, 24);
            this.btnConfirm.TabIndex = 999;
            this.toolTip.SetToolTip(this.btnConfirm, "Conferma");
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnGoToday
            // 
            this.btnGoToday.CustomStyle = "F";
            this.btnGoToday.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnGoToday.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToday.Location = new System.Drawing.Point(0, 165);
            this.btnGoToday.Name = "btnGoToday";
            this.btnGoToday.Size = new System.Drawing.Size(76, 24);
            this.btnGoToday.TabIndex = 1000;
            this.btnGoToday.Text = "Vai ad oggi";
            this.btnGoToday.Click += new System.EventHandler(this.btnGoToday_Click);
            // 
            // Calendar
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.DimGray);
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnGoToday);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.monthCalendar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.Size = new System.Drawing.Size(229, 195);
            this.Text = "EditCalendar";
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button btnCancel;
        private Button btnConfirm;
        private Button btnGoToday;
        private ToolTip toolTip;


    }
}