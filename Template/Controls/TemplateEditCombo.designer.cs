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
            this.btnCombo = new Gizmox.WebGUI.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // editValue
            // 
            this.editValue.Click += new System.EventHandler(this.showCombo_Click);
            // 
            // imgEdit
            // 
            this.imgEdit.Location = new System.Drawing.Point(490, 0);
            // 
            // btnCombo
            // 
            this.btnCombo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCombo.CustomStyle = "F";
            this.btnCombo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(457, 1);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(28, 28);
            this.btnCombo.TabIndex = 2;
            this.btnCombo.Text = "...";
            this.btnCombo.Click += new System.EventHandler(this.showCombo_Click);
            // 
            // TemplateEditCombo
            // 
            this.Controls.Add(this.btnCombo);
            this.Size = new System.Drawing.Size(514, 30);
            this.Controls.SetChildIndex(this.imgEdit, 0);
            this.Controls.SetChildIndex(this.editLabel, 0);
            this.Controls.SetChildIndex(this.editValue, 0);
            this.Controls.SetChildIndex(this.btnCombo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Button btnCombo;
	}
}
