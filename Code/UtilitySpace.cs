using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilitySpace
    {

        public static ISpace GetRootSpace(ISpace space)
        {
            try
            {
                var owner = space.OwnerSpace;
                if (owner != null)
                    return GetRootSpace(owner);
                else
                    return space;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static ISpace GetParentOwner(ISpace space)
        {
            try
            {
                var owner = space.OwnerSpace;
                if (owner != null)
                {
                    var parentOwner = owner.OwnerSpace;
                    return parentOwner;
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
