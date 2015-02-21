﻿using Gizmox.WebGUI.Forms;
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

        public string GetCap(Control control, string mask)
        {
            try
            {
                var script = GetJScript("Cap.js");
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

        internal string GetMouseOverColor(Control control, Color enterBackColor, Color leaveBackColor, Color downBackColor,
                Color enterBorderColor, Color leaveBorderColor, int durationEnter = 125, int durationLeave=500)
        {
            try
            {
                var script = GetJScript("MouseOverColor.js");
                string enterBackColorHtml = GetColor(enterBackColor);
                string leaveBackColorHtml = GetColor(leaveBackColor);
                string downBackColorHtml = GetColor(downBackColor);
                string enterBorderColorHtml = GetColor(enterBorderColor);
                string leaveBorderColorHtml = GetColor(leaveBorderColor);
                var vwgId = GetVWGId(control);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$enterBackColor$", enterBackColorHtml);
                script = script.Replace("$leaveBackColor$", leaveBackColorHtml);
                script = script.Replace("$downBackColor$", downBackColorHtml);
                script = script.Replace("$enterBorderColor$", enterBorderColorHtml);
                script = script.Replace("$leaveBorderColor$", leaveBorderColorHtml);
                script = script.Replace("$durationEnter$", durationEnter.ToString());
                script = script.Replace("$durationLeave$", durationLeave.ToString());

                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetColor(Color color)
        {
            try
            {
                string colorHtml = color.ToArgb().ToString("X");
                if(colorHtml.Length>=3)
                    colorHtml = "#" + colorHtml.Substring(2);
                return colorHtml;
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
                string backColorHtml = GetColor(backColor);
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

        public string GetTime(Control editHour, Control editMinutes, string mask)
        {
            try
            {
                var script = GetJScript("Time.js");
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

        public string GetDate(Control editDay, Control editMonth, Control editYear, string mask)
        {
            try
            {
                var script = GetJScript("Date.js");
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


        public string GetCountries(Control editCity, Control editCounty, string mask)
        {
            try
            {
                var script = GetJScript("Countries.js");
                var vwgCityId = GetVWGId(editCity);
                var vwgCountyId = GetVWGId(editCounty);
                script = script.Replace("$vwgCityId$", vwgCityId);
                script = script.Replace("$vwgCountyId$", vwgCountyId);
                script = script.Replace("$mask$", mask);
                return script;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public string GetReadOnly(Control control)
        {
            try
            {
                var script = GetJScript("ReadOnly.js");
                var vwgId = GetVWGId(control);
                string foreColor = GetColor(control.ForeColor);
                script = script.Replace("$vwgId$", vwgId);
                script = script.Replace("$foreColor$", foreColor);
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
                var jscript = UtilityWeb.GetResource(this, fileJS, "JS", "ES");
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
