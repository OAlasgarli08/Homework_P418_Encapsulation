using Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    internal class EmployeeController
    {
        public void EmployeeSalary()
        {
            EmployeeService employeeService = new EmployeeService();

            employeeService.EmployeeSalary(1000, 2000);
        }
    }
}
