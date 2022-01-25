using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
        List<RandevuDetay> GetWantApointment(int id);

    }
}
