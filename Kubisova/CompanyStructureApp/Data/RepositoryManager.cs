using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace Data
{
    public static class RepositoryManager
    {
        public static EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public static CompanyStructureNodeRepository CompanyStructureNodeRepository = new CompanyStructureNodeRepository();
    }
}
