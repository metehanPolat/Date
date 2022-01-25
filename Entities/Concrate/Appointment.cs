using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Appointment:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }

    }
}
