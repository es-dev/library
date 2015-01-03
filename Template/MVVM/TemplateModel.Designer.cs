using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.MVVM
{
    partial class TemplateModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateModel));
            this.container = new Gizmox.WebGUI.Forms.Panel();
            this.lblEditing = new Gizmox.WebGUI.Forms.Label();
            this.infoSubtitle = new Gizmox.WebGUI.Forms.Label();
            this.infoSubtitleImage = new Gizmox.WebGUI.Forms.PictureBox();
            this.infoTitle = new Gizmox.WebGUI.Forms.Label();
            this.panelCommands = new Gizmox.WebGUI.Forms.Panel();
            this.btnDelete = new Library.Controls.ButtonSeparatorV();
            this.btnUpdateCancel = new Library.Controls.ButtonSeparatorV();
            this.btnSave = new Library.Controls.ButtonSeparatorV();
            this.btnClose = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.container.AutoScroll = true;
            this.container.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Gainsboro);
            this.container.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.container.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 1, 0, 0);
            this.container.Controls.Add(this.lblEditing);
            this.container.Controls.Add(this.infoSubtitle);
            this.container.Controls.Add(this.infoSubtitleImage);
            this.container.Location = new System.Drawing.Point(101, 47);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(923, 612);
            this.container.TabIndex = 6;
            // 
            // lblEditing
            // 
            this.lblEditing.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblEditing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditing.ForeColor = System.Drawing.Color.White;
            this.lblEditing.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("lblEditing.Image"));
            this.lblEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditing.Location = new System.Drawing.Point(354, 3);
            this.lblEditing.Name = "lblEditing";
            this.lblEditing.Size = new System.Drawing.Size(248, 27);
            this.lblEditing.TabIndex = 999;
            this.lblEditing.Text = "     MODIFICA ABILITATA";
            this.lblEditing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditing.Visible = false;
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.infoSubtitle.Location = new System.Drawing.Point(668, 3);
            this.infoSubtitle.Name = "infoSubtitle";
            this.infoSubtitle.Size = new System.Drawing.Size(250, 55);
            this.infoSubtitle.TabIndex = 999;
            this.infoSubtitle.Text = "SUBTITLE";
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoSubtitleImage.BackColor = System.Drawing.Color.Transparent;
            this.infoSubtitleImage.Location = new System.Drawing.Point(612, 3);
            this.infoSubtitleImage.Name = "infoSubtitleImage";
            this.infoSubtitleImage.Size = new System.Drawing.Size(48, 48);
            this.infoSubtitleImage.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.infoSubtitleImage.TabIndex = 1;
            this.infoSubtitleImage.TabStop = false;
            // 
            // infoTitle
            // 
            this.infoTitle.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.infoTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.infoTitle.Location = new System.Drawing.Point(101, 0);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(923, 47);
            this.infoTitle.TabIndex = 4;
            this.infoTitle.Text = "TITLE";
            // 
            // panelCommands
            // 
            this.panelCommands.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.panelCommands.BackColor = System.Drawing.Color.Transparent;
            this.panelCommands.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("panelCommands.BackgroundImage"));
            this.panelCommands.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.panelCommands.Controls.Add(this.btnDelete);
            this.panelCommands.Controls.Add(this.btnUpdateCancel);
            this.panelCommands.Controls.Add(this.btnSave);
            this.panelCommands.Controls.Add(this.btnClose);
            this.panelCommands.Location = new System.Drawing.Point(0, 68);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(101, 591);
            this.panelCommands.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.btnDelete.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnDelete.ImageButton = "Images.delete24.png";
            this.btnDelete.ImageSeparator = "Images.separator_ht_small.png";
            this.btnDelete.Location = new System.Drawing.Point(0, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 72);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TextButton = "Elimina";
            this.btnDelete.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnDelete_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnUpdateCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCancel.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnUpdateCancel.ImageButton = "Images.edit24.png";
            this.btnUpdateCancel.ImageSeparator = "Images.separator_ht_small.png";
            this.btnUpdateCancel.Location = new System.Drawing.Point(0, 145);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(101, 72);
            this.btnUpdateCancel.TabIndex = 1;
            this.btnUpdateCancel.TextButton = "Modifica";
            this.btnUpdateCancel.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnUpdateCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnSave.ImageButton = "Images.save24.png";
            this.btnSave.ImageSeparator = "Images.separator_ht_small.png";
            this.btnSave.Location = new System.Drawing.Point(0, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 72);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextButton = "Salva";
            this.btnSave.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnClose.ImageButton = "Images.left24.png";
            this.btnClose.ImageSeparator = "Images.separator_ht_small.png";
            this.btnClose.Location = new System.Drawing.Point(0, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 72);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextButton = "Chiudi";
            this.btnClose.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnClose_Click);
            // 
            // TemplateModel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.infoTitle);
            this.Controls.Add(this.container);
            this.Size = new System.Drawing.Size(1024, 659);
            this.Load += new System.EventHandler(this.TemplateModel_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label infoTitle;
        private Panel panelCommands;
        private Library.Controls.ButtonSeparatorV btnClose;
        private Library.Controls.ButtonSeparatorV btnDelete;
        private Library.Controls.ButtonSeparatorV btnUpdateCancel;
        private Library.Controls.ButtonSeparatorV btnSave;
        public Panel container;
        public Label infoSubtitle;
        public PictureBox infoSubtitleImage;
        private Label lblEditing;



    }
}