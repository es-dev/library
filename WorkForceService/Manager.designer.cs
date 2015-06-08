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
            this.editStato = new Library.Template.Controls.TemplateEditSwitch();
            this.editUltimoControllo = new Library.Template.Controls.TemplateEditText();
            this.editProssimoControllo = new Library.Template.Controls.TemplateEditText();
            this.timerWorkForce = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.editProcessi = new Gizmox.WebGUI.Forms.ListView();
            this.clmWorkProcess = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmWorkActionDescription = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmLastRunning = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmInterval = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.clmLogDateTime = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmLogWorkAction = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmLogDescription = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.clmLogState = ((Gizmox.WebGUI.Forms.ColumnHeader)(new Gizmox.WebGUI.Forms.ColumnHeader()));
            this.editLogs = new Gizmox.WebGUI.Forms.ListView();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editLogs);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.editProcessi);
            this.container.Controls.Add(this.editProssimoControllo);
            this.container.Controls.Add(this.editUltimoControllo);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.imgLogin);
            this.container.Controls.Add(this.imgSeparator2);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.imgSeparator2, 0);
            this.container.Controls.SetChildIndex(this.imgLogin, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editUltimoControllo, 0);
            this.container.Controls.SetChildIndex(this.editProssimoControllo, 0);
            this.container.Controls.SetChildIndex(this.editProcessi, 0);
            this.container.Controls.SetChildIndex(this.label1, 0);
            this.container.Controls.SetChildIndex(this.label2, 0);
            this.container.Controls.SetChildIndex(this.editLogs, 0);
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
            // editStato
            // 
            this.editStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = false;
            this.editStato.Editing = false;
            this.editStato.Group = "SwitchGroup1";
            this.editStato.Label = "STATO DEL SERVIZIO";
            this.editStato.LabelWidth = 200;
            this.editStato.Location = new System.Drawing.Point(267, 62);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = false;
            this.editStato.Size = new System.Drawing.Size(627, 30);
            this.editStato.TabIndex = 1000;
            this.editStato.Value = false;
            // 
            // editUltimoControllo
            // 
            this.editUltimoControllo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editUltimoControllo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editUltimoControllo.BackColor = System.Drawing.Color.Transparent;
            this.editUltimoControllo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editUltimoControllo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editUltimoControllo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editUltimoControllo.Changed = true;
            this.editUltimoControllo.Editing = false;
            this.editUltimoControllo.Label = "ULTIMO CONTROLLO";
            this.editUltimoControllo.LabelWidth = 200;
            this.editUltimoControllo.Location = new System.Drawing.Point(267, 106);
            this.editUltimoControllo.Name = "editUltimoControllo";
            this.editUltimoControllo.ReadOnly = false;
            this.editUltimoControllo.Required = false;
            this.editUltimoControllo.Size = new System.Drawing.Size(627, 30);
            this.editUltimoControllo.TabIndex = 1001;
            this.editUltimoControllo.Value = null;
            // 
            // editProssimoControllo
            // 
            this.editProssimoControllo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProssimoControllo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editProssimoControllo.BackColor = System.Drawing.Color.Transparent;
            this.editProssimoControllo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editProssimoControllo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editProssimoControllo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editProssimoControllo.Changed = true;
            this.editProssimoControllo.Editing = false;
            this.editProssimoControllo.Label = "PROSSIMO CONTROLLO";
            this.editProssimoControllo.LabelWidth = 200;
            this.editProssimoControllo.Location = new System.Drawing.Point(267, 150);
            this.editProssimoControllo.Name = "editProssimoControllo";
            this.editProssimoControllo.ReadOnly = false;
            this.editProssimoControllo.Required = false;
            this.editProssimoControllo.Size = new System.Drawing.Size(627, 30);
            this.editProssimoControllo.TabIndex = 1001;
            this.editProssimoControllo.Value = null;
            // 
            // timerWorkForce
            // 
            this.timerWorkForce.Enabled = true;
            this.timerWorkForce.Interval = 30000;
            this.timerWorkForce.Tick += new System.EventHandler(this.timerWorkForce_Tick);
            // 
            // editProcessi
            // 
            this.editProcessi.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editProcessi.BackColor = System.Drawing.Color.Transparent;
            this.editProcessi.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editProcessi.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.clmWorkProcess,
            this.clmWorkActionDescription,
            this.clmLastRunning,
            this.clmInterval});
            this.editProcessi.DataMember = null;
            this.editProcessi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProcessi.FullRowSelect = true;
            this.editProcessi.ItemsPerPage = 5;
            this.editProcessi.Location = new System.Drawing.Point(268, 228);
            this.editProcessi.Name = "editProcessi";
            this.editProcessi.Size = new System.Drawing.Size(626, 130);
            this.editProcessi.TabIndex = 1002;
            this.editProcessi.UseInternalPaging = true;
            // 
            // clmWorkProcess
            // 
            this.clmWorkProcess.Text = "Processo";
            this.clmWorkProcess.Width = 165;
            // 
            // clmWorkActionDescription
            // 
            this.clmWorkActionDescription.Text = "Descrizione";
            this.clmWorkActionDescription.Width = 243;
            // 
            // clmLastRunning
            // 
            this.clmLastRunning.Text = "Ultima esecuzione";
            this.clmLastRunning.Width = 135;
            // 
            // clmInterval
            // 
            this.clmInterval.Text = "Intervallo";
            this.clmInterval.Width = 78;
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(267, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 23);
            this.label1.TabIndex = 1003;
            this.label1.Text = "PROCESSI IN ESECUZIONE";
            // 
            // label2
            // 
            this.label2.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(40, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 27);
            this.label2.TabIndex = 1003;
            this.label2.Text = "LOG ATTIVITA\'";
            // 
            // clmLogDateTime
            // 
            this.clmLogDateTime.Text = "Data";
            this.clmLogDateTime.Width = 135;
            // 
            // clmLogWorkAction
            // 
            this.clmLogWorkAction.Text = "Azione";
            this.clmLogWorkAction.Width = 134;
            // 
            // clmLogDescription
            // 
            this.clmLogDescription.Text = "Descrizione";
            this.clmLogDescription.Width = 450;
            // 
            // clmLogState
            // 
            this.clmLogState.Text = "Stato";
            this.clmLogState.Width = 70;
            // 
            // editLogs
            // 
            this.editLogs.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Bottom) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editLogs.BackColor = System.Drawing.Color.Transparent;
            this.editLogs.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.editLogs.Columns.AddRange(new Gizmox.WebGUI.Forms.ColumnHeader[] {
            this.clmLogDateTime,
            this.clmLogWorkAction,
            this.clmLogDescription,
            this.clmLogState});
            this.editLogs.DataMember = null;
            this.editLogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLogs.FullRowSelect = true;
            this.editLogs.Location = new System.Drawing.Point(40, 401);
            this.editLogs.Name = "editLogs";
            this.editLogs.Size = new System.Drawing.Size(852, 180);
            this.editLogs.TabIndex = 1002;
            this.editLogs.UseInternalPaging = true;
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
        private Template.Controls.TemplateEditSwitch editStato;
        private Template.Controls.TemplateEditText editProssimoControllo;
        private Template.Controls.TemplateEditText editUltimoControllo;
        private Timer timerWorkForce;
        private ListView editProcessi;
        private ColumnHeader clmWorkProcess;
        private ColumnHeader clmWorkActionDescription;
        private ColumnHeader clmLastRunning;
        private ColumnHeader clmInterval;
        private Label label1;
        private ListView editLogs;
        private ColumnHeader clmLogDateTime;
        private ColumnHeader clmLogWorkAction;
        private ColumnHeader clmLogDescription;
        private ColumnHeader clmLogState;
        private Label label2;


    }
}