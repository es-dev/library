using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextComuneProvincia
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
            this.editComune = new Gizmox.WebGUI.Forms.TextBox();
            this.btnCombo = new Gizmox.WebGUI.Forms.Button();
            this.editProvincia = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProvincia = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // editComune
            // 
            this.editComune.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editComune.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editComune.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editComune.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editComune.Location = new System.Drawing.Point(0, 0);
            this.editComune.Name = "editComune";
            this.editComune.Size = new System.Drawing.Size(279, 30);
            this.editComune.TabIndex = 0;
            this.editComune.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.editComune_EnterKeyDown);
            // 
            // btnCombo
            // 
            this.btnCombo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCombo.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnCombo.CustomStyle = "F";
            this.btnCombo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(410, 0);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(30, 30);
            this.btnCombo.TabIndex = 999;
            this.btnCombo.TabStop = false;
            this.btnCombo.Text = "...";
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // editProvincia
            // 
            this.editProvincia.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProvincia.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editProvincia.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editProvincia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProvincia.Location = new System.Drawing.Point(359, 0);
            this.editProvincia.Name = "editProvincia";
            this.editProvincia.Size = new System.Drawing.Size(47, 30);
            this.editProvincia.TabIndex = 1;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.lblProvincia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.DimGray;
            this.lblProvincia.Location = new System.Drawing.Point(282, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(35, 26);
            this.lblProvincia.TabIndex = 999;
            this.lblProvincia.Text = "Provincia";
            // 
            // TextComuneProvincia
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.editProvincia);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.editComune);
            this.Size = new System.Drawing.Size(443, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox editComune;
        private Button btnCombo;
        private Gizmox.WebGUI.Forms.TextBox editProvincia;
        private Label lblProvincia;


    }
}