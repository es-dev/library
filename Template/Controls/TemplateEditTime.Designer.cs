using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditTime
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
            // editLabel
            // 
            this.editLabel.TabIndex = 999;
            // 
            // editControl
            // 
            this.editControl.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editControl.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editControl.BackColor = System.Drawing.Color.Transparent;
            this.editControl.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editControl.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editControl.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editControl.EndInterval = System.TimeSpan.Parse("21:00:00");
            this.editControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl.Interval = System.TimeSpan.Parse("00:15:00");
            this.editControl.Location = new System.Drawing.Point(100, 0);
            this.editControl.Mask = "--";
            this.editControl.Name = "editControl";
            this.editControl.ReadOnly = false;
            this.editControl.Size = new System.Drawing.Size(350, 30);
            this.editControl.StartInterval = System.TimeSpan.Parse("07:00:00");
            this.editControl.TabIndex = 0;
            this.editControl.Text = null;
            this.editControl.Value = null;
            // 
            // TemplateEditTime
            // 
            this.Controls.Add(this.editControl);
            this.Size = new System.Drawing.Size(481, 32);
            this.Text = "";
            this.Controls.SetChildIndex(this.editControl, 0);
            this.Controls.SetChildIndex(this.editLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Controls.TimeIntervals editControl;



    }
}