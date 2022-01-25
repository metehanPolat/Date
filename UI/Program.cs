using Business.Concrete;
using DataAccess.Concrate.EntityFramework;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager user = new UserManager(new EfUserDal());
            foreach (var us in user.GetAll())
            {
                Console.WriteLine(us.Name);
            }
        }
    }
}
