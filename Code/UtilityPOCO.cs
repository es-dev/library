using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Linq.Expressions;
using System.Reflection;

namespace Library.Code
{
    public class UtilityPOCO
    {
        public static TEntity GetObject<TEntity>(TEntity obj)
        {
            try
            {
                if (obj == null)
                    obj = Activator.CreateInstance<TEntity>();
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TEntity);
        }

        public static ICollection<TEntity> GetList<TEntity>(ICollection<TEntity> collection)
        {
            try
            {
                if (collection == null)
                    collection = new List<TEntity>(); 
                return collection;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static object GetValue(object obj, string propertyName)
        {
            try
            {
                if (obj != null)
                {
                    var type = obj.GetType();
                    var property = type.GetProperty(propertyName);
                    if (property != null)
                    {
                        var value = property.GetValue(obj);
                        return value;
                    }
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
