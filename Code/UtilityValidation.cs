using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityValidation
    {
        public static bool IsDate(string day, string month, string year)
        {
            try
            {
                bool validated = false;
                if (IsNumeric(day) && IsNumeric(month) && IsNumeric(year))
                {
                    int _day = Convert.ToInt32(day);
                    int _month = Convert.ToInt32(month);
                    int _year = Convert.ToInt32(year);
                    if (_year > 0 && _month > 0)
                    {
                        var daysInMonth = DateTime.DaysInMonth(_year, _month);
                        validated = (_day <= daysInMonth && _day>0);
                    }
                }
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static DateTime? GetDate(string day, string month, string year)
        {
            try
            {
                if (IsDate(day, month, year))
                {
                    int _day = Convert.ToInt32(day);
                    int _month = Convert.ToInt32(month);
                    int _year = Convert.ToInt32(year);
                    var date = new DateTime(_year, _month, _day);
                    return date;
                }                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static bool IsNumeric(string text)
        {
            try
            {
                if (text != null && text!="")
                {
                    foreach (Char c in text)
                    {
                        if (!Char.IsNumber(c))
                            return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static string GetString(object value)
        {
            try
            {
                string text = null;
                if (value != null)
                    text = (string)value;
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static bool IsEmail(string text)
        {
            try
            {
                String pattern = @"^([\w\d\-\.]+)@{1}(([\w\d\-]{1,67})|([\w\d\-]+\.[\w\d\-]{1,67}))\.(([a-zA-Z\d]{2,4})(\.[a-zA-Z\d]{2})?)$";
                Regex regex = new Regex(pattern);
                bool validated = regex.IsMatch(text);
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }


        public static bool IsCodiceFiscale(string text)
        {
            try
            {
                String pattern = @"^[A-Za-z]{6}[0-9]{2}[A-Za-z]{1}[0-9]{2}[A-Za-z]{1}[0-9]{3}[A-Za-z]{1}$";
                Regex regex = new Regex(pattern);
                bool validated = regex.IsMatch(text);
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

            return false;
        }

        public static bool IsPartitaIva(string text)
        {
            try
            {
                String pattern = @"^[0-9]{11}$";
                Regex regex = new Regex(pattern);
                bool validated = regex.IsMatch(text);
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static bool IsTime(string hours, string minutes)
        {
            try
            {
                bool validated = false;
                if (IsNumeric(hours) && IsNumeric(minutes) )
                {
                    int _hours = Convert.ToInt32(hours);
                    int _minutes = Convert.ToInt32(minutes);
                    if(_hours>=0 && _hours<=24 && _minutes>=0 && _minutes<=59)
                    {
                        validated = true;
                    }
                }
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
    }
}
