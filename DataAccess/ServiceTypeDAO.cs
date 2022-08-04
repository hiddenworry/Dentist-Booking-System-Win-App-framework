using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceTypeDAO
    {
        public static List<ServiceType> GetServiceTypeList()
        {
            var ServiceTypeList = new List<ServiceType>();
            try
            {
                using (var context = new DBSContext())
                {
                    ServiceTypeList = context.ServiceTypes.ToList();

                }


            }
            catch (Exception ex) { }
            return ServiceTypeList;
        }

    }

}
