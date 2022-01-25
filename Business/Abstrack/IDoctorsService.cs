using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IDoctorsService
    {
        List<Doctor> GetAllByProfession(string profession);
        List<Doctor> GetAll();
    }
}
