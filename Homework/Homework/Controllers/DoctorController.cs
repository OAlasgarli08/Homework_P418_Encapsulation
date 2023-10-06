using Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    internal class DoctorController
    {
        public void DoctorAges(DateTime date1, DateTime date2)
        {
            DoctorService doctorService = new DoctorService();
            doctorService.DoctorAges(date1, date2);
        }
    }
}
