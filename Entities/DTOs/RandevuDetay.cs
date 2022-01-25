using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RandevuDetay
    {
        public int RandevuId { get; set; }
        public string Bolum { get; set; }
        public string DoctorName { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }
        public int UserId { get; set; }
        
    }
}
