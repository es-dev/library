using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextProgress
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
            this.editText = new Gizmox.WebGUI.Forms.TextBox();
            this.editProgressBar = new Gizmox.WebGUI.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.editText.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editText.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(0, 0);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(93, 30);
            this.editText.TabIndex = 0;
            // 
            // editProgressBar
            // 
            this.editProgressBar.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProgressBar.Location = new System.Drawing.Point(96, 1);
            this.editProgressBar.Name = "editProgressBar";
            this.editProgressBar.Size = new System.Drawing.Size(242, 28);
            this.editProgressBar.TabIndex = 999;
            // 
            // TextProgress
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.editProgressBar);
            this.Controls.Add(this.editText);
            this.Size = new System.Drawing.Size(340, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox editText;
        private ProgressBar editProgressBar;


    }
}