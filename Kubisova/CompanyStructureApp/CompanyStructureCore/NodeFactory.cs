using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

namespace CompanyStructureCore
{
    public class NodeFactory
    {
        public CompanyStructureNode CreateFirm(string codeOfNode, string nameOfNode, TypeOfNode typeOfNode)
        {
            CompanyStructureNode firm = new CompanyStructureNode();
            firm.CodeOfNode = codeOfNode;
            firm.NameOfNode = nameOfNode;
            firm.TypeOfNode = typeOfNode;

            return firm;
        }

        public CompanyStructureNode CreateFirm(string codeOfNode, string nameOfNode, TypeOfNode typeOfNode, int headOfNodeId)
        {
            CompanyStructureNode firm = new CompanyStructureNode();
            firm.CodeOfNode = codeOfNode;
            firm.NameOfNode = nameOfNode;
            firm.TypeOfNode = typeOfNode;
            firm.HeadOfNodeId = headOfNodeId;

            return firm;
        }

        public CompanyStructureNode CreateNode(string codeOfNode, string nameOfNode,TypeOfNode typeOfNode, int parentNode)
        {
            CompanyStructureNode node = new CompanyStructureNode();
            node.CodeOfNode = codeOfNode;
            node.NameOfNode = nameOfNode;
            node.TypeOfNode = typeOfNode;
            node.NodeAboveId = parentNode;

            return node;
        }

        public CompanyStructureNode CreateNode(string codeOfNode, string nameOfNode, TypeOfNode typeOfNode, int parentNode, int headOfNodeId)
        {
            CompanyStructureNode node = new CompanyStructureNode();
            node.CodeOfNode = codeOfNode;
            node.NameOfNode = nameOfNode;
            node.TypeOfNode = typeOfNode;
            node.NodeAboveId = parentNode;
            node.HeadOfNodeId = headOfNodeId;

            return node;
        }
    }
}
