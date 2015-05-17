using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WorkForceService
{
    partial class Manager
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.lblView = new Gizmox.WebGUI.Forms.Label();
            this.pictureBox2 = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgLogin = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgSeparator2 = new Gizmox.WebGUI.Forms.PictureBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.editState = new Gizmox.WebGUI.Forms.Label();
            this.editLastWork = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.editNextWork = new Gizmox.WebGUI.Forms.Label();
            this.timerWorkForce = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editNextWork);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.editLastWork);
            this.container.Controls.Add(this.editState);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.lblView);
            this.container.Controls.Add(this.imgSeparator2);
            this.container.Controls.Add(this.imgLogin);
            this.container.Controls.Add(this.pictureBox2);
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.DarkRed;
            this.lblView.Location = new System.Drawing.Point(100, 24);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(186, 47);
            this.lblView.TabIndex = 4;
            this.lblView.Text = "MANAGER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pictureBox2.Image"));
            this.pictureBox2.Location = new System.Drawing.Point(65, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(715, 19);
            this.pictureBox2.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // imgLogin
            // 
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgLogin.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgLogin.Image"));
            this.imgLogin.Location = new System.Drawing.Point(108, 92);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(178, 221);
            this.imgLogin.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 0;
            this.imgLogin.TabStop = false;
            // 
            // imgSeparator2
            // 
            this.imgSeparator2.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgSeparator2.Image"));
            this.imgSeparator2.Location = new System.Drawing.Point(293, 92);
            this.imgSeparator2.Name = "imgSeparator2";
            this.imgSeparator2.Size = new System.Drawing.Size(7, 273);
            this.imgSeparator2.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparator2.TabIndex = 8;
            this.imgSeparator2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(342, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "STATO DEL SERVIZIO:";
            // 
            // editState
            // 
            this.editState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.editState.Location = new System.Drawing.Point(580, 129);
            this.editState.Name = "editState";
            this.editState.Size = new System.Drawing.Size(367, 35);
            this.editState.TabIndex = 12;
            this.editState.Text = "ATTIVO";
            // 
            // editLastWork
            // 
            this.editLastWork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLastWork.ForeColor = System.Drawing.Color.RoyalBlue;
            this.editLastWork.Location = new System.Drawing.Point(580, 171);
            this.editLastWork.Name = "editLastWork";
            this.editLastWork.Size = new System.Drawing.Size(367, 35);
            this.editLastWork.TabIndex = 12;
            this.editLastWork.Text = "dd/MM/YYYY HH:mm:ss";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(342, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "ULTIMO CONTROLLO:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(342, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "PROSSIMO CONTROLLO:";
            // 
            // editNextWork
            // 
            this.editNextWork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNextWork.ForeColor = System.Drawing.Color.Red;
            this.editNextWork.Location = new System.Drawing.Point(580, 216);
            this.editNextWork.Name = "editNextWork";
            this.editNextWork.Size = new System.Drawing.Size(367, 35);
            this.editNextWork.TabIndex = 12;
            this.editNextWork.Text = "dd/MM/YYYY HH:mm:ss";
            // 
            // timerWorkForce
            // 
            this.timerWorkForce.Interval = 10000;
            // 
            // WorkForceService
            // 
            this.Text = "Work Force Service | Enterprise Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.timerWorkForce};
            this.Controls.SetChildIndex(this.bntPortaleWebAziendale, 0);
            this.Controls.SetChildIndex(this.btnSupportoTecnico, 0);
            this.Controls.SetChildIndex(this.btnInformazioni, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.infoTitle, 0);
            this.Controls.SetChildIndex(this.container, 0);
            this.Controls.SetChildIndex(this.panelInfo, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblView;
        private PictureBox imgSeparator2;
        private PictureBox imgLogin;
        private PictureBox pictureBox2;
        private Label label4;
        private Label editLastWork;
        private Label editState;
        private Label label1;
        private Label editNextWork;
        private Label label5;
        private Timer timerWorkForce;


    }
}