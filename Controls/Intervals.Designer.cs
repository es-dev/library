using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class Intervals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intervals));
            this.btnConfirm = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.listIntervals = new Gizmox.WebGUI.Forms.ListView();
            this.columnHeader1 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirm.BackgroundImage"));
            this.btnConfirm.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnConfirm.CustomStyle = "F";
            this.btnConfirm.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(166, 282);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(24, 24);
            this.btnConfirm.TabIndex = 999;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancel.BackgroundImage"));
            this.btnCancel.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCancel.CustomStyle = "F";
            this.btnCancel.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(139, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.TabIndex = 999;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listIntervals
            // 
            this.listIntervals.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.listIntervals.BackColor = System.Drawing.Color.White;
            this.listIntervals.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.listIntervals.CheckBoxes = true;
            this.listIntervals.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listIntervals.DataMember = null;
            this.listIntervals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIntervals.FullRowSelect = true;
            this.listIntervals.GridLines = true;
            this.listIntervals.HeaderStyle = Gizmox.WebGUI.Forms.ColumnHeaderStyle.None;
            this.listIntervals.Location = new System.Drawing.Point(0, 27);
            this.listIntervals.MultiSelect = false;
            this.listIntervals.Name = "listIntervals";
            this.listIntervals.Size = new System.Drawing.Size(198, 249);
            this.listIntervals.TabIndex = 2;
            this.listIntervals.ItemCheck += new Gizmox.WebGUI.Forms.ItemCheckHandler(this.listIntervals_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 27);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " Orario";
            // 
            // Intervals
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.DimGray);
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listIntervals);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Size = new System.Drawing.Size(198, 316);
            this.Text = "EditInterval";
            this.Load += new System.EventHandler(this.Intervals_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private ListView listIntervals;
        private ColumnHeader columnHeader1;
        private Panel panel1;
        private Label label1;


    }
}