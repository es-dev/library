using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Forms;
using Library.Code.Enum;
using Library.Controls;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if(relativeNamespace!=null && relativeNamespace.Length>0)
                    pathAssemby = pathAssemby.Replace(relativeNamespace+".","");
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

        private static string GetRootPath(System.Web.HttpContext context)
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

        private static string GetRootUrl(System.Web.HttpContext context)
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
                if (control != null && label != null && label.Length>0)
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
                            int left = location.X + control.Left;
                            if (left + control.Width > parentForm.Width)
                                left = location.X - control.Width;
                            int top = location.Y + owner.Height;
                            if (top + control.Height > parentForm.Height)
                                top = location.Y - control.Height;
                            control.Top = top;
                            control.Left = left;
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
                        parentForm.Controls.Remove(control);
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
