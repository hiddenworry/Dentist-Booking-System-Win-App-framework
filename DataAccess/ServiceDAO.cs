using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDAO { 
        private static ServiceDAO instance;
        private static readonly object instancelock = new object();
        private ServiceDAO() { }
        public static ServiceDAO Instance { 
            get {
                lock (instancelock) {
                    if (instance == null) { 
                        instance = new ServiceDAO();
                    }
                    return instance;
                }
            }
        }

         public List<Service> GetServices()
    {
        var ServiceList = new List<Service>();
        try
        {
            using (var Context = new DBSContext())
            {
                ServiceList = Context.Services.Include(s => s.ServiceType).ToList();
            }

        }
        catch (Exception ex)
        {

        }
        return ServiceList;
    }

        public List<Service> GetServiceFromServiceType(int ServiceTypeId)
        {
            var ServiceList = new List<Service>();
            try
            {
                using (var Context = new DBSContext())
                {
                    ServiceList = Context.Services.Where(s => s.ServiceTypeId == ServiceTypeId).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return ServiceList;

        }

    public void SaveService(Service service)
    {

        try
        {
            using (var Context = new DBSContext())
            {
                Context.Services.Add(service);
                Context.SaveChanges();

            }

        }
        catch (Exception ex)
        {

        }

    }

    public void UpdateService(Service service)
    {

        try
        {
            using (var Context = new DBSContext())
            {
                Context.Entry<Service>(service).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Context.SaveChanges();

            }

        }
        catch (Exception ex) { }


    }

        public List<Service> GetActiveServiceList()
        {
            try
            {
                using (var Context = new DBSContext())
                {
                    return Context.Services.Include(s => s.ServiceType).Where(s => s.Status == 1).ToList();
                }
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
        }



    public List<Service> FilterService(Service service)

        {
            List<Service> filterList = new List<Service>();


            try
            {
                using (var Context = new DBSContext())
                {

                    var query = from s in Context.Services.Include(s => s.ServiceType) select s;
                    if (!string.IsNullOrEmpty(service.Name))
                    {
                        query = query.Where(s => s.Name.Contains(service.Name));
                    }
                    if (!string.IsNullOrEmpty(service.ServiceTypeId.ToString()) && service.ServiceTypeId != 0)
                    {
                        query = query.Where(s => s.ServiceTypeId == service.ServiceTypeId);
                    }
                    if (!string.IsNullOrEmpty(service.Status.ToString()) && service.Status != 0)
                    {
                        query = query.Where(s => s.Status == service.Status);
                        
                    }
                    filterList = query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return filterList;

        }
        public List<Service> GetServiceListByAppointmentId(int id)
        {
            using (var Context = new DBSContext())
            {


                return (
                    from s in Context.Services.Include(s => s.ServiceType)
                    join ad in Context.AppointmentServices on s.Id equals ad.ServiceId
                    where
                        ad.AppointmentId == id
                    select s
                ).ToList();

            }
        }

        public Service GetServiceByName(string name)
        {
            using (var Context = new DBSContext())
            {
                return Context.Services.SingleOrDefault(s => s.Name.Equals(name));

            }
        }
    }
}
