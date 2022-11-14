using EmpApp.DAL;
using EmpApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeDAL _employee;

        public EmployeeController(IEmployeeDAL employee)
        {
            _employee = employee;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees() 
        {
            return Ok(_employee.GetEmployees());
        }


        [HttpGet]
        [Route("api/[controller]/{EmployeeID}")]
        public IActionResult GetEmployees(Guid EmployeeID)
        {
            var employee = _employee.GetEmployees(EmployeeID);
            if(employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with id: {EmployeeID} does not exist");
        }

        //public IActionResult GetEmployees(Guid EmployeeID)
        //{
        //    return Ok(_employee.GetEmployees());
        //}

        [HttpPost]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEdit(Guid EmployeeID, Employee employee)
        {
            var exisitingEmployee = _employee.GetEmployees(EmployeeID);
            if(exisitingEmployee != null)
            {
                employee.EmployeeID = exisitingEmployee.EmployeeID;
                _employee.EditEmployee(employee);
            }

            return Ok(employee);
        }

    }
}
