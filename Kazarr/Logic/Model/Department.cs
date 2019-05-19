using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class Department
    {
        // Id by nemalo byť nullable, keďže je to primárny kľúč.
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentType { get; set; }
        public int? ParentDeparment { get; set; }
        public int? CheifEmployeeId { get; set; }

        public override string ToString()
        {
            // Načo je to v $ stringu?
            return $"{Name}";
        }
    }
}
