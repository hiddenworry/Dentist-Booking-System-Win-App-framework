using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentServiceDAO
    {
        private static AppointmentServiceDAO instance;
        private static readonly object instanceLock = new object();
        private AppointmentServiceDAO() { }
        public static AppointmentServiceDAO Instance { 
            get {
                lock (instanceLock) {
                    if (instance == null) 
                    { 
                        instance = new AppointmentServiceDAO();
                    }
                    return instance;
                }
            } 
        }

        public List<AppointmentService> GetAppointmentServiceListByAppointmentId(int id) {
            try
            {
                using (DBSContext DBSContext = new DBSContext()) { 
                    return DBSContext.AppointmentServices.Where(x => x.AppointmentId == id).ToList();
                }
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
        }

        public void AddAppointmentService(AppointmentService appointmentService)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    DBSContext.AppointmentServices.Add(appointmentService);
                    DBSContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteAppointmentServiceByAppointmentId(int id)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    List<AppointmentService> tmp = DBSContext.AppointmentServices.Where(ad => ad.AppointmentId == id).ToList();
                    DBSContext.AppointmentServices.RemoveRange(tmp);
                    DBSContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
