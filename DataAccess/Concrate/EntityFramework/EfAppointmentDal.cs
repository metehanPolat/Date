using DataAccess.Abstrack;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfAppointmentDal : IAppointmentDal
    {
        public void Add(Appointment entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(Appointment entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return context.Set<Appointment>().SingleOrDefault(filter);
            }
        }

        public List<Appointment> GetAll(Expression<Func<Appointment, bool>> filter = null)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return filter == null ? context.Set<Appointment>().ToList() : context.Set<Appointment>().Where(filter).ToList();
            }
        }

        public void Update(Appointment entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var updatedEntity = context.Entry(entity);//bağlar, ilişkilendirir
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<RandevuDetay> GetWantApointment(int id)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var result = from p in context.Appointments
                             join c in context.Doctors
                             on p.DoctorId equals c.Id
                             select new RandevuDetay
                             {
                                 RandevuId = p.Id,
                                 UserId = p.UserId,
                                 Bolum = c.Profession,
                                 DoctorName = c.Name,
                                 Tarih = p.Tarih,
                                 Saat = p.Saat
                             };
                return result.Where(k => k.UserId == id && k.Tarih > DateTime.Today).OrderBy(k => k.Tarih).ToList();
            }
        }
    }
}
