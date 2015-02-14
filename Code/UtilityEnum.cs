using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code.Enum
{
    public enum TypeStato
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
        CodiceFiscale,
        PartitaIva,
        Email,
        Cap
    }

    public static class UtilityEnum
    {
        public static string GetDescription<TEnum>(this string name)
        {
            try
            {
                var value = GetValue<TEnum>(name);
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

        public static TEnum GetValue<TEnum>(string name)
        {
            try
            {
                var value = (TEnum)System.Enum.Parse(typeof(TEnum), name);
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TEnum);
        }

                
        public static IList<DisplayValue> GetDisplayValues<TEnum>()
        {
            try
            {
                var names = GetNames<TEnum>();
                var displayValues = (from q in names select new DisplayValue { Value = q, Display = GetDescription<TEnum>(q) }).ToList();
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


    public class StatoDescrizione
    {
        private string separator = "{;}";

        private TypeStato stato = TypeStato.None;
        public TypeStato Stato
        {
            get
            {
                return stato;
            }
            set
            {
                stato = value;
            }
        }

        private string descrizione = null;
        public string Descrizione
        {
            get
            {
                return descrizione;
            }
            set
            {
                descrizione = value;
            }
        }

        public StatoDescrizione(TypeStato stato, string descrizione)
        {
            try
            {
                this.stato = stato;
                this.descrizione = descrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public StatoDescrizione(string value)
        {
            try
            {
                var splits = value.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                if (splits.Length >= 2)
                {
                    string _stato = splits[0].Trim();
                    string descrizione = splits[1].Trim();
                    this.stato = UtilityEnum.GetValue<TypeStato>(_stato);
                    this.descrizione = descrizione;
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
                var value = stato.ToString() + separator + descrizione;
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
