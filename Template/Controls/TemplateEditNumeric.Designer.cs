using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditNumeric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditNumeric));
            this.editLabel = new Gizmox.WebGUI.Forms.Label();
            this.imgEdit = new Gizmox.WebGUI.Forms.PictureBox();
            this.editValue = new Gizmox.WebGUI.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editValue)).BeginInit();
            this.SuspendLayout();
            // 
            // editLabel
            // 
            this.editLabel.BackColor = System.Drawing.Color.Transparent;
            this.editLabel.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.Gray;
            this.editLabel.Location = new System.Drawing.Point(0, 0);
            this.editLabel.MinimumSize = new System.Drawing.Size(108, 26);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(119, 26);
            this.editLabel.TabIndex = 0;
            this.editLabel.Text = "Label";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgEdit
            // 
            this.imgEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgEdit.BackColor = System.Drawing.Color.Transparent;
            this.imgEdit.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgEdit.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgEdit.Image"));
            this.imgEdit.Location = new System.Drawing.Point(457, 0);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(24, 24);
            this.imgEdit.TabIndex = 2;
            this.imgEdit.TabStop = false;
            // 
            // editValue
            // 
            this.editValue.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editValue.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editValue.BackColor = System.Drawing.Color.Transparent;
            this.editValue.CurrentValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.editValue.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.editValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.editValue.Location = new System.Drawing.Point(122, 0);
            this.editValue.Name = "editValue";
            this.editValue.Size = new System.Drawing.Size(332, 33);
            this.editValue.TabIndex = 3;
            // 
            // TemplateEditNumeric
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.Controls.Add(this.editValue);
            this.Controls.Add(this.imgEdit);
            this.Controls.Add(this.editLabel);
            this.Size = new System.Drawing.Size(481, 30);
            this.Text = "EditControl";
            this.Load += new System.EventHandler(this.TemplateEditText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label editLabel;
        public PictureBox imgEdit;
        private NumericUpDown editValue;



    }
}