using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace CompanyStructureApp
{
    public class CompanyStructureViewModel
    {
        public CompanyStructureNode Firm {get;set;}
        public List<CompanyStructureNode> Divisions { get; set; }
        public List<CompanyStructureNode> Projects { get; set; }
        public List<CompanyStructureNode> Departments { get; set; }

        public void GetFirmById(int firmId )
        {
            Firm =  RepositoryManager.CompanyStructureNodeRepository.GetNodeById(firmId);
        }

        public void GetDivisions()
        {
            Divisions = RepositoryManager.CompanyStructureNodeRepository.GetNodesByTypeAndNodeAboveId(TypeOfNode.Division, Firm.NodeId);
        }

        public void GetProjects(int divisionId)
        {
            Projects = RepositoryManager.CompanyStructureNodeRepository.GetNodesByTypeAndNodeAboveId(TypeOfNode.Project, divisionId);
        }

        public void GetDepartments(int projectId)
        {
            Departments = RepositoryManager.CompanyStructureNodeRepository.GetNodesByTypeAndNodeAboveId(TypeOfNode.Department, projectId);
        }
    }
}
