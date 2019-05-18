using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;
using Data;

namespace CompanyStructureApp
{
    public class FirmsViewModel
    {
        public List<CompanyStructureNode> Firms { get; set; }

        public void GetFirms()
        {
            Firms = RepositoryManager.CompanyStructureNodeRepository.GetNodesByType(TypeOfNode.Firm);
        }
        
        public int GetFirmIdByIndex(int index)
        {
            return Firms[index].NodeId;
        }
    }
}
