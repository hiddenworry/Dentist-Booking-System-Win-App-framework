using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        public List<Service> FilterService(Service service) => ServiceDAO.Instance.FilterService(service);
       
        public List<Service> GetActiveServiceList() => ServiceDAO.Instance.GetActiveServiceList();

        public List<Service> GetServiceFromServiceType(int ServiceTypeId) => ServiceDAO.Instance.GetServiceFromServiceType(ServiceTypeId);
      

        public List<Service> GetServices() => ServiceDAO.Instance.GetServices();

        public void SaveService(Service service) => ServiceDAO.Instance.SaveService(service);

        public void UpdateService(Service service) => ServiceDAO.Instance.UpdateService(service);

        public List<Service> GetServiceListByAppointmentId(int id) => ServiceDAO.Instance.GetServiceListByAppointmentId(id);

        public Service GetServiceByName(string name) => ServiceDAO.Instance.GetServiceByName(name); 
    }
}
