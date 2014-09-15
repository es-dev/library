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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditOra));
            this.editHour = new Gizmox.WebGUI.Forms.TextBox();
            this.editMinutes = new Gizmox.WebGUI.Forms.TextBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.editLabel = new Gizmox.WebGUI.Forms.Label();
            this.panelTime = new Gizmox.WebGUI.Forms.Panel();
            this.imgUP = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgDown = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgEdit = new Gizmox.WebGUI.Forms.PictureBox();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
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
            this.editHour.Location = new System.Drawing.Point(1, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(46, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
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
            this.editLabel.Text = "Ora";
            this.editLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTime
            // 
            this.panelTime.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelTime.BackColor = System.Drawing.Color.Transparent;
            this.panelTime.Controls.Add(this.imgUP);
            this.panelTime.Controls.Add(this.imgDown);
            this.panelTime.Controls.Add(this.editHour);
            this.panelTime.Controls.Add(this.editMinutes);
            this.panelTime.Controls.Add(this.label1);
            this.panelTime.Location = new System.Drawing.Point(121, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(143, 32);
            this.panelTime.TabIndex = 2;
            // 
            // imgUP
            // 
            this.imgUP.BackColor = System.Drawing.Color.Transparent;
            this.imgUP.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgUP.BackgroundImage"));
            this.imgUP.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.imgUP.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgUP.Location = new System.Drawing.Point(115, 1);
            this.imgUP.Name = "imgUP";
            this.imgUP.Size = new System.Drawing.Size(24, 13);
            this.imgUP.TabIndex = 3;
            this.imgUP.TabStop = false;
            this.imgUP.Click += new System.EventHandler(this.imgUP_Click);
            // 
            // imgDown
            // 
            this.imgDown.BackColor = System.Drawing.Color.Transparent;
            this.imgDown.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgDown.BackgroundImage"));
            this.imgDown.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.imgDown.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgDown.Location = new System.Drawing.Point(115, 16);
            this.imgDown.Name = "imgDown";
            this.imgDown.Size = new System.Drawing.Size(24, 13);
            this.imgDown.TabIndex = 3;
            this.imgDown.TabStop = false;
            this.imgDown.Click += new System.EventHandler(this.imgDown_Click);
            // 
            // imgEdit
            // 
            this.imgEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgEdit.BackColor = System.Drawing.Color.Transparent;
            this.imgEdit.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.imgEdit.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgEdit.Image"));
            this.imgEdit.Location = new System.Drawing.Point(265, 0);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(24, 24);
            this.imgEdit.TabIndex = 2;
            this.imgEdit.TabStop = false;
            // 
            // TemplateEditOra
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.Controls.Add(this.imgEdit);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.editLabel);
            this.Size = new System.Drawing.Size(289, 32);
            this.Text = "TemplateEditOra";
            this.Load += new System.EventHandler(this.TemplateEditOra_Load);
            this.Leave += new System.EventHandler(this.editValue_Leave);
            this.panelTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox editHour;
        private TextBox editMinutes;
        private Label label1;
        public Label editLabel;
        private Panel panelTime;
        private PictureBox imgUP;
        private PictureBox imgDown;
        public PictureBox imgEdit;


    }
}