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
                    this.stato = (TypeStato)System.Enum.Parse(typeof(TypeStato), _stato);
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
