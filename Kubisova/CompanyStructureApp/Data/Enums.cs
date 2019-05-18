using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data
{
    public class Enums
    {
    }

    public enum TypeOfNode
    {
        [Description("Firma")]
        Firm = 1,

        [Description("Divízia")]
        Division = 2,

        [Description("Projekt")]
        Project = 3,

        [Description("Oddelenie")]
        Department = 4
    }

    public static class EnumTranslateExtension
    {
        public static string ToDescriptionString(this TypeOfNode val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

    }

}
