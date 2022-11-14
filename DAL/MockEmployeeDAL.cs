using EmpApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.DAL
{
    public class MockEmployeeDAL : IEmployeeDAL
    {
        private List<Employee> employee = new List<Employee>()
        {
            new Employee
            {
                EmployeeID = Guid.NewGuid(),
                FirstName = "Prince",
                LastName = "Ugochikwu",
                Phone = "08030908386",
                Address = "121 Isolo Estate"
            },
            new Employee
             {
                EmployeeID = Guid.NewGuid(),
                FirstName = "Brian",
                LastName = "Onyeche",
                Phone = "08058780266",
                Address = "121 Isolo Estate"
            },

            new Employee
             {
                EmployeeID = Guid.NewGuid(),
                FirstName = "Fedinand",
                LastName = "Gurero",
                Phone = "+9190987549",
                Address = "Drive Way Mall Oklahoma."
            },
        };
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return employee;
        }

        public Employee GetEmployees(Guid EmployeeID)
        {
            return employee.SingleOrDefault(e => e.EmployeeID == EmployeeID);
        }
    }
}
