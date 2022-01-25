using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }
        public void Add(Appointment entity)
        {
            _appointmentDal.Add(entity);
        }

        public void Delete(Appointment entity)
        {
            _appointmentDal.Delete(entity);
        }

        public List<Appointment> GetAllByUserId(int id)
        {
            return _appointmentDal.GetAll(p => p.UserId == id && p.Tarih > DateTime.Today);
        }

        public void Update(Appointment entity)
        {
            _appointmentDal.Update(entity);
        }
        public List<RandevuDetay> Getir(int id)
        {
            return _appointmentDal.GetWantApointment(id);
        }

        public List<Appointment> GetAll()
        {
            return _appointmentDal.GetAll();
        }
    }

}
