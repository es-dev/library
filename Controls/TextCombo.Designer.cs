using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextCombo
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
            this.btnCombo = new Gizmox.WebGUI.Forms.Button();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editText.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editText.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(0, 0);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(302, 30);
            this.editText.TabIndex = 0;
            this.editText.Click += new System.EventHandler(this.TextCombo_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCombo.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnCombo.CustomStyle = "F";
            this.btnCombo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(305, 4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(24, 24);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.TabStop = false;
            this.btnCombo.Text = "...";
            this.toolTip.SetToolTip(this.btnCombo, "Fai clic per selezionare una voce dall\'archivio dati...");
            this.btnCombo.Click += new System.EventHandler(this.TextCombo_Click);
            // 
            // TextCombo
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.editText);
            this.Size = new System.Drawing.Size(340, 30);
            this.Text = "TextCombo";
            this.Click += new System.EventHandler(this.TextCombo_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox editText;
        private Button btnCombo;
        private ToolTip toolTip;


    }
}