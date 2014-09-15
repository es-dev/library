using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class EditCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCalendar));
            this.monthCalendar = new Gizmox.WebGUI.Forms.MonthCalendar();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnConfirm = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionEnd = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            this.monthCalendar.SelectionRange = new Gizmox.WebGUI.Forms.SelectionRange(new System.DateTime(2014, 7, 25, 0, 0, 0, 0), new System.DateTime(2014, 7, 25, 0, 0, 0, 0));
            this.monthCalendar.SelectionStart = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            this.monthCalendar.Size = new System.Drawing.Size(227, 162);
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Value = new System.DateTime(2014, 7, 25, 9, 39, 33, 811);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancel.BackgroundImage"));
            this.btnCancel.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCancel.CustomStyle = "F";
            this.btnCancel.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(175, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirm.BackgroundImage"));
            this.btnConfirm.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnConfirm.CustomStyle = "F";
            this.btnConfirm.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(202, 165);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(24, 25);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // EditCalendar
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.monthCalendar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.Size = new System.Drawing.Size(227, 190);
            this.Text = "EditCalendar";
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button btnCancel;
        private Button btnConfirm;


    }
}