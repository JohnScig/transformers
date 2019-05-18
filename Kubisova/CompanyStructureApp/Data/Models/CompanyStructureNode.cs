using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data.Models
{
    public class CompanyStructureNode
    {
        public int NodeId { get; set; }

        [DisplayName("Kód")]
        public string CodeOfNode { get; set; }

        [DisplayName("Názov")]
        public string NameOfNode { get; set; }

        [DisplayName("Typ")]
        public TypeOfNode TypeOfNode { get; set; }
        
        public int? NodeAboveId { get; set; }

        [DisplayName("Vedúci")]
        public int? HeadOfNodeId { get; set; }

        public override string ToString()
        {
            return $"{TypeOfNode.ToDescriptionString()} {NameOfNode}";
        }
    }
}
