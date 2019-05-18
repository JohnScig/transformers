using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Data.Enums
{
    public enum OrganizationalLevel
    {
        [Description ("Firma")]
        Company,
        [Description("Divízia")]
        Division,
        [Description("Projekt")]
        Project,
        [Description("Oddelenie")]
        Department
    }
}
