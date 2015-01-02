using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class PagingContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagingContainer));
            this.container = new Gizmox.WebGUI.Forms.FlowLayoutPanel();
            this.btnPrevious = new Gizmox.WebGUI.Forms.Button();
            this.panelLeft = new Gizmox.WebGUI.Forms.Panel();
            this.lblPagingPrevious = new Gizmox.WebGUI.Forms.Label();
            this.btnNext = new Gizmox.WebGUI.Forms.Button();
            this.panelRight = new Gizmox.WebGUI.Forms.Panel();
            this.lblPagingNext = new Gizmox.WebGUI.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.container.Location = new System.Drawing.Point(44, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(712, 600);
            this.container.TabIndex = 3;
            this.container.SizeChanged += new System.EventHandler(this.flowContainer_SizeChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Left;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnPrevious.BackgroundImage"));
            this.btnPrevious.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center;
            this.btnPrevious.CustomStyle = "F";
            this.btnPrevious.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(2, 257);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 66);
            this.btnPrevious.TabIndex = 999;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.lblPagingPrevious);
            this.panelLeft.Controls.Add(this.btnPrevious);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(44, 600);
            this.panelLeft.TabIndex = 1;
            // 
            // lblPagingPrevious
            // 
            this.lblPagingPrevious.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Left;
            this.lblPagingPrevious.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingPrevious.ForeColor = System.Drawing.Color.DimGray;
            this.lblPagingPrevious.Location = new System.Drawing.Point(0, 327);
            this.lblPagingPrevious.Name = "lblPagingPrevious";
            this.lblPagingPrevious.Size = new System.Drawing.Size(44, 13);
            this.lblPagingPrevious.TabIndex = 1;
            this.lblPagingPrevious.Text = "0/0";
            this.lblPagingPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Right;
            this.btnNext.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnNext.BackgroundImage"));
            this.btnNext.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center;
            this.btnNext.CustomStyle = "F";
            this.btnNext.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(2, 257);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 66);
            this.btnNext.TabIndex = 999;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.lblPagingNext);
            this.panelRight.Controls.Add(this.btnNext);
            this.panelRight.Location = new System.Drawing.Point(756, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(44, 600);
            this.panelRight.TabIndex = 2;
            // 
            // lblPagingNext
            // 
            this.lblPagingNext.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Right;
            this.lblPagingNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagingNext.ForeColor = System.Drawing.Color.DimGray;
            this.lblPagingNext.Location = new System.Drawing.Point(0, 327);
            this.lblPagingNext.Name = "lblPagingNext";
            this.lblPagingNext.Size = new System.Drawing.Size(44, 13);
            this.lblPagingNext.TabIndex = 1;
            this.lblPagingNext.Text = "0/0";
            this.lblPagingNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PagingContainer
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.container);
            this.Size = new System.Drawing.Size(800, 600);
            this.Text = "PagingContainer";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button btnPrevious;
        private Panel panelLeft;
        public Button btnNext;
        private Panel panelRight;
        private FlowLayoutPanel container;
        private Label lblPagingNext;
        private Label lblPagingPrevious;


    }
}