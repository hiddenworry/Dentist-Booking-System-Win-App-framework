using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentServices = new HashSet<AppointmentService>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DentistId { get; set; }
        public DateTime Time { get; set; }
        public string WorkingHour { get; set; }
        public string Description { get; set; }
        public decimal Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Account Dentist { get; set; }
        public virtual ICollection<AppointmentService> AppointmentServices { get; set; }
    }
}
