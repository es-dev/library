#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;

#endregion

namespace Library.Controls
{
    public partial class ComuniProvince : UserControl
    {
        private Control owner = null;

        public ComuniProvince(Control owner, string search=null)
        {
            InitializeComponent();
            try
            {
                this.owner = owner;
                txtSearch.Text = search;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ComuniProvince_Load(object sender, EventArgs e)
        {
            try
            {
                SetLayout();
                LoadItems();
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        IList<Comune> comuni = null;
        private void LoadItems()
        {
            try
            {
                comuni = ReadComuni();
                RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindView(IList<Comune> comuni)
        {
            try
            {
                listView.Items.Clear();
                foreach (var comune in comuni)
                {
                    var item = new ListViewItem();
                    item.SubItems.Add(comune.Denominazione);
                    item.SubItems.Add(comune.CodiceCatastale);
                    item.SubItems.Add(comune.Provincia);
                    item.Tag = comune;
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void RefreshItems()
        {
            try
            {
                var search = txtSearch.Text;
                IList<Comune> comuni = null;
                if(search!=null && search.Length>0 && search.Contains("("))
                {
                    var denominazione = Comune.GetDenominazione(search);
                    var codiceCatastale = Comune.GetCodiceCatastale(search);
                    comuni = LoadComuni(denominazione, codiceCatastale);
                }
                else
                    comuni = LoadComuni(search);
                BindView(comuni);
                if(comuni.Count>=1 && search!=null && search.Length>0)
                    SelectFirstItem();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<Comune> LoadComuni(string search)
        {
            try
            {
                var _comuni = (from q in comuni select q);
                if(search!=null && search.Length>0)
                    _comuni = (from q in comuni where q.CodiceCatastale.ToUpper().StartsWith(search.ToUpper()) || 
                                   q.Denominazione.ToUpper().StartsWith(search.ToUpper()) || 
                                   q.Provincia.ToUpper().StartsWith(search.ToUpper()) select q);
                return _comuni.ToList();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IList<Comune> LoadComuni(string denominazione, string codiceCatastale)
        {
            try
            {
                var _comuni = (from q in comuni select q);
                if (denominazione != null && denominazione.Length > 0)
                    _comuni = (from q in _comuni
                               where q.Denominazione.ToUpper().StartsWith(denominazione.ToUpper())
                               select q);
                if (codiceCatastale != null && codiceCatastale.Length >=4)
                    _comuni = (from q in _comuni
                               where q.CodiceCatastale.ToUpper().StartsWith(codiceCatastale.ToUpper())
                               select q);
                return _comuni.ToList();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        private IList<Comune> ReadComuni()
        {
            try
            {
                var contents = UtilityWeb.GetResources(this, "Comuni.csv", "Resources", "ES");
                var comuni = (from q in contents
                              select new Comune()
                              {
                                  CodiceCatastale = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[0],
                                  Provincia = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[1],
                                  Denominazione = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[2]
                              }).ToList();
               
                return comuni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetLayout()
        {
            try
            {
                btnConfirm.Enabled = false;
                txtSearch.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public class Comune
        {
            private string separator = " - ";

            private string denominazione = null;
            public string Denominazione
            {
                get
                {
                    return denominazione;
                }
                set
                {
                    denominazione = value;
                }
            }

            private string denominazioneCodiceCatastale = null;
            public string DenominazioneCodiceCatastale
            {
                get
                {
                    denominazioneCodiceCatastale = GetDenominazioneCodiceCatastale();
                    return denominazioneCodiceCatastale;
                }
                set
                {
                    denominazioneCodiceCatastale = value;
                    SetDenominazioneCodiceCatastale(denominazioneCodiceCatastale);
                }
            }

            private void SetDenominazioneCodiceCatastale(string denominazioneCodiceCatastale)
            {
                try
                {
                    if(denominazioneCodiceCatastale!=null && denominazioneCodiceCatastale.Length>0)
                    {
                       denominazione=GetDenominazione(denominazioneCodiceCatastale);
                       codiceCatastale = GetCodiceCatastale(denominazioneCodiceCatastale);
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            private string GetDenominazioneCodiceCatastale()
            {
                try
                {
                    var denominazioneCodiceCatastale = denominazione + " (" + codiceCatastale + ")";
                    return denominazioneCodiceCatastale;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            public static string GetDenominazione(string denominazioneCodiceCatastale)
            {
                try
                {
                    var splits = denominazioneCodiceCatastale.Split(new string[] { "(" }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 1)
                    {
                        var denominazione = splits[0].Trim();
                        return denominazione;
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            public static string GetCodiceCatastale(string denominazioneCodiceCatastale)
            {
                try
                {
                    var splits = denominazioneCodiceCatastale.Split(new string[] { "(" }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 2)
                    {
                        var codiceCatastale = splits[1].Replace(")", "").Trim();
                        return codiceCatastale;
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            private string codiceCatastale = null;
            public string CodiceCatastale
            {
                get
                {
                    return codiceCatastale;
                }
                set
                {
                    codiceCatastale = value;
                }
            }

            private string provincia = null;
            public string Provincia
            {
                get
                {
                    return provincia;
                }
                set
                {
                    provincia = value;
                }
            }

            public Comune()
            {

            }

            public Comune(string text)
            {
                try
                {
                    if(text!=null && text.Length>0)
                    {
                        var splits = text.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                        if (splits.Length >= 1)
                        {
                            denominazioneCodiceCatastale = splits[0];
                            SetDenominazioneCodiceCatastale(denominazioneCodiceCatastale);
                        }
                        if (splits.Length >= 2)
                            provincia = splits[1];
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public Comune(string denominazione, string codiceCatastale, string provincia)
            {
                try
                {
                    this.denominazione = denominazione;
                    this.codiceCatastale = codiceCatastale;
                    this.provincia = provincia;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public new string ToString()
            {
                try
                {
                    var denominazioneCodiceCatastale = GetDenominazioneCodiceCatastale();
                    var text = denominazioneCodiceCatastale + separator + provincia;
                    return text;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmClose();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                UtilityWeb.RemoveJQControl(this);
                if (owner.CanFocus)
                    owner.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        private void txtSearch_Search(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SelectFirstItem()
        {
            try
            {
                listView.Focus();
                listView.Focus();
                if(listView.Items.Count>=1)
                    listView.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        private void txtSearch_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            try
            {
                var search = txtSearch.Text;
                if (search == null || search.Length == 0)
                    RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void txtSearch_Clear(object sender, EventArgs e)
        {
            try
            {
                RefreshItems();
                txtSearch.Focus();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnConfirm.Enabled = (listView.SelectedItem != null);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        private void listView_KeyUp(object objSender, KeyEventArgs objArgs)
        {
            try
            {
                if(objArgs.KeyCode== Keys.Enter)
                    ConfirmClose();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ConfirmlHanlder(Comune value);
        public event ConfirmlHanlder Confirm;
        
        private void ConfirmClose()
        {
            try
            {
                var item = listView.SelectedItem;
                if (item != null)
                {
                    var value = (Comune)item.Tag;
                    if (Confirm != null)
                        Confirm(value);

                    UtilityWeb.RemoveJQControl(this);
                    if (owner.CanFocus)
                        owner.Focus();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ConfirmClose();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       

    }
}