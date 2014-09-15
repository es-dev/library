using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.Controls
{
    partial class TemplateEditCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditCheckBox));
            this.editLabel = new Gizmox.WebGUI.Forms.Label();
            this.panelCheck = new Gizmox.WebGUI.Forms.Panel();
            this.editFalse = new Gizmox.WebGUI.Forms.CheckBox();
            this.editTrue = new Gizmox.WebGUI.Forms.CheckBox();
            this.imgEdit = new Gizmox.WebGUI.Forms.PictureBox();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
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
            this.editLabel.Size = new System.Drawing.Size(119, 30);
            this.editLabel.TabIndex = 0;
            this.editLabel.Text = "Label";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCheck
            // 
            this.panelCheck.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelCheck.BackColor = System.Drawing.Color.Transparent;
            this.panelCheck.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.panelCheck.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.panelCheck.Controls.Add(this.editFalse);
            this.panelCheck.Controls.Add(this.editTrue);
            this.panelCheck.Location = new System.Drawing.Point(119, 0);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(225, 30);
            this.panelCheck.TabIndex = 2;
            this.panelCheck.Click += new System.EventHandler(this.editTrue_Click);
            // 
            // editFalse
            // 
            this.editFalse.Appearance = Gizmox.WebGUI.Forms.Appearance.Button;
            this.editFalse.BackColor = System.Drawing.Color.White;
            this.editFalse.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.editFalse.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editFalse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFalse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editFalse.Location = new System.Drawing.Point(108, 0);
            this.editFalse.Name = "editFalse";
            this.editFalse.Padding = new Gizmox.WebGUI.Forms.Padding(2, 0, 0, 0);
            this.editFalse.Size = new System.Drawing.Size(117, 30);
            this.editFalse.TabIndex = 3;
            this.editFalse.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.editFalse.Click += new System.EventHandler(this.editFalse_Click);
            // 
            // editTrue
            // 
            this.editTrue.Appearance = Gizmox.WebGUI.Forms.Appearance.Button;
            this.editTrue.BackColor = System.Drawing.Color.White;
            this.editTrue.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.editTrue.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editTrue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTrue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editTrue.Location = new System.Drawing.Point(0, 0);
            this.editTrue.Name = "editTrue";
            this.editTrue.Padding = new Gizmox.WebGUI.Forms.Padding(2, 0, 0, 0);
            this.editTrue.Size = new System.Drawing.Size(104, 30);
            this.editTrue.TabIndex = 3;
            this.editTrue.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.editTrue.Click += new System.EventHandler(this.editTrue_Click);
            // 
            // imgEdit
            // 
            this.imgEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgEdit.BackColor = System.Drawing.Color.Transparent;
            this.imgEdit.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgEdit.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgEdit.Image"));
            this.imgEdit.Location = new System.Drawing.Point(345, 0);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(24, 24);
            this.imgEdit.TabIndex = 2;
            this.imgEdit.TabStop = false;
            // 
            // TemplateEditCheckBox
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.Controls.Add(this.imgEdit);
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.editLabel);
            this.Size = new System.Drawing.Size(369, 30);
            this.Text = "TemplateCheckBox";
            this.Load += new System.EventHandler(this.TemplateEditCheckBox_Load);
            this.panelCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label editLabel;
        private Panel panelCheck;
        private CheckBox editTrue;
        private CheckBox editFalse;
        public PictureBox imgEdit;


    }
}