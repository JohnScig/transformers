using OrganizationalStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Models
{
    public class Section
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public OrganizationalLevel OrganizationalLevel { get; set; }
        public int? ManagerID { get; set; }
        public int? SuperiorSectionID { get; set; }
    }
}
