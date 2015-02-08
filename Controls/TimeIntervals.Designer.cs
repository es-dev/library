using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TimeIntervals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeIntervals));
            this.editHour = new Gizmox.WebGUI.Forms.TextBox();
            this.editMinutes = new Gizmox.WebGUI.Forms.TextBox();
            this.lblSeparator = new Gizmox.WebGUI.Forms.Label();
            this.panelTime = new Gizmox.WebGUI.Forms.Panel();
            this.btnIntervals = new Gizmox.WebGUI.Forms.Button();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // editHour
            // 
            this.editHour.BackColor = System.Drawing.Color.Transparent;
            this.editHour.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.editHour.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editHour.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editHour.Location = new System.Drawing.Point(0, 0);
            this.editHour.MaxLength = 2;
            this.editHour.Name = "editHour";
            this.editHour.Size = new System.Drawing.Size(40, 30);
            this.editHour.TabIndex = 0;
            // 
            // editMinutes
            // 
            this.editMinutes.BackColor = System.Drawing.Color.Transparent;
            this.editMinutes.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.editMinutes.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editMinutes.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editMinutes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editMinutes.Location = new System.Drawing.Point(63, 0);
            this.editMinutes.MaxLength = 2;
            this.editMinutes.Name = "editMinutes";
            this.editMinutes.Size = new System.Drawing.Size(40, 30);
            this.editMinutes.TabIndex = 1;
            // 
            // lblSeparator
            // 
            this.lblSeparator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSeparator.Location = new System.Drawing.Point(44, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(16, 30);
            this.lblSeparator.TabIndex = 999;
            this.lblSeparator.Text = ":";
            this.lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Transparent;
            this.panelTime.Controls.Add(this.btnIntervals);
            this.panelTime.Controls.Add(this.editHour);
            this.panelTime.Controls.Add(this.editMinutes);
            this.panelTime.Controls.Add(this.lblSeparator);
            this.panelTime.Location = new System.Drawing.Point(0, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(138, 32);
            this.panelTime.TabIndex = 2;
            // 
            // btnIntervals
            // 
            this.btnIntervals.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnIntervals.BackgroundImage"));
            this.btnIntervals.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnIntervals.CustomStyle = "F";
            this.btnIntervals.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnIntervals.Location = new System.Drawing.Point(112, 4);
            this.btnIntervals.Name = "btnIntervals";
            this.btnIntervals.Size = new System.Drawing.Size(24, 24);
            this.btnIntervals.TabIndex = 999;
            this.btnIntervals.Click += new System.EventHandler(this.btnIntervals_Click);
            // 
            // TimeIntervals
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.Controls.Add(this.panelTime);
            this.Size = new System.Drawing.Size(137, 32);
            this.Text = "TemplateEditTimeInterval";
            this.Load += new System.EventHandler(this.EditTimeIntervals_Load);
            this.panelTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSeparator;
        public Panel panelTime;
        public Gizmox.WebGUI.Forms.TextBox editHour;
        public Gizmox.WebGUI.Forms.TextBox editMinutes;
        public Button btnIntervals;


    }
}