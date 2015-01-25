using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Template.MVVM
{
    partial class TemplateItem
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
            this.editCount = new Gizmox.WebGUI.Forms.Label();
            this.imgCheck = new Gizmox.WebGUI.Forms.PictureBox();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.imgCheck);
            this.container.Controls.Add(this.editCount);
            this.container.Size = new System.Drawing.Size(401, 100);
            // 
            // editCount
            // 
            this.editCount.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCount.BackColor = System.Drawing.Color.ForestGreen;
            this.editCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCount.ForeColor = System.Drawing.Color.White;
            this.editCount.Location = new System.Drawing.Point(349, 0);
            this.editCount.Name = "editCount";
            this.editCount.Size = new System.Drawing.Size(43, 20);
            this.editCount.TabIndex = 0;
            this.editCount.Text = "0";
            this.editCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editCount.Visible = false;
            // 
            // imgCheck
            // 
            this.imgCheck.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.imgCheck.BackColor = System.Drawing.Color.Transparent;
            this.imgCheck.Location = new System.Drawing.Point(360, -1);
            this.imgCheck.Name = "imgCheck";
            this.imgCheck.Size = new System.Drawing.Size(32, 32);
            this.imgCheck.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCheck.TabIndex = 1;
            this.imgCheck.TabStop = false;
            // 
            // TemplateItem
            // 
            this.Margin = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(401, 100);
            this.Load += new System.EventHandler(this.TemplateItem_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label editCount;
        private PictureBox imgCheck;


    }
}