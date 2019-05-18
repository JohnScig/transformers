using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Data.Enums
{
    public static class EnumDescriptor
    {
        public static string GetEnumDescription<T>(T value)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType()
                .GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Any() ? attributes[0].Description.ToString() : value.ToString();
        }

        public static Dictionary<T, string> GetEnumMembers<T>()
        {
            Dictionary<T, string> enumMembers = new Dictionary<T, string>();
            var enumValues = Enum.GetValues(typeof(T));
            foreach (T value in enumValues)
            {
                enumMembers.Add(value, GetEnumDescription(value));
            }
            return enumMembers;
        }
    }

}
