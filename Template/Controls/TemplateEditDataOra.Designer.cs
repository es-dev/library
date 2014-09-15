using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditDataOra
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
            this.editData = new Library.Template.Controls.TemplateEditData();
            this.editOra = new Library.Template.Controls.TemplateEditOra();
            this.editLabel = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // editData
            // 
            this.editData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editData.BackColor = System.Drawing.Color.Transparent;
            this.editData.Changed = false;
            this.editData.Editing = false;
            this.editData.Label = "Data";
            this.editData.LabelWidth = 108;
            this.editData.Location = new System.Drawing.Point(182, 0);
            this.editData.Name = "templateEditData1";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(329, 30);
            this.editData.TabIndex = 0;
            this.editData.Text = "TemplateEditData";
            this.editData.Value = null;
            // 
            // editOra
            // 
            this.editOra.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editOra.BackColor = System.Drawing.Color.Transparent;
            this.editOra.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editOra.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editOra.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editOra.Changed = false;
            this.editOra.Editing = false;
            this.editOra.Interval = System.TimeSpan.Parse("00:10:00");
            this.editOra.Label = "Ora";
            this.editOra.LabelWidth = 108;
            this.editOra.Location = new System.Drawing.Point(511, 0);
            this.editOra.Name = "templateEditOra1";
            this.editOra.ReadOnly = false;
            this.editOra.Required = false;
            this.editOra.Size = new System.Drawing.Size(289, 30);
            this.editOra.TabIndex = 1;
            this.editOra.Text = "TemplateEditOra";
            this.editOra.Value = null;
            // 
            // editLabel
            // 
            this.editLabel.BackColor = System.Drawing.Color.Transparent;
            this.editLabel.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.Gray;
            this.editLabel.Location = new System.Drawing.Point(-4, 0);
            this.editLabel.MinimumSize = new System.Drawing.Size(108, 26);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(186, 30);
            this.editLabel.TabIndex = 0;
            this.editLabel.Text = "Data e Ora";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TemplateEditDataOra
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.editOra);
            this.Controls.Add(this.editData);
            this.Size = new System.Drawing.Size(800, 30);
            this.Text = "TemplateEditDataOra";
            this.ResumeLayout(false);

        }

        #endregion

        private TemplateEditData editData;
        private TemplateEditOra editOra;
        public Label editLabel;


    }
}