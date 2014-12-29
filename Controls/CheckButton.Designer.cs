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
            this.editTrue = new Gizmox.WebGUI.Forms.Button();
            this.editFalse = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // editTrue
            // 
            this.editTrue.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.editTrue.CustomStyle = "F";
            this.editTrue.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.editTrue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTrue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editTrue.Location = new System.Drawing.Point(0, 0);
            this.editTrue.Name = "editTrue";
            this.editTrue.Size = new System.Drawing.Size(134, 28);
            this.editTrue.TabIndex = 0;
            this.editTrue.TabStop = false;
            this.editTrue.Text = "True";
            this.editTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editTrue.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.editTrue.Click += new System.EventHandler(this.editTrue_Click);
            // 
            // editFalse
            // 
            this.editFalse.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.editFalse.CustomStyle = "F";
            this.editFalse.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.editFalse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFalse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editFalse.Location = new System.Drawing.Point(134, 0);
            this.editFalse.Name = "editFalse";
            this.editFalse.Size = new System.Drawing.Size(134, 28);
            this.editFalse.TabIndex = 0;
            this.editFalse.TabStop = false;
            this.editFalse.Text = "False";
            this.editFalse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editFalse.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.editFalse.Click += new System.EventHandler(this.editFalse_Click);
            // 
            // CheckButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.editFalse);
            this.Controls.Add(this.editTrue);
            this.Size = new System.Drawing.Size(272, 30);
            this.SizeChanged += new System.EventHandler(this.CheckButton_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Button editTrue;
        private Button editFalse;


    }
}