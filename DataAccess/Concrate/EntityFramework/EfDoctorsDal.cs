using DataAccess.Abstrack;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfDoctorsDal : IDoctorsDal
    {
        public void Add(Doctor entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(Doctor entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Doctor Get(Expression<Func<Doctor, bool>> filter)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return context.Set<Doctor>().SingleOrDefault(filter);
            }
        }

        public List<Doctor> GetAll(Expression<Func<Doctor, bool>> filter = null)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return filter == null ? context.Set<Doctor>().ToList() : context.Set<Doctor>().Where(filter).ToList();
            }
        }

        public void Update(Doctor entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var updatedEntity = context.Entry(entity);//bağlar, ilişkilendirir
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
