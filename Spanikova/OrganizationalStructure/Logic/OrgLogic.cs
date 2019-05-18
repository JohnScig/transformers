using OrganizationalStructure.Data.Enums;
using OrganizationalStructure.Data.Repositories;
using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Logic
{
    public class OrgStructureLogic
    {
        SectionRepository _sectionRepository = new SectionRepository();
        EmployeeRepository _employeeRepository = new EmployeeRepository();

        public List<Section> GetSectionsByLevel(OrganizationalLevel level)
        {
            return _sectionRepository.GetSectionsByLevel(level);
        }

        public List<Section> GetSections(OrganizationalLevel level, int? superiorSectionId)
        {
            return _sectionRepository.GetSections(level, superiorSectionId);
        }

        public List<Section> GetSectionsByCompany(string companyCode)
        {
            return _sectionRepository.GetSectionsByCompany(companyCode);
        }

        public List<Section> GetDepartmentsByCompany(string companyCode)
        {
            return _sectionRepository.GetDepartmentsByCompany(companyCode);
        }

        public Section GetCompanyByCode(string code)
        {
            return _sectionRepository.GetCompanyByCode(code);
        }

        public List<Employee> GetEmployeesByDepartment(string departmentCode)
        {
            return _employeeRepository.GetEmployeesOfDepartment(departmentCode);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employee GetManagerOfSection(int? managerId)
        {
            return _employeeRepository.GetManagerOfSection(managerId);
        }

        public Dictionary<OrganizationalLevel, string> GetOrganizationalLevels()
        {
            return EnumDescriptor.GetEnumMembers<OrganizationalLevel>();
        }

        public bool InsertSection(Section section)
        {
            return _sectionRepository.InsertSection(section);
        }

        public bool UpdateSection(Section section)
        {
            return _sectionRepository.UpdateSection(section);
        }

        public bool DeleteSection(string sectionCode, OrganizationalLevel orglevel)
        {
            return _sectionRepository.DeleteSection(sectionCode, orglevel);
        }

        public bool InsertEmployee(Employee employee)
        {
            return _employeeRepository.InsertEmployee(employee);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}
