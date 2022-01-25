using Business.Concrete;
using DataAccess.Concrate.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
