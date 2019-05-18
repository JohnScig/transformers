using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace CompanyStructureCore
{
    public class EmployeeFactory
    {
        public Employee CreateEmployee(int firmId, string title, string name, string surname, string phone, string email)
        {
            Employee employee = new Employee();

            employee.FirmId = firmId;
            employee.Title = title;
            employee.Name = name;
            employee.Surname = surname;
            employee.Phone = phone;
            employee.Email = email;

            return employee;
        }

        public Employee CreateEmployee(int departmentId, int firmId, string title, string name, string surname, string phone, string email)
        {
            Employee employee = new Employee();

            employee.NodeId = departmentId;
            employee.FirmId = firmId;
            employee.Title = title;
            employee.Name = name;
            employee.Surname = surname;
            employee.Phone = phone;
            employee.Email = email;

            return employee;
        }
    }
}
