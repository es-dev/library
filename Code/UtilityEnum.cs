using System;
using System.Collections.Generic;
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

    public class StatoDescrizione
    {
        private string separator = "{;}";
        public TypeStato Stato = TypeStato.None;
        public string Descrizione = null;

        public StatoDescrizione(TypeStato stato, string descrizione)
        {
            try
            {
                this.Stato = stato;
                this.Descrizione = descrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public class UtilityEnum
        {

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
                    this.Stato = (TypeStato)System.Enum.Parse(typeof(TypeStato), _stato);
                    this.Descrizione = descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public string ToString()
        {
            try
            {
                var value = Stato.ToString() + separator + Descrizione;
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
