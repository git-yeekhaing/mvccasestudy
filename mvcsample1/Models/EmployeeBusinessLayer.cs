using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcsample1.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmpId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmpId,
                Name = "Pranaya",
                Gender = "Male",
                City = "Mumbai",
                Salary = 1000,
                Address = "Andheri"
            };
            return employee;
        }
    }
}