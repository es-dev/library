using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextCountry
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
            this.editCity = new Gizmox.WebGUI.Forms.TextBox();
            this.btnCombo = new Gizmox.WebGUI.Forms.Button();
            this.editCounty = new Gizmox.WebGUI.Forms.TextBox();
            this.lblProvincia = new Gizmox.WebGUI.Forms.Label();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.SuspendLayout();
            // 
            // editCity
            // 
            this.editCity.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCity.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editCity.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCity.Location = new System.Drawing.Point(0, 0);
            this.editCity.Name = "editCity";
            this.editCity.Size = new System.Drawing.Size(279, 30);
            this.editCity.TabIndex = 0;
            this.editCity.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.editCity_EnterKeyDown);
            // 
            // btnCombo
            // 
            this.btnCombo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCombo.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnCombo.CustomStyle = "F";
            this.btnCombo.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(410, 4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(24, 24);
            this.btnCombo.TabIndex = 999;
            this.btnCombo.TabStop = false;
            this.btnCombo.Text = "...";
            this.toolTip.SetToolTip(this.btnCombo, "Fai clic per selezionare una voce dall\'archivio comuni e province...");
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // editCounty
            // 
            this.editCounty.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCounty.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editCounty.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0);
            this.editCounty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCounty.Location = new System.Drawing.Point(359, 0);
            this.editCounty.Name = "editCounty";
            this.editCounty.Size = new System.Drawing.Size(47, 30);
            this.editCounty.TabIndex = 1;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblProvincia.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Transparent);
            this.lblProvincia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.Gray;
            this.lblProvincia.Location = new System.Drawing.Point(282, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(74, 30);
            this.lblProvincia.TabIndex = 999;
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextCountry
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.editCounty);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.editCity);
            this.Size = new System.Drawing.Size(443, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox editCity;
        private Button btnCombo;
        private Gizmox.WebGUI.Forms.TextBox editCounty;
        private Label lblProvincia;
        private ToolTip toolTip;


    }
}