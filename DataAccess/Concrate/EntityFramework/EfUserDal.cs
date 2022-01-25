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
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(User entity)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (HospitalDateContext context = new HospitalDateContext())
            {
                return filter == null ? context.Set<User>().ToList() : context.Set<User>().Where(filter).ToList();
            }
        }

        public void Update(User entity)
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
