using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;
using CompanyStructureCore;
using Data;

namespace CompanyStructureApp
{
    public class AddFirmViewModel
    {
        public string CodeOfNode { get; set; }
        public string NameOfNode { get; set; }
        public int HeadOfNodeId { get; set; }

        public List<Employee> Employees { get; set; }
        private NodeFactory _nodeFactory;

        public AddFirmViewModel()
        {
            _nodeFactory = new NodeFactory();
        }

        public void GetEmployeesByFirmId(int firmId)
        {
            Employees = RepositoryManager.EmployeeRepository.GetEmployeesByFirmId(firmId);
        }

        public void AddNode(TypeOfNode typeOfNode)
        {
            CompanyStructureNode node = new CompanyStructureNode();

            if (HeadOfNodeId == 0)
            {
                node = _nodeFactory.CreateFirm(CodeOfNode, NameOfNode, typeOfNode);
                RepositoryManager.CompanyStructureNodeRepository.AddFirm(node);
            }
            else
            {
                node = _nodeFactory.CreateFirm(CodeOfNode, NameOfNode, typeOfNode, HeadOfNodeId);
                RepositoryManager.CompanyStructureNodeRepository.AddFirmWithHead(node);
            }
        }

        public void AddNode(TypeOfNode typeOfNode, int parentId)
        {
            CompanyStructureNode node = new CompanyStructureNode();

            if (HeadOfNodeId == 0)
            {
                node = _nodeFactory.CreateNode(CodeOfNode, NameOfNode, typeOfNode, parentId);
                RepositoryManager.CompanyStructureNodeRepository.AddNode(node);
            }
            else
            {
                node = _nodeFactory.CreateNode(CodeOfNode, NameOfNode, typeOfNode, parentId, HeadOfNodeId);
                RepositoryManager.CompanyStructureNodeRepository.AddNodeWithHead(node);
            }
        }
    }

    
}
