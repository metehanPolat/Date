using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllByUserId(int id);
        List<Appointment> GetAll();
        void Add(Appointment entity);
        void Update(Appointment entity);
        void Delete(Appointment entity);
    }
}
