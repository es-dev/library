using Library.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityCountries
    {
        IList<Countries.City> cities = null;

        public UtilityCountries()
        {
            try
            {
                var countires = new Countries();
                cities = countires.ReadCities();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }



        public string GetCode(string description, string county)
        {
            try
            {
                var code = (from q in cities where q.Description == description && q.County == county select q.Code).FirstOrDefault();
                return code;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
