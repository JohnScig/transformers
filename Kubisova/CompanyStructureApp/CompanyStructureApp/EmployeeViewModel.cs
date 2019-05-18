using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using CompanyStructureCore;

namespace CompanyStructureApp
{
    public class EmployeeViewModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee EmployeeToEdit { get; set; }
        public bool IsEdit { get; set; }
        public bool IsShow { get; set; }

        private EmployeeFactory _employeeFactory;

        public EmployeeViewModel()
        {
            _employeeFactory = new EmployeeFactory();
        }

        public void AddEmployee(int firmId)
        {
            Employee employee = _employeeFactory.CreateEmployee(firmId, Title, Name, Surname, Phone, Email);
            RepositoryManager.EmployeeRepository.AddEmployee(employee);
        }

        public void AddEmployee(int firmId, int departmentId)
        {
            Employee employee = _employeeFactory.CreateEmployee(departmentId, firmId, Title, Name, Surname, Phone, Email);
            RepositoryManager.EmployeeRepository.AddEmployeeWithDepartment(employee);
        }

        public void GetEmployeeById(int employeeId)
        {
            EmployeeToEdit = RepositoryManager.EmployeeRepository.GetEmployeeById(employeeId);
        }

        public void EditEmployee()
        {
            RepositoryManager.EmployeeRepository.UpdateEmployee(EmployeeToEdit);
        }
    }
}
