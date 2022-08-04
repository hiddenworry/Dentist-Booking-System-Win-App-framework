using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class AppointmentService
    {
        public int AppointmentId { get; set; }
        public int ServiceId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Service Service { get; set; }
    }
}
