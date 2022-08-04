using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Service
    {
        public Service()
        {
            AppointmentServices = new HashSet<AppointmentService>();
        }

        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double EstimatedTime { get; set; }
        public decimal Status { get; set; }

        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<AppointmentService> AppointmentServices { get; set; }
    }
}
