using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code.Enum
{
    public class UtilityEnum
    {
       
    }

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

}
