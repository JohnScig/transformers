using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Data.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployeesOfDepartment(string departmentCode)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, FirstName, LastName, Title, Phone, Email, DepartmentCode 
                                        FROM Employees WHERE DepartmentCode = @departmentCode";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@departmentCode", SqlDbType.NVarChar).Value = departmentCode;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.ID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employee.DepartmentCode = reader.IsDBNull(6) ? null : reader.GetString(6);
                            employees.Add(employee);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT ID, FirstName, LastName, Title, Phone, Email, DepartmentCode 
                                        FROM Employees";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.ID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employee.DepartmentCode = reader.IsDBNull(6) ? null : reader.GetString(6);
                            employees.Add(employee);
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                }
                return employees;
            }
        }

        public Employee GetManagerOfSection(int? managerId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"SELECT E.ID, FirstName, LastName, Title, Phone, Email, DepartmentCode 
                                        FROM Employees AS E
                                        JOIN Sections AS S ON E.ID = S.ManagerID 
                                        WHERE E.ID = @managerId";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@managerId", SqlDbType.Int).Value = managerId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.ID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employee.DepartmentCode = reader.IsDBNull(6) ? null : reader.GetString(6);
                            return employee;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public bool InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"INSERT INTO Employees (FirstName, LastName, Title, Phone, Email, DepartmentCode)
                                        VALUES (@name, @lastName, @title, @phone, @email, @departmentCode)";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.FirstName;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employee.LastName;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = employee.Title ?? null;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;
                    command.Parameters.Add("@departmentCode", SqlDbType.NVarChar).Value = employee.DepartmentCode;
                    return (command.ExecuteNonQuery() > 0);
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Employees SET 
                                        FirstName = @name, 
                                        LastName = @lastName, 
                                        Title = @title, 
                                        Phone = @phone, 
                                        Email = @email, 
                                        DepartmentCode = @departmentCode
                                        WHERE ID = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = employee.ID;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.FirstName;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employee.LastName;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = employee.Title ?? null;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;
                    command.Parameters.Add("@departmentCode", SqlDbType.NVarChar).Value = employee.DepartmentCode;
                    return (command.ExecuteNonQuery() > 0);
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string sqlQueryDelete = @"DELETE FROM Employees WHERE ID =  @id";
                string sqlQueryUpdate = @"UPDATE Sections SET ManagerID = NULL WHERE ManagerID = @id";
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = employeeId;
                    try
                    {
                        command.CommandText = sqlQueryUpdate;
                        command.ExecuteNonQuery();
                        command.CommandText = sqlQueryDelete;
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.StackTrace);
                        Debug.WriteLine(e.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.StackTrace);
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }
    }
}
