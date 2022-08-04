using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Appointment GetAppointmentById(int id)
        {
            return AppointmentDAO.Instance.GetAppointmentById(id);
        }

        public List<Appointment> GetAppointmentList(DateTime date, string phone, int dentistId, int status)
        {
            return AppointmentDAO.Instance.GetAppointmentList(date, phone, dentistId, status);
        }


        List<Appointment> IAppointmentRepository.GetAppointmentByStatus(int status) => AppointmentDAO.Instance.GetAppointmentByStatus(status);

        public List<string> GetTimeOptionByDate(DateTime time, List<Service> serviceList, Appointment appointment)
        {
            double totalTime = 0;
            foreach (Service service in serviceList)
            {
                totalTime = totalTime + service.EstimatedTime;
            }
            DateTime openTime = DateTime.ParseExact("07:00", "HH:mm", CultureInfo.InvariantCulture);
            DateTime closeTime = DateTime.ParseExact("19:00", "HH:mm", CultureInfo.InvariantCulture);
            DateTime start;
            DateTime end;

            List<string> availableOptions = new List<string>();

            foreach (Account account in new AccountRepository().GetActiveDentistList())
            {
                start = openTime;
                List<string> options = new List<string>();
                List<string> workingHourList = AppointmentDAO.Instance.GetWorkingTimeListByDateAndDentist(time, account.Id, appointment);

                //tạo và kiểm tra các time option trong cả ngày làm việc
                while (true)
                {
                    end = start.AddMinutes(totalTime * 60);
                    if (end > closeTime) break;
                    DateTime workingStart;
                    DateTime workingEnd;
                    bool valid = true;
                    foreach (string workingHour in workingHourList)
                    {
                        workingStart = DateTime.ParseExact(workingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture);
                        workingEnd = DateTime.ParseExact(workingHour.Split('-')[1], "HH:mm", CultureInfo.InvariantCulture);

                        if ((workingStart < end) && (workingEnd > start)) valid = false;
                    }
                    if (valid) options.Add(start.ToString("HH:mm") + "-" + end.ToString("HH:mm"));
                    start = start.AddMinutes(30);
                }

                availableOptions = availableOptions.Union(options).ToList();
            }
            return availableOptions.OrderBy(o => DateTime.ParseExact(o.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture)).ToList();
        }

        public int GetGetSuitableDentistByDate(DateTime time, List<Service> serviceList, string newWorkingHour, Appointment appointment)
        {
            DateTime start = DateTime.ParseExact(newWorkingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(newWorkingHour.Split('-')[1], "HH:mm", CultureInfo.InvariantCulture);

            List<int> dentistIdList = new List<int>();
            List<double> dentistTotalHour = new List<double>();
            double total;
            //kiểm tra từng nha sĩ
            foreach (Account account in new AccountRepository().GetActiveDentistList())
            {
                List<string> options = new List<string>();
                List<string> workingHourList = AppointmentDAO.Instance.GetWorkingTimeListByDateAndDentist(time, account.Id, appointment);
                total = 0;
                    
                    DateTime workingStart;
                    DateTime workingEnd;
                    bool valid = true;
                    foreach (string workingHour in workingHourList)
                    {
                        workingStart = DateTime.ParseExact(workingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture);
                        workingEnd = DateTime.ParseExact(workingHour.Split('-')[1], "HH:mm", CultureInfo.InvariantCulture);
                        total += (workingEnd - workingStart).TotalMinutes;
                        if ((workingStart < end) && (workingEnd > start)) valid = false;
                    }
                if (valid)
                {
                    dentistIdList.Add(account.Id);
                    dentistTotalHour.Add(total);
                }
            }
            return dentistIdList[dentistTotalHour.IndexOf(dentistTotalHour.Min())];
        }

        public Appointment AddAppointment(Appointment appointment)
        {
            return AppointmentDAO.Instance.AddAppointment(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            AppointmentDAO.Instance.UpdateAppointment(appointment);
        }

        public Appointment GetWaitingAppointmentByCustomerId(int id)
        {
            return AppointmentDAO.Instance.GetWaitingAppointmentByCustomerId(id);
        }


        public List<Appointment> GetAppointmentsForAdmin() => AppointmentDAO.Instance.GetAppointmentsForAdmin();


        public Appointment GetAppointmentNearest() => AppointmentDAO.Instance.GetAppointmentNearest();

        public List<Appointment> Get10FistappointmentDoneCustomerById(int id)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            var list = AppointmentDAO.Instance.GetListAppointmentByCustomerId(id);
            for (int i = 0; i < list.Count(); i++)
            {
                if (i == 10)
                {
                    return appointmentList;
                }
                appointmentList.Add(list[i]);
            }
            return appointmentList;
        }

        public void UpdateAppointmentByDoctor(Appointment appointment)
                => AppointmentDAO.Instance.UpdateAppointmentByDoctor(appointment);

        public List<Appointment> FilterAppointmentForAdmin(DateTime time, string phone, int dentistId, int status) => AppointmentDAO.Instance.FilterAppointmentForAdmin(time,  phone, dentistId, status);
       
    }
}
