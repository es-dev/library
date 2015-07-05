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
    public partial class Countries : UserControl
    {
        private Control owner = null;

        public Countries(Control owner, string search=null)
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

        private void Countries_Load(object sender, EventArgs e)
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

        IList<City> cities = null;
        private void LoadItems()
        {
            try
            {
                cities = ReadCities();
                RefreshItems();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindView(IList<City> cities)
        {
            try
            {
                listView.Items.Clear();
                foreach (var city in cities)
                {
                    var item = new ListViewItem();
                    item.SubItems.Add(city.Description);
                    item.SubItems.Add(city.Code);
                    item.SubItems.Add(city.County);
                    item.Tag = city;
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
                IList<City> cities = null;
                if(search!=null && search.Length>0 && search.Contains("("))
                {
                    var description = City.GetDescription(search);
                    var code = City.GetCode(search);
                    cities = LoadCities(description, code);
                }
                else
                    cities = LoadCities(search);
                BindView(cities);
                if(cities.Count>=1 && search!=null && search.Length>0)
                    SelectFirstItem();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<City> LoadCities(string search)
        {
            try
            {
                var _cities = (from q in cities select q);
                if(search!=null && search.Length>0)
                    _cities = (from q in cities where q.Code.ToUpper().StartsWith(search.ToUpper()) || 
                                   q.Description.ToUpper().StartsWith(search.ToUpper()) || 
                                   q.County.ToUpper().StartsWith(search.ToUpper()) select q);
                return _cities.ToList();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IList<City> LoadCities(string description, string code)
        {
            try
            {
                var _cities = (from q in cities select q);
                if (description != null && description.Length > 0)
                    _cities = (from q in _cities
                               where q.Description.ToUpper().StartsWith(description.ToUpper())
                               select q);
                if (code != null && code.Length >=4)
                    _cities = (from q in _cities
                               where q.Code.ToUpper().StartsWith(code.ToUpper())
                               select q);
                return _cities.ToList();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public IList<City> ReadCities()
        {
            try
            {
                var contents = UtilityWeb.GetResources(this, "Countries.csv", "Resources", "ES");
                var cities = (from q in contents
                              select new City()
                              {
                                  Code = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[0],
                                  County = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[1],
                                  Description = q.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[2].Replace("\r\n", "")
                              }).ToList();
               
                return cities;
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

        public class City
        {
            private string separator = " - ";

            private string description = null;
            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }

            private string descriptionCode = null;
            public string DescriptionCode
            {
                get
                {
                    descriptionCode = GetDescriptionCode();
                    return descriptionCode;
                }
                set
                {
                    descriptionCode = value;
                    SetDescriptionCode(descriptionCode);
                }
            }

            private void SetDescriptionCode(string descriptionCode)
            {
                try
                {
                    if (descriptionCode != null && descriptionCode.Length > 0)
                    {
                        description = GetDescription(descriptionCode);
                        code = GetCode(descriptionCode);
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            private string GetDescriptionCode()
            {
                try
                {
                    var descriptionCode = description;
                    if(code!=null && code.Length>0)
                        descriptionCode += " (" + code + ")";
                    return descriptionCode;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            public static string GetDescription(string descriptionCode)
            {
                try
                {
                    var splits = descriptionCode.Split(new string[] { "(" }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 1)
                    {
                        var description = splits[0].Trim();
                        return description;
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            public static string GetCode(string descriptionCode)
            {
                try
                {
                    var splits = descriptionCode.Split(new string[] { "(" }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 2)
                    {
                        var code = splits[1].Replace(")", "").Trim();
                        return code;
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }

            private string code = null;
            public string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
                }
            }

            private string county = null;
            public string County
            {
                get
                {
                    return county;
                }
                set
                {
                    county = value;
                }
            }

            public City()
            {

            }

            public City(string text)
            {
                try
                {
                    if(text!=null && text.Length>0)
                    {
                        var splits = text.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                        if (splits.Length >= 1)
                        {
                            descriptionCode = splits[0];
                            SetDescriptionCode(descriptionCode);
                        }
                        if (splits.Length >= 2)
                            county = splits[1];
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public City(string descriptionCode, string county)
            {
                try
                {
                    this.descriptionCode = descriptionCode;
                    this.county = county;
                    SetDescriptionCode(descriptionCode);

                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public City(string description, string code, string county)
            {
                try
                {
                    this.description = description;
                    this.code = code;
                    this.county = county;
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
                    string text = null;
                    var descriptionCode = GetDescriptionCode();
                    if (descriptionCode != null && descriptionCode.Length > 0)
                        text = descriptionCode;
                    if(county!=null && county.Length>0)
                        text += separator + county;

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

        public delegate void ConfirmlHanlder(City value);
        public event ConfirmlHanlder Confirm;
        
        private void ConfirmClose()
        {
            try
            {
                var item = listView.SelectedItem;
                if (item != null)
                {
                    var value = (City)item.Tag;
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