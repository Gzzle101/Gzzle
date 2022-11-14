using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
