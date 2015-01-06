using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextDropDown
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
            this.editText = new Gizmox.WebGUI.Forms.ComboBox();
            this.editTextRead = new Gizmox.WebGUI.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editText.BackColor = System.Drawing.Color.Transparent;
            this.editText.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editText.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.editText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.FormattingEnabled = true;
            this.editText.Location = new System.Drawing.Point(0, 1);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(337, 29);
            this.editText.TabIndex = 0;
            // 
            // editTextRead
            // 
            this.editTextRead.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTextRead.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editTextRead.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editTextRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTextRead.Location = new System.Drawing.Point(0, 0);
            this.editTextRead.Name = "editTextRead";
            this.editTextRead.Size = new System.Drawing.Size(337, 30);
            this.editTextRead.TabIndex = 999;
            // 
            // TextDropDown
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editTextRead);
            this.Controls.Add(this.editText);
            this.Size = new System.Drawing.Size(340, 30);
            this.Text = "TextDropDown";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox editText;
        private Gizmox.WebGUI.Forms.TextBox editTextRead;



    }
}