using System.Drawing;

namespace Library.Template.Controls
{
	partial class TemplateEditCombo
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.editControl = new Library.Controls.TextCombo();
            this.SuspendLayout();
            // 
            // editControl
            // 
            this.editControl.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editControl.BackColor = System.Drawing.Color.Transparent;
            this.editControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl.Location = new System.Drawing.Point(100, 0);
            this.editControl.Mask = "---";
            this.editControl.Name = "editControl";
            this.editControl.ReadOnly = false;
            this.editControl.Size = new System.Drawing.Size(357, 30);
            this.editControl.TabIndex = 3;
            this.editControl.Text = null;
            this.editControl.Value = null;
            // 
            // TemplateEditCombo
            // 
            this.Controls.Add(this.editControl);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Controls.TextCombo editControl;


    }
}
