using Gizmox.WebGUI.Forms;
using Library.Code;
using Library.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Library.Template.Controls;
using Library.Interfaces;
using System.Linq;
using Gizmox.WebGUI.Common.Resources;

namespace Library.Template.Controls
{
    public partial class TemplateEditUpload : EditControl 
	{
        private string repository = null;
        public string Repository
        {
            get
            {
                return repository;
            }
            set
            {
                repository = value;
                editControl.Repository = repository;
            }
        }

        private string title = null;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                editControl.Title = title;
            }
        }

        private string filter = null;
        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
                editControl.Filter = filter;
            }
        }

        public TemplateEditUpload()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        public new string Value
        {
            get
            {
                return (string)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }
    }
}
