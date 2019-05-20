using Data.Models;
using Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class MainService
    {
        private StructureRepository _structureRepository = MainRepository.StructureRepository;
        private EmployeeRepository _employeeRepository = MainRepository.EmployeeRepository;
        private TestConnectionRepository _testConnectionRepository = MainRepository.TestConnectionRepository;

        #region Employee repository

        // Názov metódy je mätúci. Podľa názvu by som nečakal, že ho reálne vloží, ale iba skontroluje či existuje v DB.
        public bool IsEmployeeInserted(Employee employee)
        {
            return _employeeRepository.InsertEmployee(employee);
        }

        public bool IsEmployeeUpdated(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }

        public List<Employee> GetEmployeesList(int code)
        {
            return _employeeRepository.SelectEmployeesList(code);
        }

        public List<Employee> GetEmployeesList()
        {
            return _employeeRepository.SelectEmployeesList();
        }

        public Employee GetEmployee(int code)
        {
            return _employeeRepository.SelectEmployee(code);
        }

        #endregion

        #region Structure repository

        public Structure GetStructure(int code)
        {
            return _structureRepository.SelectStructure(code);
        }

        public List<Structure> GetStructuresList()
        {
            return _structureRepository.SelectStructureList();
        }

        public List<Structure> GetStructuresList(OrganizationLevel level)
        {
            return _structureRepository.SelectStructureList().Where(structure => structure.Level == level).ToList();
        }

        public List<Structure> GetStructuresList(int code, OrganizationLevel level)
        {
            return _structureRepository.SelectStructureList(code, level);
        }

        public bool IsStructureUpdated(Structure structure, int previousDirectorId)
        {
            return _structureRepository.UpdateStructure(structure, previousDirectorId);
        }

        public bool IsStructureInserted(Structure structure)
        {
            return _structureRepository.InsertStructure(structure);
        }

        #endregion

        public bool IsSqlConnectionOk()
        {
            return _testConnectionRepository.IsSqlConnectionOk();
        }

        public List<Employee> GetEveryEmployeeWhoIsNotDirector(int code)
        {
            // Vyberám si všetkých zamestnancov a všetky štruktúry firmy?
            List<Structure> structures = GetStructuresList();
            List<Employee> employees = GetEmployeesList();

            for (int i = 0; i < employees.Count; i++)
            {
                foreach (var structure in structures)
                {
                    if (structure.Employee != null && employees[i].ID == structure.Employee.ID && structure.Code != code)
                    {
                        employees.Remove(employees[i--]);
                        break;
                    }
                }
            }
            return employees;
        }

        public int GenerateCode()
        {
            // Premenná nie je potrebná.
            int dafaultCode = 1000;
            // 2 x volanie GetStructureList().
            if (GetStructuresList().Any())
            {
                return GetStructuresList().Max(structure => structure.Code) + 1;
            }
            else
            {
                return dafaultCode;
            }
        }

        public bool IsEmployeeDirector(Employee employee)
        {
            bool ret = false;

            if (employee.FirmStructure != null)
            {
                // Ak táto situácia môže nastať, stačí vybrať konkrétny záznam a nie celú štruktúru firmy.
                List<Structure> structures = _structureRepository.SelectStructureList();
                foreach (var structure in structures)
                {
                    if (structure.ID== employee.FirmStructure.ID)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}