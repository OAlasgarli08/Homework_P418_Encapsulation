using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Services
{
    internal class EmployeeService
    {
        private static EmployeeModel[] Employees()
        {


            EmployeeModel employee1 = new()
            {
                id = 1,
                name = "Person 1",
                surname = "Surname 1",
                age = 30,
                salary = 2000
            };

            EmployeeModel employee2 = new()
            {
                id = 2,
                name = "Person 2",
                surname = "Surname 2",
                age = 18,
                salary = 800
            };

            EmployeeModel employee3 = new()
            {
                id = 3,
                name = "Person 3",
                surname = "Surname 3",
                age = 25,
                salary = 1500
            };

            EmployeeModel[] employees = { employee1, employee2, employee3 };

            return employees;
        }

        public void EmployeeSalary(int a, int b)
        {
            EmployeeModel[] employees = Employees();

            foreach (var employee in employees)
            {
                if (employee.salary >= a && employee.salary <= b)
                {
                    Console.WriteLine($"{employee.name} {employee.surname} has a salary in between $1000 and $2000");
                }
            }          
        }

    }
}
