﻿using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Forms;
using Library.Code;
using Library.Controls;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Code
{
    public class UtilityWeb
    {
        public static string GetResource(object context, string fileNameResource, string pathRelativeResource, string relativeNamespace = null)
        {
            try
            {
                var assembly = context.GetType().Assembly;
                var assemblyName = assembly.GetName();
                string pathAssemby = assemblyName.Name;
                if (relativeNamespace != null && relativeNamespace.Length > 0)
                    pathAssemby = pathAssemby.Replace(relativeNamespace + ".", "");
                string pathResource = pathAssemby + "." + pathRelativeResource + ".";
                string pathFile = pathResource + fileNameResource;
                var stream = assembly.GetManifestResourceStream(pathFile);
                var reader = new System.IO.StreamReader(stream);
                string content = null;
                while (!reader.EndOfStream)
                {
                    content += reader.ReadLine() + Environment.NewLine;
                }
                reader.Close();
                return content;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<string> GetResources(object context, string fileNameResource, string pathRelativeResource, string relativeNamespace = null)
        {
            try
            {
                var assembly = context.GetType().Assembly;
                var assemblyName = assembly.GetName();
                string pathAssemby = assemblyName.Name;
                if (relativeNamespace != null && relativeNamespace.Length > 0)
                    pathAssemby = pathAssemby.Replace(relativeNamespace + ".", "");
                string pathResource = pathAssemby + "." + pathRelativeResource + ".";
                string pathFile = pathResource + fileNameResource;
                var stream = assembly.GetManifestResourceStream(pathFile);
                var reader = new System.IO.StreamReader(stream);
                var contents = new List<string>();
                while (!reader.EndOfStream)
                {
                    var content = reader.ReadLine() + Environment.NewLine;
                    contents.Add(content);
                }
                reader.Close();
                return contents;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootPath(IContext context)
        {
            try
            {
                if (context != null)
                {
                    var pathRoot = GetRootPath(context.HttpContext);
                    return pathRoot;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootPath(System.Web.HttpContext context)
        {
            try
            {
                if (context != null && context.Request != null)
                {
                    var pathRoot = context.Request.PhysicalApplicationPath;
                    return pathRoot;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootPath()
        {
            try
            {
                var pathRoot = System.AppDomain.CurrentDomain.BaseDirectory;
                return pathRoot;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootUrl()
        {
            try
            {
                var rootUrl = VirtualPathUtility.ToAbsolute("~/");
                return rootUrl;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootUrl(IContext context)
        {
            try
            {
                if (context != null)
                {
                    var rootUrl = GetRootUrl(context.HttpContext);
                    return rootUrl;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRootUrl(System.Web.HttpContext context)
        {
            try
            {
                if (context != null)
                {
                    var url = context.Request.Url.AbsoluteUri;
                    if (url != null && url.Length > 0)
                    {
                        var pos = url.IndexOf("Route");
                        if (pos > 0)
                        {
                            var rootUrl = url.Substring(0, pos - 1);
                            return rootUrl;
                        }
                        else
                            return url;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Form GetParentForm(Control control)
        {
            try
            {
                if (control != null)
                {
                    if (control.Parent == null)
                        return (Form)control;
                    else
                        return GetParentForm(control.Parent);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Control GetPopup(Control control)
        {
            try
            {
                if (control != null)
                {
                    if (control is Popup)
                        return (Popup)control;
                    else
                        return GetPopup(control.Parent);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static void SetSiteName(Control control, string label)
        {
            try
            {
                if (control != null && label != null && label.Length > 0)
                {
                    var site = control.Site;
                    if (site != null)
                    {
                        var siteName = site.Name;
                        if (siteName != null && !siteName.Contains("edit"))
                        {
                            string name = "edit" + label.Replace(" ", "");
                            site.Name = name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void SetCheckItems(ListView editCheckList, ItemCheckEventArgs objArgs)
        {
            try
            {
                bool multiSelect = editCheckList.MultiSelect;
                if (editCheckList.CheckedItems.Count > 0)
                {
                    if (objArgs.NewValue == CheckState.Checked)
                    {
                        var itemChecked = editCheckList.Items[objArgs.Index];
                        itemChecked.Selected = true;
                        if (!multiSelect)
                        {
                            foreach (ListViewItem item in editCheckList.Items)
                            {
                                if (item != itemChecked)
                                {
                                    item.Checked = false;
                                    item.Selected = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static Point GetLocation(Control control)
        {
            try
            {
                int top = 0;
                int left = 0;
                if (!(control is Form))
                {
                    left = control.Left;
                    top = control.Top;
                }
                var parent = control.Parent;
                if (parent != null)
                {
                    var location = GetLocation(parent);
                    top += location.Y;
                    left += location.X;
                }
                return new Point(left, top);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(Point);
        }

        public static JQContainer GetJQContainer(Form parentForm)
        {
            try
            {
                var container = new JQContainer();
                container.JQOpacity = 0.25;
                container.JQBackColor = Color.Black;
                container.Location = new Point(0, 0);
                container.Size = parentForm.Size;
                container.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                return container;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static void AddJQControl(Control owner, Control control, JQTypePosition position = JQTypePosition.Center)
        {
            try
            {
                var parentForm = GetParentForm(owner);
                if (parentForm != null)
                {
                    var jqContainer = GetJQContainer(parentForm);
                    if (jqContainer != null)
                    {
                        if (position == JQTypePosition.Center)
                        {
                            control.Top = (parentForm.Height - control.Height) / 2;
                            control.Left = (parentForm.Width - control.Width) / 2;
                        }
                        else if (position == JQTypePosition.Docked)
                        {
                            var location = GetLocation(owner);
                            int left = location.X;
                            if (left + control.Width > parentForm.Width)
                                left = location.X + owner.Width - control.Width;
                            int top = location.Y + owner.Height;
                            if (top + control.Height > parentForm.Height)
                                top = location.Y - control.Height;
                            control.Top = top;
                            control.Left = left;
                        }
                        var parent = control.Parent;
                        if (parent != null)
                        {
                            parent.Controls.Remove(control);
                            control.Visible = true;
                            jqContainer.Tag = "exist";
                        }

                        parentForm.Controls.Add(jqContainer);
                        parentForm.Controls.Add(control);
                        jqContainer.BringToFront();
                        control.BringToFront();
                        control.Tag = jqContainer;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void RemoveJQControl(Control control)
        {
            try
            {
                var parentForm = GetParentForm(control);
                if (parentForm != null)
                {
                    var jqContainer = (JQContainer)control.Tag;
                    if (jqContainer != null)
                    {
                        parentForm.Controls.Remove(jqContainer);
                        var tag = (string)jqContainer.Tag;
                        if (tag != "exist")
                            parentForm.Controls.Remove(control);
                        else
                            control.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static IList<IGroupControl> GetEditGroupControls(Control control)
        {
            try
            {
                var groupControl = control;
                if (groupControl is IGroupControl)
                    groupControl = control.Parent;

                var container = groupControl.Parent;
                var controls = (from Control q in container.Controls where q is IGroupControl && q != groupControl select (IGroupControl)q).ToList();
                if (controls != null)
                {
                    var _group = ((IGroupControl)control).Group;
                    controls = (from IGroupControl q in controls where q.Group == _group select q).ToList();
                    return controls;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static void SetEditGroupControls(Control control, bool value)
        {
            try
            {
                var editControls = GetEditGroupControls(control);
                if (editControls != null)
                {
                    foreach (IEditControl editControl in editControls)
                        editControl.Value = value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void ClearEditControls(IList<Gizmox.WebGUI.Forms.Control> controls)
        {
            try
            {
                foreach (var control in controls)
                {
                    if (control is IEditControl)
                    {
                        var editControl = (IEditControl)control;
                        editControl.Value = null;
                        if (control is IComboControl)
                        {
                            var comboControl = (IComboControl)editControl;
                            comboControl.Model = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void SetTooltipText(Control.ControlCollection controls, ToolTip toolTip)
        {
            try
            {
                if (controls != null)
                {
                    foreach (Control control in controls)
                    {
                        SetTooltipText(control, toolTip);
                        if (control.HasChildren)
                            SetTooltipText(control.Controls, toolTip);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void SetTooltipText(Control control, ToolTip tooltip)
        {
            try
            {
                if (control != null && control.GetType() == typeof(Label))
                {
                    var label = (Label)control;
                    if (!label.AutoSize)
                    {
                        var text = control.Text;
                        if (text != null && text.Length > 0)
                        {
                            var chars = text.ToCharArray().Count();
                            var charsVisible = chars;
                            var width = control.Width;
                            var height = control.Height;
                            var dW = control.Font.SizeInPoints;
                            var dH = dW;
                            if (dW != 0)
                            {
                                var rows = (int)(height / dH);
                                var cols = (int)(width / dW);
                                charsVisible = rows * cols;
                            }

                            if (charsVisible < chars)
                            {
                                var length = charsVisible - 3;
                                if (length <= 0)
                                    length = 1;
                                var textEllippsis = text.Substring(0, length) + "...";
                                control.Text = textEllippsis;
                                tooltip.SetToolTip(control, text);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }

}
