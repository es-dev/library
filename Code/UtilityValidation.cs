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

        public static DateTime? GetData(string day, string month, string year)
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
                int value = 0;
                bool isNumeric = int.TryParse(text, out value);
                return isNumeric;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static bool IsDecimal(string text)
        {
            try
            {
                decimal value = 0;
                bool isDecimal = decimal.TryParse(text, out value);
                return isDecimal;
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

        public static string GetStringEmpty(object value)
        {
            try
            {
                var text = GetString(value);
                if (text == null || text.Length == 0)
                    text = "";
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetStringND(object value)
        {
            try
            {
                var text = GetString(value);
                if (text == null || text.Length == 0)
                    text = "N/D";
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        internal static int GetInteger(string text)
        {
            try
            {
                var value = GetIntegerNothing(text);
                if (value != null)
                    return (int)value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        internal static int? GetIntegerNothing(string text)
        {
            try
            {
                if (text != null && UtilityValidation.IsNumeric(text))
                {
                    int value = Convert.ToInt32(text);
                    return value;
                }
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

        public static decimal GetDecimal(decimal? value)
        {
            try
            {
                if (value != null)
                    return value.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetDataND(DateTime? data)
        {
            try
            {
                string _data = "N/D";
                if(data!=null)
                    _data = data.Value.ToString("dd/MM/yyyy");

                return _data;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static DateTime GetData(DateTime? data)
        {
            try
            {
                var _data = DateTime.MinValue;
                if (data != null)
                    _data = data.Value;

                return _data;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        internal static string GetStringCleaned(string text)
        {
            try
            {
                if(text!=null)
                {
                    var value = text.Replace("\a", "").Replace("\r","").Replace("\n","").Replace("\t","").Replace("\f","").Replace("\b","").Trim();
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public static decimal GetEuro(string text)
        {
            try
            {
                if (text != null)
                {
                    decimal value = 0;
                    text = text.Replace("€", "");
                    var count = (from q in text.ToCharArray() where q == '.' || q == ',' select q).Count();
                    if (count == 1)
                        value = decimal.Parse(text.Replace(".", ","));
                    else if (count >= 2)
                    {
                        var _text = GetEuroThousandSeparator(text);
                        value = decimal.Parse(_text);
                    }
                    else
                        value = decimal.Parse(text);

                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetEuro(decimal? value)
        {
            try
            {
                if (value != null)
                {
                    var text= ((decimal)value).ToString("#,0.00") + "€";
                    return text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static string GetEuroThousandSeparator(string text)
        {
            try
            {
                if (text != null)
                {
                    var _text = text;
                    var posDot = text.LastIndexOf(".");
                    var posComma = text.LastIndexOf(",");
                    var pos = Math.Max(posDot, posComma);
                    if (pos >= 0)
                    {
                        _text = text.Substring(0, pos) + "," + text.Substring(pos + 1);
                        _text = _text.Replace(".", "");
                    }
                    return _text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
