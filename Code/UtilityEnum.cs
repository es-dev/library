using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library.Code.Enum
{
    public enum TypeFormat
    {
        None,
        StringND,
        Euro,
        DateDDMMYYYY
    }

    public enum TypeReport
    {
        None,
        DOC,
        XLS,
        PDF
    }
    
    public enum TypeState
    {
        None,
        Critical,
        Warning,
        Normal
    }

    public enum TypeMessage
    {
        None,
        Info,
        Question,
        Alert,
        Confirm
    }

    public enum JQTypePosition
    {
        Center,
        Docked
    }

    public enum TypeDirection
    {
        Horizontal,
        Vertical
    }

    public enum TypeBehavior
    {
        Text,
        Password,
        Numeric,
        Decimal,
        Percent,
        CodiceFiscale,
        PartitaIva,
        Email,
        Cap
    }

    public static class UtilityEnum
    {
        public static string GetDescription<TEnum>(TEnum value)
        {
            try
            {
                var field = value.GetType().GetField(value.ToString());
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                var description = (attribute == null ? value.ToString() : attribute.Description);
                return description;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static TEnum GetValue<TEnum>(string name)
        {
            try
            {
                if (name != null)
                {
                    var value = (TEnum)System.Enum.Parse(typeof(TEnum), name);
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TEnum);
        }
        
        //public static string GetDescription<TEnum>(string name)
        //{
        //    try
        //    {
        //        var value = GetValue<TEnum>(name);
        //        var field = value.GetType().GetField(value.ToString());
        //        var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
        //        var description = (attribute == null ? value.ToString() : attribute.Description);
        //        return description;
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilityError.Write(ex);
        //    }
        //    return null;
        //}

        public static IList<string> GetNames<TEnum>()
        {
            try
            {
                var names = System.Enum.GetNames(typeof(TEnum));
                var _names = (from q in names where q != "None" select q).ToList();
                return _names;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<TEnum> GetValues<TEnum>()
        {
            try
            {
                var names = GetNames<TEnum>();
                var values = (from q in names select GetValue<TEnum>(q)).ToList();
                return values;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        } 
        
        public static IList<DisplayValue> GetDisplayValues<TEnum>()
        {
            try
            {
                var values = GetValues<TEnum>();
                var displayValues = (from q in values select new DisplayValue { Value = q.ToString(), Display = GetDescription<TEnum>(q) }).ToList();
                return displayValues;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }


    public class DisplayValue
    {
        private string _value = null;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        private string display = null;
        public string Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
            }
        }

        public DisplayValue()
        {

        }

        public override string ToString()
        {
            try
            {
                var displayValue = display;
                return displayValue;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }

    public class DescriptionImage
    {
        private string separator = "{;}";
        public string Separator
        {
            get
            {
                return separator;
            }
        }
       
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

        private string image = null;
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public DescriptionImage()
        {
            
        }

        public DescriptionImage(string description, string image)
        {
            try
            {
                this.description = description;
                this.image = image;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public DescriptionImage(string value)
        {
            try
            {
                if (value != null)
                {
                    var splits = value.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 1)
                        this.description = splits[0].Trim();
                    if (splits.Length >= 2)
                        this.image = splits[1].Trim();

                }
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
                var value = description  + separator + image;
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }


    public class StateDescriptionImage : DescriptionImage
    {
        private TypeState state = TypeState.None;
        public TypeState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

       
        public StateDescriptionImage(TypeState state, string description, string image = null) : base(description, image)
        {
            try
            {
                this.state = state;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public StateDescriptionImage(string value) 
        {
            try
            {
                if (value != null)
                {
                    var splits = value.Split(new string[] { this.Separator }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 1)
                    {
                        string _state = splits[0].Trim();
                        this.state = UtilityEnum.GetValue<TypeState>(_state);
                    }
                    if (splits.Length >= 2)
                        this.Description = splits[1].Trim();
                    if (splits.Length >= 3)
                        this.Image = splits[2].Trim();

                }
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
                var value = state.ToString() + this.Separator + this.Description;
                if (this.Image != null)
                    value += this.Separator + this.Image;

                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }

}
