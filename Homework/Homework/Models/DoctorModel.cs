using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    internal class DoctorModel : BaseEntity
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
    }
}
