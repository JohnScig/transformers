using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

namespace CompanyStructureApp
{
    public class EmployeesViewModel
    {
        public List<Employee> Employees { get; set; }
        

        public void GetEmployeesByFirmId(int firmId)
        {
            Employees = RepositoryManager.EmployeeRepository.GetEmployeesByFirmId(firmId);
        }

        public void GetEmployeesByDepartmentId(int departmentId)
        {
            Employees = RepositoryManager.EmployeeRepository.GetEmployeesByDepartmentId(departmentId);
        }

        public void DeleteEmployee(int employeeId)
        {
            RepositoryManager.EmployeeRepository.DeleteEmployeeById(employeeId);
        }
    }
}
