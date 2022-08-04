using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAppointmentServiceRepository
    {
        List<AppointmentService> GetAppointmentServiceListByAppointmentId(int id);
        void AddAppointmentService(AppointmentService appointmentService);
        void DeleteAppointmentServiceByAppointmentId(int id);
    }
}
