using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Forms;
using Library.Controls;
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
                if (label != null && control != null)
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

        public static string GetText(Control control, string mask = null)
        {
            try
            {
                if (control != null)
                {
                    string text = control.Text;
                    if (mask != null)
                        text = text.Replace(mask, null);
                    return text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static void SetText(Control control, object value, string mask = null)
        {
            try
            {
                if (control != null)
                    control.Text = (value == null || (string)value == "" ? mask : (string)value);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void SetImage(bool editing, bool changed, bool verified, PictureBox imgEdit)
        {
            try
            {
                imgEdit.Visible = false;
                if (editing)
                {
                    if (verified)
                    {
                        if (changed)
                        {
                            imgEdit.Image = "Images.edit_lightblue.png";
                            imgEdit.Visible = true;
                        }
                        else
                            imgEdit.Image = "";
                    }
                    else
                    {
                        imgEdit.Image = "Images.edit_red.png";
                        imgEdit.Visible = true;
                    }
                }
                else
                    imgEdit.Image = "";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        internal static int GetInteger(Control control, string mask)
        {
            try
            {
                var value = GetIntegerNothing(control, mask);
                if (value != null)
                    return (int)value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        internal static int? GetIntegerNothing(Control control, string mask)
        {
            try
            {
                if (control != null)
                {
                    string text = GetText(control, mask);
                    if (text != null && UtilityValidation.IsNumeric(text))
                    {
                        int value = Convert.ToInt32(text);
                        return value;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal static void SetBackColor(TextBox editValue, bool editing)
        {
            try
            {
                if (editValue != null)
                    editValue.BackColor = (editing ? Color.WhiteSmoke : Color.Transparent);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
