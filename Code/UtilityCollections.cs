using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityCollections
    {
        public static bool IsContained(IEnumerable<int> ids, IEnumerable<int> containerIds)
        {
            try
            {
                foreach(var id in ids)
                {
                    if (!containerIds.Contains(id))
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
    }
}
