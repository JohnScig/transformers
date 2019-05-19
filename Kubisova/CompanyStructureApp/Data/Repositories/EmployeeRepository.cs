using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    static class Constants
    {
        public const string CONNECTION_STRING = @"Server=STANO-NTB\SQLEXPRESS;Database=Kubisova;Trusted_Connection=true";
    }

    public class EmployeeRepository
    {
        // Technicky rovnaká metóda ako tá za ňou.
        public List<Employee> GetEmployeesByFirmId(int firmId)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Employee where FirmId = @firmId";
                    command.Parameters.Add("@firmId", SqlDbType.Int).Value = firmId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.EmployeeId = reader.GetInt32(0);
                            employee.NodeId = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                            employee.FirmId = reader.GetInt32(2);
                            employee.Title = reader.GetString(3);
                            employee.Name = reader.GetString(4);
                            employee.Surname = reader.GetString(5);
                            employee.Phone = reader.GetString(6);
                            employee.Email = reader.GetString(7);

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Employee where NodeId = @nodeId";
                    command.Parameters.Add("@nodeId", SqlDbType.Int).Value = departmentId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.EmployeeId = reader.GetInt32(0);
                            employee.NodeId = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                            employee.FirmId = reader.GetInt32(2);
                            employee.Title = reader.GetString(3);
                            employee.Name = reader.GetString(4);
                            employee.Surname = reader.GetString(5);
                            employee.Phone = reader.GetString(6);
                            employee.Email = reader.GetString(7);

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            Employee employee = new Employee();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Employee where EmployeeId = @employeeId";
                    command.Parameters.Add("@employeeId", SqlDbType.Int).Value = Id;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee.EmployeeId = reader.GetInt32(0);
                            employee.NodeId = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                            employee.FirmId = reader.GetInt32(2);
                            employee.Title = reader.GetString(3);
                            employee.Name = reader.GetString(4);
                            employee.Surname = reader.GetString(5);
                            employee.Phone = reader.GetString(6);
                            employee.Email = reader.GetString(7);
                        }
                    }
                }
            }

            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Employee (FirmId, Title, Name, Surname, Phone, Email) 
                                                values(@firmId, @title, @name, @surname,@phone,@email)";

                    command.Parameters.Add("@firmId", SqlDbType.NVarChar).Value = employee.FirmId;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = employee.Title;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = employee.Surname;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddEmployeeWithDepartment(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Employee (NodeId, FirmId, Title, Name, Surname, Phone, Email) 
                                                values(@nodeId, @firmId, @title, @name, @surname,@phone,@email)";

                    command.Parameters.Add("@nodeId", SqlDbType.NVarChar).Value = employee.NodeId;
                    command.Parameters.Add("@firmId", SqlDbType.NVarChar).Value = employee.FirmId;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = employee.Title;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = employee.Surname;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Employee 
                                            set Title = @title,
                                                Name = @name, 
                                                Surname = @surname, 
                                                Phone = @phone, 
                                                Email = @email 
                                            where EmployeeId = @employeeId";

                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = employee.Title;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = employee.Surname;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;
                    command.Parameters.Add("@employeeId", SqlDbType.Int).Value = employee.EmployeeId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployeeById(int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"delete Employee where EmployeeId = @employeeId";
                    command.Parameters.Add("@employeeId", SqlDbType.Int).Value = employeeId;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
