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
        public string GetOpacity(Control control, Color backColor, double opacity = 0.5,  int duration = 0)
        {
            try
            {
                var script = GetJScript("Opacity.js");
                var vwgID = GetVWGID(control);
                string backColorHtml = backColor.ToArgb().ToString("X");
                backColorHtml = "#" + backColorHtml.Substring(2);
                script = script.Replace("$vwgID$", vwgID);
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

        public string GetEditData(Control editDay, Control editMonth, Control editYear, string mask)
        {
            try
            {
                var script = GetJScript("EditData.js");
                var vwgEditDay = GetVWGID(editDay);
                var vwgEditMonth = GetVWGID(editMonth);
                var vwgEditYear = GetVWGID(editYear);
                script = script.Replace("$VWGDay$", vwgEditDay);
                script = script.Replace("$VWGMonth$", vwgEditMonth);
                script = script.Replace("$VWGYear$", vwgEditYear);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetEditOra(Control editHour, Control editMinutes, Control minuteUP, Control minuteDown, string mask)
        {
            try
            {
                var script = GetJScript("EditOra.js");
                var vwgEditHour = GetVWGID(editHour);
                var vwgEditMinute = GetVWGID(editMinutes);
                var vwgMinuteUP = GetVWGID(minuteUP);
                var vwgMinuteDown = GetVWGID(minuteDown);
                script = script.Replace("$VWGHour$", vwgEditHour);
                script = script.Replace("$VWGMinute$", vwgEditMinute);
                script = script.Replace("$VWGMinuteUP$", vwgMinuteUP);
                script = script.Replace("$VWGMinuteDown$", vwgMinuteDown);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetEditText(Control editControl, string mask)
        {
            try
            {
                var script = GetJScript("EditText.js");
                var vwgEditControl = GetVWGID(editControl);
                script = script.Replace("$VWGEditControlID$", vwgEditControl);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetEditPassword(Control editControl, string mask)
        {
            try
            {
                var script = GetJScript("EditPassword.js");
                var vwgEditControl = GetVWGID(editControl);
                script = script.Replace("$VWGEditControlID$", vwgEditControl);
                script = script.Replace("$mask$", mask);

                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetEditPartitaIva(Control editControl, string mask)
        {
            try
            {
                var script = GetJScript("EditPartitaIva.js");
                var vwgEditControl = GetVWGID(editControl);
                script = script.Replace("$VWGEditControlID$", vwgEditControl);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public string GetEditCodiceFiscale(Control editControl, string mask)
        {
           try
            {
                var script = GetJScript("EditCodiceFiscale.js");
                var vwgEditControl = GetVWGID(editControl);
                script = script.Replace("$VWGEditControlID$", vwgEditControl);
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

        private string GetVWGID(Control control)
        {
            try
            {
                var prefix = (control.GetType() == typeof(TextBox) ? "TRG" : "VWG");
                var vwgID = prefix + "_" + control.ID.ToString();
                return vwgID;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }







    }
}
