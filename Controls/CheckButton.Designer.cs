using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class CheckButton
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
            this.btnTrue = new Gizmox.WebGUI.Forms.Button();
            this.btnFalse = new Gizmox.WebGUI.Forms.Button();
            this.lblTrue = new Gizmox.WebGUI.Forms.Label();
            this.lblFalse = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrue
            // 
            this.btnTrue.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnTrue.CustomStyle = "F";
            this.btnTrue.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnTrue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrue.Location = new System.Drawing.Point(0, 0);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(30, 28);
            this.btnTrue.TabIndex = 999;
            this.btnTrue.TabStop = false;
            this.btnTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrue.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnFalse.CustomStyle = "F";
            this.btnFalse.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnFalse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFalse.Location = new System.Drawing.Point(134, 0);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(30, 28);
            this.btnFalse.TabIndex = 999;
            this.btnFalse.TabStop = false;
            this.btnFalse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFalse.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // lblTrue
            // 
            this.lblTrue.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblTrue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrue.Location = new System.Drawing.Point(30, 0);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(104, 28);
            this.lblTrue.TabIndex = 1000;
            this.lblTrue.Text = "TRUE";
            this.lblTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // lblFalse
            // 
            this.lblFalse.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lblFalse.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.lblFalse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalse.Location = new System.Drawing.Point(164, 0);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(104, 28);
            this.lblFalse.TabIndex = 1000;
            this.lblFalse.Text = "FALSE";
            this.lblFalse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // CheckButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Size = new System.Drawing.Size(272, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTrue;
        private Button btnFalse;
        private Label lblTrue;
        private Label lblFalse;


    }
}