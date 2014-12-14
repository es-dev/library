using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditOra
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
            this.editControl = new Library.Controls.TimeIntervals();
            this.SuspendLayout();
            // 
            // editControl
            // 
            this.editControl.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editControl.BackColor = System.Drawing.Color.Transparent;
            this.editControl.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editControl.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editControl.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editControl.EndInterval = System.TimeSpan.Parse("21:00:00");
            this.editControl.Interval = System.TimeSpan.Parse("00:15:00");
            this.editControl.Location = new System.Drawing.Point(100, 1);
            this.editControl.Name = "editControl";
            this.editControl.Size = new System.Drawing.Size(137, 32);
            this.editControl.StartInterval = System.TimeSpan.Parse("07:00:00");
            this.editControl.TabIndex = 3;
            this.editControl.Text = "TemplateEditTimeInterval";
            this.editControl.Value = null;
            // 
            // TemplateEditOra
            // 
            this.Controls.Add(this.editControl);
            this.Size = new System.Drawing.Size(481, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Controls.TimeIntervals editControl;



    }
}