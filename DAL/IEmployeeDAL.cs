using EmpApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.DAL
{
     public interface IEmployeeDAL
    {
        List<Employee> GetEmployees();

        Employee GetEmployees(Guid EmployeeID);

        Employee AddEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

        Employee DeleteEmployee(Employee employee); 
    }
}
