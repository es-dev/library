using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class PopupBase
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
            this.panelMessage = new Gizmox.WebGUI.Forms.Panel();
            this.btnCancel = new Library.Controls.ButtonSeparatorV();
            this.btnConfirm = new Library.Controls.ButtonSeparatorV();
            this.jqContainer = new Library.Controls.JQContainer();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.btnCancel);
            this.panelMessage.Controls.Add(this.btnConfirm);
            this.panelMessage.DockPadding.Left = 50;
            this.panelMessage.DockPadding.Right = 50;
            this.panelMessage.Location = new System.Drawing.Point(0, 216);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Padding = new Gizmox.WebGUI.Forms.Padding(50, 0, 50, 0);
            this.panelMessage.Size = new System.Drawing.Size(1024, 300);
            this.panelMessage.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Bottom;
            this.btnCancel.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageButton = null;
            this.btnCancel.ImageSeparator = "Image.separator_ht_small.png";
            this.btnCancel.Location = new System.Drawing.Point(744, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 72);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TextButton = "Annulla";
            this.btnCancel.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Bottom;
            this.btnConfirm.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ImageButton = null;
            this.btnConfirm.ImageSeparator = "Image.separator_ht_small.png";
            this.btnConfirm.Location = new System.Drawing.Point(845, 218);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 72);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.TextButton = "OK";
            this.btnConfirm.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnConfirm_Click);
            // 
            // jqContainer
            // 
            this.jqContainer.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.jqContainer.BackColor = System.Drawing.Color.Transparent;
            this.jqContainer.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.SteelBlue);
            this.jqContainer.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.jqContainer.JQBackColor = System.Drawing.Color.DimGray;
            this.jqContainer.JQOpacity = 0.5D;
            this.jqContainer.Location = new System.Drawing.Point(0, 0);
            this.jqContainer.Name = "jqContainer";
            this.jqContainer.Size = new System.Drawing.Size(1024, 768);
            this.jqContainer.TabIndex = 1;
            // 
            // PopupBase
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.jqContainer);
            this.Size = new System.Drawing.Size(1024, 768);
            this.Text = "TemplaMessage";
            this.Load += new System.EventHandler(this.PopupBaseControl_Load);
            this.panelMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public JQContainer jqContainer;
        public ButtonSeparatorV btnConfirm;
        public ButtonSeparatorV btnCancel;
        public Panel panelMessage;



    }
}