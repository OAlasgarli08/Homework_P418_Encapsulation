using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    internal class EmployeeModel : BaseEntity
    {
        public int salary { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

    }
}
