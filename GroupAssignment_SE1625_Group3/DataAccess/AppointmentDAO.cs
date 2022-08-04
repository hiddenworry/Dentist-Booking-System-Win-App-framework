using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentDAO
    {
        private static AppointmentDAO instance;
        private static readonly object instanceLock = new object();
        private AppointmentDAO() { }
        public static AppointmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppointmentDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Appointment> GetAppointmentList(DateTime time, string phone, int dentistId, int status)
        {
            try
            {
                using(DBSContext DBSContext = new DBSContext())
                {
                    return (
                        from a in DBSContext.Appointments.Include(a => a.Customer).Include(a => a.Dentist)
                        join c in DBSContext.Customers on a.CustomerId equals c.Id
                        where 
                            a.Time == time && 
                            c.Phone.Contains(phone) && 
                            (a.DentistId == dentistId || dentistId == 0) && 
                            (a.Status == status || status == 0)
                        select a
                    ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    return DBSContext.Appointments.Include(a => a.Customer).Include(a => a.Dentist).FirstOrDefault(c => c.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Appointment> GetAppointmentByStatus(int status)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Appointments.Where(c => c.Status == status).ToList();
                }

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } }

        public List<string> GetWorkingTimeListByDateAndDentist(DateTime time, int dentistId, Appointment appointment)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    if(appointment != null )
                    return DBSContext.Appointments.Where(a => a.Time == time && a.DentistId == dentistId && a.Id != appointment.Id && a.Status == 1)
                        .Select(a => a.WorkingHour).ToList();
                    else return DBSContext.Appointments.Where(a => a.Time == time && a.DentistId == dentistId && a.Status == 1)
                        .Select(a => a.WorkingHour).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Appointment AddAppointment(Appointment appointment)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    DBSContext.Appointments.Add(appointment);
                    DBSContext.SaveChanges();
                    return appointment;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    DBSContext.Entry<Appointment>(appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    DBSContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Appointment GetWaitingAppointmentByCustomerId(int id)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    return DBSContext.Appointments.FirstOrDefault(a => a.CustomerId == id && a.Status == 1);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<Appointment> GetAppointmentsForAdmin()
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    return DBSContext.Appointments.Include(a => a.Customer).Include(a => a.Dentist).ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


                    public Appointment GetAppointmentNearest() // lấy ra appointment gần nhất
                    {
                        try
                        {
                            using (var context = new DBSContext())
                            {
                                Appointment nearest = null;
                                nearest = (from appointment in context.Appointments
                                           orderby appointment.Id ascending
                                           where appointment.Status == 2 && appointment.Time.Date == DateTime.Now.Date
                                                                         && appointment.Time.Month == DateTime.Now.Month
                                                                         && appointment.Time.Year == DateTime.Now.Year
                                           select appointment).FirstOrDefault();
                                if (nearest == null)
                                {
                                    throw new Exception("No customer now");
                                }
                                nearest.Status = 4;
                                context.Appointments.Update(nearest);
                                context.SaveChanges();
                                return nearest;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    

        public void UpdateAppointmentByDoctor(Appointment appointment)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var a = context.Appointments.SingleOrDefault(x => x.Id == appointment.Id);
                    a.Description = appointment.Description;
                    a.Status = appointment.Status;
                    context.Appointments.Update(a);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Appointment> GetListAppointmentByCustomerId(int customerId)
        {
            try
            {
                using (var context = new DBSContext())
                {
                   var list = from appointment in context.Appointments
                              where appointment.CustomerId == customerId && appointment.Status == 2
                              select appointment;
                    return list.ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Appointment> FilterAppointmentForAdmin(DateTime time, string phone, int dentistId, int status)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    var query =  from a in DBSContext.Appointments.Include(a => a.Customer).Include(a => a.Dentist)
                                          join c in DBSContext.Customers on a.CustomerId equals c.Id
                                          select a;
                    if (!string.IsNullOrEmpty(time.ToString()))
                    {
                        query = query.Where(a => a.Time.Date == time.Date);
                    }
                    if (!string.IsNullOrEmpty(phone))
                    {
                        query = query.Where(a => a.Customer.Phone.Contains(phone));
                    }
                    if (!string.IsNullOrEmpty(dentistId.ToString()) && dentistId != 0)
                    {
                        query = query.Where(a => a.DentistId == dentistId);
                    }
                    if (!string.IsNullOrEmpty(status.ToString()) && status != 0)
                    {
                        query = query.Where(a => a.Status == status);
                    }

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
