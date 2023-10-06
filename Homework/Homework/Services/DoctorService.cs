using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Homework.Services
{
    internal class DoctorService
    {
        private static DoctorModel[] Doctors()
        {
            DoctorModel doctor1 = new()
            {
                id = 1,
                name = "Doctor 1",
                surname = "Surname 1",
                address = "Place 1",
                birthday = new DateTime(200, 10, 18)
            };

            DoctorModel doctor2 = new()
            {
                id = 2,
                name = "Doctor 2",
                surname = "Surname 2",
                address = "Place 2",
                birthday = new DateTime(1994, 10, 18)
            };

            DoctorModel doctor3 = new()
            {
                id = 3,
                name = "Doctor 3",
                surname = "Surname 3",
                address = "Place 3",
                birthday = new DateTime(1990,10,18)               
            };

            DoctorModel[] doctors = { doctor1, doctor2, doctor3 };

            return doctors;
        }

        public void DoctorAges(DateTime a, DateTime b)
        {
            DoctorModel[] doctors = Doctors();
            foreach(var doctor in doctors)
            {
                if(doctor.birthday >  a && doctor.birthday < b)
                {
                    Console.WriteLine($"{doctor.name} {doctor.surname} {doctor.address} {doctor.birthday}");
                }
            }
        }
    }
}
