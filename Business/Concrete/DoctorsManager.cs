using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DoctorsManager : IDoctorsService
    {
        IDoctorsDal _doctorsDal;
        public DoctorsManager(IDoctorsDal doctorsDal)
        {
            _doctorsDal = doctorsDal;
        }

        public List<Doctor> GetAll()
        {
            return _doctorsDal.GetAll();
        }

        public List<Doctor> GetAllByProfession(string profession)
        {
            return _doctorsDal.GetAll(P => P.Profession == profession);
        }
    }
}
