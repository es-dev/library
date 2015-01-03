using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityJQuery
    {
        public string GetNumeric(Control control, string mask)
        {
            try
            {
                var script = GetJScript("Numeric.js");
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetDecimal(Control control, string mask)
        {
            try
            {
                var script = GetJScript("Decimal.js");
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal string GetMouseOverColor(Control control, Control container, Color enterBackColor, Color leaveBackColor, Color downBackColor,
                Color enterBorderColor, Color leaveBorderColor, int duration = 125)
        {
            try
            {
                var script = GetJScript("MouseOverColor.js");
                string enterBackColorHtml = enterBackColor.ToArgb().ToString("X");
                enterBackColorHtml = "#" + enterBackColorHtml.Substring(2);
                string leaveBackColorHtml = leaveBackColor.ToArgb().ToString("X");
                leaveBackColorHtml = "#" + leaveBackColorHtml.Substring(2);
                string downBackColorHtml = downBackColor.ToArgb().ToString("X");
                downBackColorHtml = "#" + downBackColorHtml.Substring(2);
                string enterBorderColorHtml = enterBorderColor.ToArgb().ToString("X");
                enterBorderColorHtml = "#" + enterBorderColorHtml.Substring(2);
                string leaveBorderColorHtml = leaveBorderColor.ToArgb().ToString("X");
                leaveBorderColorHtml = "#" + leaveBorderColorHtml.Substring(2);
                var vwgId = GetVWGId(control);
                var vwgContainerId = GetVWGId(container);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$vwgContainerId$", vwgContainerId);
                script = script.Replace("$enterBackColor$", enterBackColorHtml);
                script = script.Replace("$leaveBackColor$", leaveBackColorHtml);
                script = script.Replace("$downBackColor$", downBackColorHtml);
                script = script.Replace("$enterBorderColor$", enterBorderColorHtml);
                script = script.Replace("$leaveBorderColor$", leaveBorderColorHtml);
                script = script.Replace("$duration$", duration.ToString());

                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetOpacity(Control control, Color backColor, double opacity = 0.5,  int duration = 0)
        {
            try
            {
                var script = GetJScript("Opacity.js");
                var vwgId = GetVWGId(control);
                string backColorHtml = backColor.ToArgb().ToString("X");
                backColorHtml = "#" + backColorHtml.Substring(2);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$opacity$", opacity.ToString().Replace(",", "."));
                script = script.Replace("$backColor$", backColorHtml);
                script = script.Replace("$duration$", duration.ToString());
                return script;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetOra(Control editHour, Control editMinutes, string mask)
        {
            try
            {
                var script = GetJScript("Ora.js");
                var vwgHourId = GetVWGId(editHour);
                var vwgMinuteId = GetVWGId(editMinutes);
                script = script.Replace("$vwgHourId$", vwgHourId);
                script = script.Replace("$vwgMinuteId$", vwgMinuteId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetData(Control editDay, Control editMonth, Control editYear, string mask)
        {
            try
            {
                var script = GetJScript("Data.js");
                var vwgDayId = GetVWGId(editDay);
                var vwgMonthId = GetVWGId(editMonth);
                var vwgYearId = GetVWGId(editYear);
                script = script.Replace("$vwgDayId$", vwgDayId);
                script = script.Replace("$vwgMonthId$", vwgMonthId);
                script = script.Replace("$vwgYearId$", vwgYearId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        

        public string GetMask(Control control, string mask)
        {
            try
            {
                var script = GetJScript("Mask.js");
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetPartitaIva(Control control, string mask)
        {
            try
            {
                var script = GetJScript("PartitaIva.js");
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetCodiceFiscale(Control control, string mask)
        {
            try
            {
                var script = GetJScript("CodiceFiscale.js");
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        private string GetJScript(string fileJS)
        {
            try
            {
                var assembly = this.GetType().Assembly;
                var assemblyName=assembly.GetName();
                string pathResourceJS = assemblyName.Name.Replace("ES.", "") + ".JS.";
                string pathFileJS = pathResourceJS + fileJS;
                var stream = assembly.GetManifestResourceStream(pathFileJS);
                var reader = new System.IO.StreamReader(stream);
                var jscript = reader.ReadToEnd();
                reader.Close();
                return jscript;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetVWGId(Control control)
        {
            try
            {
                var prefix = (control.GetType() == typeof(TextBox) ? "TRG" : "VWG");
                var vwgId = prefix + "_" + control.ID.ToString();
                return vwgId;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


       
    }
}
