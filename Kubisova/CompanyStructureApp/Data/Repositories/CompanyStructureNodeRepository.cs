using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;


namespace Data.Repositories
{
    public class CompanyStructureNodeRepository
    {
        public void AddFirm(CompanyStructureNode node)
        {

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into CompanyStructureNode (CodeOfNode, NameOfNode, TypeOfNode)
                                            values(@codeOfNode, @nameOfNode, @typeOfNode)";

                    command.Parameters.Add("@codeOfNode", SqlDbType.NVarChar).Value = node.CodeOfNode;
                    command.Parameters.Add("@nameOfNode", SqlDbType.NVarChar).Value = node.NameOfNode;
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = node.TypeOfNode;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddFirmWithHead(CompanyStructureNode node)
        {

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into CompanyStructureNode (CodeOfNode, NameOfNode, TypeOfNode, HeadOfNodeId)
                                            values(@codeOfNode, @nameOfNode, @typeOfNode,@headOfNode)";

                    command.Parameters.Add("@codeOfNode", SqlDbType.NVarChar).Value = node.CodeOfNode;
                    command.Parameters.Add("@nameOfNode", SqlDbType.NVarChar).Value = node.NameOfNode;
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = node.TypeOfNode;
                    command.Parameters.Add("@headOfNodeId", SqlDbType.Int).Value = node.HeadOfNodeId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddNode(CompanyStructureNode node)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into CompanyStructureNode (CodeOfNode, NameOfNode, TypeOfNode, NodeAboveId)
                                            values(@codeOfNode, @nameOfNode, @typeOfNode, @nodeAboveId)";

                    command.Parameters.Add("@codeOfNode", SqlDbType.NVarChar).Value = node.CodeOfNode;
                    command.Parameters.Add("@nameOfNode", SqlDbType.NVarChar).Value = node.NameOfNode;
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = node.TypeOfNode;
                    command.Parameters.Add("@nodeAboveId", SqlDbType.Int).Value = node.NodeAboveId;
                   
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddNodeWithHead(CompanyStructureNode node)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into CompanyStructureNode (CodeOfNode, NameOfNode, TypeOfNode, NodeAboveId, HeadOfNodeId)
                                            values(@codeOfNode, @nameOfNode, @typeOfNode, @nodeAboveId,@headOfNodeId)";

                    command.Parameters.Add("@codeOfNode", SqlDbType.NVarChar).Value = node.CodeOfNode;
                    command.Parameters.Add("@nameOfNode", SqlDbType.NVarChar).Value = node.NameOfNode;
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = node.TypeOfNode;
                    command.Parameters.Add("@nodeAboveId", SqlDbType.Int).Value = node.NodeAboveId;
                    command.Parameters.Add("@headOfNodeId", SqlDbType.Int).Value = node.HeadOfNodeId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<CompanyStructureNode> GetNodesByType(TypeOfNode typeOfNode)
        {
            List<CompanyStructureNode> nodes = new List<CompanyStructureNode>();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from CompanyStructureNode where TypeOfNode = @typeOfNode";
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = typeOfNode;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CompanyStructureNode node = new CompanyStructureNode();
                            node.NodeId = reader.GetInt32(0);
                            node.CodeOfNode = reader.GetString(1);
                            node.NameOfNode = reader.GetString(2);
                            node.TypeOfNode = (TypeOfNode)reader.GetInt32(3);
                            node.HeadOfNodeId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                            nodes.Add(node);
                        }
                    }
                }
            }

            return nodes;
        }

        public List<CompanyStructureNode> GetNodesByTypeAndNodeAboveId(TypeOfNode typeOfNode, int parentId)
        {
            List<CompanyStructureNode> nodes = new List<CompanyStructureNode>();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from CompanyStructureNode where TypeOfNode = @typeOfNode and NodeAboveId = @nodeAboveId";
                    command.Parameters.Add("@typeOfNode", SqlDbType.Int).Value = typeOfNode;
                    command.Parameters.Add("@nodeAboveId", SqlDbType.Int).Value = parentId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CompanyStructureNode node = new CompanyStructureNode();
                            node.NodeId = reader.GetInt32(0);
                            node.CodeOfNode = reader.GetString(1);
                            node.NameOfNode = reader.GetString(2);
                            node.TypeOfNode = (TypeOfNode)reader.GetInt32(3);
                            node.NodeAboveId = reader.GetInt32(4);
                            node.HeadOfNodeId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                            nodes.Add(node);
                        }
                    }
                }
            }

            return nodes;
        }

        public CompanyStructureNode GetNodeById(int nodeId)
        {
            CompanyStructureNode node = new CompanyStructureNode();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from CompanyStructureNode where NodeId = @nodeId";
                    command.Parameters.Add("@nodeId", SqlDbType.Int).Value = nodeId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            node.NodeId = reader.GetInt32(0);
                            node.CodeOfNode = reader.GetString(1);
                            node.NameOfNode = reader.GetString(2);
                            node.TypeOfNode = (TypeOfNode)reader.GetInt32(3);
                        }
                    }
                }
            }

            return node;
        }
    }
}
