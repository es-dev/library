using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Library.WorkForceService
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.imgSeparator2 = new Gizmox.WebGUI.Forms.PictureBox();
            this.imgLogin = new Gizmox.WebGUI.Forms.PictureBox();
            this.editState = new Library.Template.Controls.TemplateEditSwitch();
            this.editLastWork = new Library.Template.Controls.TemplateEditText();
            this.editNextWork = new Library.Template.Controls.TemplateEditText();
            this.timerWorkForce = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.editWorkProcesses = new Gizmox.WebGUI.Forms.ListView();
            this.clmWorkProcess = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmWorkAction = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmLastRunning = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmInterval = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmState = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.editWorkProcesses);
            this.container.Controls.Add(this.editNextWork);
            this.container.Controls.Add(this.editLastWork);
            this.container.Controls.Add(this.editState);
            this.container.Controls.Add(this.imgLogin);
            this.container.Controls.Add(this.imgSeparator2);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.imgSeparator2, 0);
            this.container.Controls.SetChildIndex(this.imgLogin, 0);
            this.container.Controls.SetChildIndex(this.editState, 0);
            this.container.Controls.SetChildIndex(this.editLastWork, 0);
            this.container.Controls.SetChildIndex(this.editNextWork, 0);
            this.container.Controls.SetChildIndex(this.editWorkProcesses, 0);
            this.container.Controls.SetChildIndex(this.label1, 0);
            // 
            // imgSeparator2
            // 
            this.imgSeparator2.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgSeparator2.Image"));
            this.imgSeparator2.Location = new System.Drawing.Point(229, 56);
            this.imgSeparator2.Name = "imgSeparator2";
            this.imgSeparator2.Size = new System.Drawing.Size(7, 273);
            this.imgSeparator2.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeparator2.TabIndex = 8;
            this.imgSeparator2.TabStop = false;
            // 
            // imgLogin
            // 
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgLogin.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgLogin.Image"));
            this.imgLogin.Location = new System.Drawing.Point(44, 56);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(178, 221);
            this.imgLogin.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 0;
            this.imgLogin.TabStop = false;
            // 
            // editState
            // 
            this.editState.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editState.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editState.BackColor = System.Drawing.Color.Transparent;
            this.editState.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editState.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editState.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editState.Changed = false;
            this.editState.Editing = false;
            this.editState.Group = "SwitchGroup1";
            this.editState.Label = "STATO DEL SERVIZIO";
            this.editState.LabelWidth = 200;
            this.editState.Location = new System.Drawing.Point(300, 93);
            this.editState.Name = "editState";
            this.editState.ReadOnly = false;
            this.editState.Required = false;
            this.editState.Size = new System.Drawing.Size(568, 30);
            this.editState.TabIndex = 1000;
            this.editState.Value = false;
            // 
            // editLastWork
            // 
            this.editLastWork.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editLastWork.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editLastWork.BackColor = System.Drawing.Color.Transparent;
            this.editLastWork.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editLastWork.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editLastWork.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editLastWork.Changed = true;
            this.editLastWork.Editing = false;
            this.editLastWork.Label = "ULTIMO CONTROLLO";
            this.editLastWork.LabelWidth = 200;
            this.editLastWork.Location = new System.Drawing.Point(300, 145);
            this.editLastWork.Name = "editLastWork";
            this.editLastWork.ReadOnly = false;
            this.editLastWork.Required = false;
            this.editLastWork.Size = new System.Drawing.Size(568, 30);
            this.editLastWork.TabIndex = 1001;
            this.editLastWork.Value = null;
            // 
            // editNextWork
            // 
            this.editNextWork.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNextWork.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNextWork.BackColor = System.Drawing.Color.Transparent;
            this.editNextWork.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNextWork.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNextWork.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNextWork.Changed = true;
            this.editNextWork.Editing = false;
            this.editNextWork.Label = "PROSSIMO CONTROLLO";
            this.editNextWork.LabelWidth = 200;
            this.editNextWork.Location = new System.Drawing.Point(300, 197);
            this.editNextWork.Name = "editNextWork";
            this.editNextWork.ReadOnly = false;
            this.editNextWork.Required = false;
            this.editNextWork.Size = new System.Drawing.Size(568, 30);
            this.editNextWork.TabIndex = 1001;
            this.editNextWork.Value = null;
            // 
            // timerWorkForce
            // 
            this.timerWorkForce.Enabled = true;
            this.timerWorkForce.Interval = 1000;
            this.timerWorkForce.Tick += new System.EventHandler(this.timerWorkForce_Tick);
            // 
            // editWorkProcesses
            // 
            this.editWorkProcesses.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editWorkProcesses.BackColor = System.Drawing.Color.Transparent;
            this.editWorkProcesses.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editWorkProcesses.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.clmWorkProcess,
            this.clmWorkAction,
            this.clmLastRunning,
            this.clmInterval,
            this.clmState});
            this.editWorkProcesses.DataMember = null;
            this.editWorkProcesses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editWorkProcesses.FullRowSelect = true;
            this.editWorkProcesses.Location = new System.Drawing.Point(44, 387);
            this.editWorkProcesses.Name = "editWorkProcesses";
            this.editWorkProcesses.Size = new System.Drawing.Size(822, 201);
            this.editWorkProcesses.TabIndex = 1002;
            // 
            // clmWorkProcess
            // 
            this.clmWorkProcess.Text = "Processo";
            this.clmWorkProcess.Width = 214;
            // 
            // clmWorkAction
            // 
            this.clmWorkAction.Text = "Azione";
            this.clmWorkAction.Width = 295;
            // 
            // clmLastRunning
            // 
            this.clmLastRunning.Text = "Ultima esecuzione";
            this.clmLastRunning.Width = 126;
            // 
            // clmInterval
            // 
            this.clmInterval.Text = "Intervallo";
            this.clmInterval.Width = 78;
            // 
            // clmState
            // 
            this.clmState.Text = "Stato";
            this.clmState.Width = 70;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(41, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 27);
            this.label1.TabIndex = 1003;
            this.label1.Text = "PROCESSI IN ESECUZIONE";
            // 
            // Manager
            // 
            this.Text = "Manager1";
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.timerWorkForce};
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgLogin;
        private PictureBox imgSeparator2;
        private Template.Controls.TemplateEditSwitch editState;
        private Template.Controls.TemplateEditText editNextWork;
        private Template.Controls.TemplateEditText editLastWork;
        private Timer timerWorkForce;
        private ListView editWorkProcesses;
        private ColumnHeader clmWorkProcess;
        private ColumnHeader clmWorkAction;
        private ColumnHeader clmLastRunning;
        private ColumnHeader clmInterval;
        private ColumnHeader clmState;
        private Label label1;


    }
}