using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class DateAndTime
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
            this.editDate = new Library.Controls.DateCalendar();
            this.editTime = new Library.Controls.TimeIntervals();
            this.SuspendLayout();
            // 
            // editDate
            // 
            this.editDate.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDate.BackColor = System.Drawing.Color.Transparent;
            this.editDate.Location = new System.Drawing.Point(0, 0);
            this.editDate.Mask = "--";
            this.editDate.Name = "editDate";
            this.editDate.ReadOnly = false;
            this.editDate.Size = new System.Drawing.Size(192, 30);
            this.editDate.TabIndex = 0;
            this.editDate.Text = "//";
            this.editDate.Value = null;
            // 
            // editTime
            // 
            this.editTime.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTime.BackColor = System.Drawing.Color.Transparent;
            this.editTime.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTime.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTime.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTime.EndInterval = System.TimeSpan.Parse("21:00:00");
            this.editTime.Interval = System.TimeSpan.Parse("00:15:00");
            this.editTime.Location = new System.Drawing.Point(192, -2);
            this.editTime.Mask = "--";
            this.editTime.Name = "editTime";
            this.editTime.ReadOnly = false;
            this.editTime.Size = new System.Drawing.Size(137, 32);
            this.editTime.StartInterval = System.TimeSpan.Parse("07:00:00");
            this.editTime.TabIndex = 1;
            this.editTime.Text = ":";
            this.editTime.Value = null;
            // 
            // DateAndTime
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editTime);
            this.Controls.Add(this.editDate);
            this.Size = new System.Drawing.Size(347, 30);
            this.Text = "DateAndTime";
            this.ResumeLayout(false);

        }

        #endregion

        private DateCalendar editDate;
        private TimeIntervals editTime;


    }
}