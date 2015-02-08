using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class ComuniProvince
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComuniProvince));
            this.btnConfirm = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.listView = new Gizmox.WebGUI.Forms.ListView();
            this.columnHeader1 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.columnHeader2 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.columnHeader3 = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtSearch = new Gizmox.WebGUI.Forms.SearchTextBox();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnConfirm.BackgroundImage"));
            this.btnConfirm.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnConfirm.CustomStyle = "F";
            this.btnConfirm.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(620, 359);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(24, 24);
            this.btnConfirm.TabIndex = 999;
            this.toolTip.SetToolTip(this.btnConfirm, "Conferma");
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnCancel.BackgroundImage"));
            this.btnCancel.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.btnCancel.CustomStyle = "F";
            this.btnCancel.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(593, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.TabIndex = 999;
            this.toolTip.SetToolTip(this.btnCancel, "Annulla");
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.DataMember = null;
            this.listView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.ItemsPerPage = 10;
            this.listView.Location = new System.Drawing.Point(0, 54);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(652, 299);
            this.listView.TabIndex = 1;
            this.toolTip.SetToolTip(this.listView, "Premi INVIO o fai doppio clic con il mouse per confermare il valore selezionato.." +
        ".");
            this.listView.UseInternalPaging = true;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.KeyUp += new Gizmox.WebGUI.Forms.KeyEventHandler(this.listView_KeyUp);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Comune";
            this.columnHeader1.Width = 391;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Codice catastale";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Provincia";
            this.columnHeader3.Width = 79;
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 23);
            this.label1.TabIndex = 999;
            this.label1.Text = "Archivio comuni, codici catastali e province italiane";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(364, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1000;
            this.label2.Text = "Ricerca...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtSearch.CustomStyle = "STB";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(490, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 22);
            this.txtSearch.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtSearch, "Inserisci una chiave di ricerca (Ad es. ROMA oppure H501)...");
            this.txtSearch.Search += new System.EventHandler(this.txtSearch_Search);
            this.txtSearch.Clear += new System.EventHandler(this.txtSearch_Clear);
            this.txtSearch.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSearch_EnterKeyDown);
            // 
            // ComuniProvince
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.DimGray);
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Size = new System.Drawing.Size(652, 393);
            this.Text = "EditInterval";
            this.Load += new System.EventHandler(this.ComuniProvince_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private Label label1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label2;
        private SearchTextBox txtSearch;
        private ToolTip toolTip;


    }
}