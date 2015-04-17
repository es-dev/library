#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using Library.Interfaces;
using Library.Template.Forms;
using Library.Template.MVVM;
using Library.Code;
using Library.Controls;
using Library.Code.Enum;

#endregion

namespace Library.Template.MVVM
{
    public partial class TemplateModel : UserControl, IModel
    {
        private IItem ownerItem = null;
        public IItem OwnerItem
        {
            get
            {
                return ownerItem;
            }
            set
            {
                ownerItem = value;
            }
        }

        private IWorkspace workspace = null;
        public IWorkspace Workspace
        {
            get
            {
                return workspace;
            }
            set
            {
                workspace = value;
            }
        }

        private ISpace ownerSpace = null;
        public ISpace OwnerSpace
        {
            get
            {
                return ownerSpace;
            }
            set
            {
                ownerSpace = value;
            }
        }

        private IViewModel viewModel = null;
        public IViewModel ViewModel
        {
            get
            {
                return viewModel;
            }
            set
            {
                viewModel = value;
            }
        }

        private Gizmox.WebGUI.Forms.Control control = null;
        public Gizmox.WebGUI.Forms.Control Control
        {
            get
            {
                control = (Control)this;
                return control;
            }
        }

        private object model = null;
        public object Model
        {
            get
            {
                BindModel(model);
                return model;
            }
            set
            {
                model = value;
                BindView(model);
                BindViewTitle(model);
                SetLayout();
            }
        }

        private string title = null;
        public string Title
        {
            get
            {
                title = infoTitle.Text;
                return title;
            }
            set
            {
                title = value;
                SetTitle(title);
            }
        }

        private void SetTitle(string title)
        {
            try
            {
                infoTitle.Text = (title != null ? title.ToUpper() : null);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public virtual string TitleSpace { get; set; }

        private bool editing = false;
        public bool Editing
        {
            get
            {
                return editing;
            }
            set
            {
                editing = value;
                SetEditing(editing, deleting);
            }
        }

        private bool deleting = true;
        public bool Deleting
        {
            get
            {
                return deleting;
            }
            set
            {
                deleting = value;
                SetDeleting(deleting);
            }
        }

        private bool updating = true;
        public bool Updating
        {
            get
            {
                return updating;
            }
            set
            {
                updating = value;
                SetUpdating(updating);
            }
        }

        private bool verified = false;
        public bool Verified
        {
            get
            {
                verified = IsVerified();
                return verified;
            }
        }

        private bool creating = false;
        public bool Creating
        {
            get
            {
                return creating;
            }
            set
            {
                creating = value;
            }
        }

        private bool changed = false;
        public bool Changed
        {
            get
            {
                changed = IsChanged();
                return changed;
            }
        }
               
        public TemplateModel()
        {
            InitializeComponent();
            try
            {
                Init();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void TemplateModel_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsNewModel(model))
                {
                    editing = true;
                    creating = true;
                }
                SetEditing(editing, deleting);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsNewModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var id = (int?)UtilityPOCO.GetPrimaryKeyValue(model);
                    if (id == 0)
                        return true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public virtual void BindView(object model) { }

        public virtual void BindModel(object model) { }

        public virtual void BindViewTitle(object model) { }

        public virtual void SetLayout() { }

        public virtual void Init()
        {
            try
            {
                infoSubtitle.Text = null;
                infoSubtitleImage.Image = "";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsVerified()
        {
            try
            {
                bool verified = true;
                var editControls = GetEditControls(container.Controls);
                foreach (var editControl in editControls)
                {
                    editControl.Verify();
                    bool _verified = editControl.Verified;
                    if (!_verified)
                        verified = false;
                }
                return verified;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public virtual UtilityValidation.ValidationState IsValidated() { return new UtilityValidation.ValidationState(); }

        private bool IsChanged()
        {
            try
            {
                bool changed = false;
                var editControls = GetEditControls(container.Controls);
                foreach (var editControl in editControls)
                {
                    editControl.Verify();
                    bool _changed = editControl.Changed;
                    if (_changed)
                        changed = true;
                }
                return changed;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public virtual void SetEditing(bool editing, bool deleting)
        {
            try
            {
                btnClose.Enabled = !editing;
                btnSave.Enabled = editing;
                btnUpdateCancel.TextButton = (editing ? "Annulla" : "Modifica");
                lblEditing.Visible = editing;
                var editControls = GetEditControls(container.Controls);
                foreach(var editControl in editControls)
                    editControl.Editing = editing;

                SetDeleting(editing && deleting);
                SetVisibility();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void SetDeleting(bool deleting)
        {
            try
            {
                btnDelete.Enabled = deleting;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetUpdating(bool updating)
        {
            try
            {
                btnUpdateCancel.Enabled = updating;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private List<IEditControl> GetEditControls(ControlCollection controls)
        {
            try
            {
                var editControls = new List<IEditControl>();
                foreach (Control control in controls)
                {
                    if (control is IEditControl) //controllo di tipo edit
                        editControls.Add((IEditControl)control);
                    else
                    {
                        if (control.HasChildren) //per controlli di tipo container (panel, tab, etc...) verifico se ci sono edit all'interno
                        {
                            var editChildControls = GetEditControls(control.Controls);
                            if (editChildControls != null)
                                editControls.AddRange(editChildControls);
                        }
                    }
                }
                return editControls;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (workspace != null)
                    workspace.CloseSpace(this);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bool changed = IsChanged();
                if (editing && changed)
                    UtilityMessage.Show(this, "ATTENZIONE!", "Si � scelto di non salvare i dati, tuttavia sono state rilevate delle variazioni alle informazioni contenute in archivio centrale. Continuando tutte le modifiche apportate ai dati in questa sessione di lavoro andranno perse. Vuoi continuare e perdere le modifiche?", TypeMessage.Question, OnUpdateCancel);
                else
                    OnUpdateCancel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void OnUpdateCancel()
        {
            try
            {
                editing = !editing;
                SetEditing(editing, deleting);
                if (!editing)
                {
                    BindView(model);
                    BindViewTitle(model);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewModel != null)
                {
                    var validated = IsValidated();
                    verified = IsVerified();
                    if (verified && validated != null && validated.State)
                    {
                        BindModel(model);
                        if (model != null)
                        {
                            bool performed = viewModel.Save(model, creating);
                            if (performed)
                            {
                                RefreshModel();

                                editing = false;
                                creating = false;
                                SetEditing(editing, deleting);
                                if (ownerItem != null)  //aggiornamento dell'item parent
                                {
                                    ownerItem.Model = model;
                                    ownerItem.BindView(model);
                                }
                                if (ownerSpace != null && ownerSpace is IView)
                                {
                                    var ownerView = (IView)ownerSpace;
                                    ownerView.RefreshItems();
                                }
                            }
                            else
                                UtilityMessage.Show(this, "ATTENZIONE!", "Non � stato possibile salvare le informazioni. Riprovare l'operazione in un secondo momento.", TypeMessage.Alert);
                        }
                    }
                    else
                    {
                        string message = "Non � stato possibile validare le informazioni. Verificare i dati inseriti e riprovare ad eseguire l'operazione.";
                        if (validated != null)
                            message += " " + validated.Message;
                        UtilityMessage.Show(this, "ATTENZIONE!", message, TypeMessage.Alert);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void RefreshModel()
        {
            try
            {
                if (model != null)
                {
                    var id = UtilityPOCO.GetPrimaryKeyValue(model);
                    model = viewModel.Read(id);
                    BindView(model);
                    BindViewTitle(model);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewModel != null && model != null)
                {
                    bool performed = viewModel.Delete(model);  //todo: inserire conferma eliminazione + inserire propriet� deleting
                    if (performed)
                    {
                        editing = false;
                        deleting = false;
                        updating = false;
                        SetEditing(editing, deleting);
                        SetUpdating(updating);
                        if (ownerSpace != null && ownerSpace is IView)
                        {
                            var ownerView = (IView)ownerSpace;
                            //if (ownerItem != null)  
                            //    ownerView.RemoveItem(ownerItem);
                            //else
                                ownerView.RefreshItems();
                        }

                        UtilityMessage.Show(this, "ELIMINAZIONE COMPLETATA", "La voce corrente � stata eliminata ed inserita nel cestino. E' possibile in ogni momento recuperare una voce eliminata, aprendo il cestino e facendo clic su Ripristina.", TypeMessage.Alert);
                    }
                    else
                        UtilityMessage.Show(this, "ATTENZIONE!", "Non � stato possibile eliminare le informazioni. Riprovare l'operazione in un secondo momento.", TypeMessage.Alert);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public event CloseHandler Closed;
        public void Close()
        {
            try
            {
                if (Closed != null)
                    Closed();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public event OpenHandler Opened;
        public void Open(bool backclosing=false)
        {
            try
            {
                if(backclosing)
                    RefreshModel();
                
                SetVisibility();
                if (Opened != null)
                    Opened();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetVisibility()
        {
            try
            {
                var parentOwner = UtilitySpace.GetParentOwner(this);
                btnHome.Visible = (!editing && parentOwner != null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                var rootSpace = UtilitySpace.GetRootSpace(this);
                if (rootSpace != null)
                {
                    this.ownerSpace = rootSpace;
                    if (workspace != null)
                        workspace.CloseSpace(this);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    
    }

   
}