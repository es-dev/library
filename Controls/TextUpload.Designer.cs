using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.Controls
{
    partial class TextUpload
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
            this.btnUpload = new Gizmox.WebGUI.Forms.Button();
            this.toolTip = new Gizmox.WebGUI.Forms.ToolTip();
            this.openFile = new Gizmox.WebGUI.Forms.OpenFileDialog();
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
            this.editText.Click += new System.EventHandler(this.TextUpload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnUpload.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.btnUpload.CustomStyle = "F";
            this.btnUpload.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(305, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(24, 24);
            this.btnUpload.TabIndex = 999;
            this.btnUpload.TabStop = false;
            this.btnUpload.Text = "...";
            this.toolTip.SetToolTip(this.btnUpload, "Fai clic per selezionare una voce dall\'archivio dati...");
            this.btnUpload.Click += new System.EventHandler(this.TextUpload_Click);
            // 
            // openFile
            // 
            this.openFile.MaxFileSize = 16384;
            this.openFile.Theme = "";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // TextUpload
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.editText);
            this.Size = new System.Drawing.Size(340, 30);
            this.Text = "TextCombo";
            this.Click += new System.EventHandler(this.TextUpload_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox editText;
        private Button btnUpload;
        private ToolTip toolTip;
        private OpenFileDialog openFile;


    }
}