﻿using DatabaseCommunication;
using Logic;
using Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA04
{
    class MainViewModel
    {
        #region Constructor
        private Functions _functions = new Functions();
        #endregion

        #region Properties
        public List<NodeModel> ListOfCompanies { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfDivisions { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfProjects { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfDepartments { get; set; } = new List<NodeModel>();
        public List<EmployeeModel> ListOfEmployees { get; set; } = new List<EmployeeModel>();

        public EmployeeModel CompanyLead { get; set; } = new EmployeeModel();
        public EmployeeModel DivisionLead { get; set; } = new EmployeeModel();
        public EmployeeModel ProjectLead { get; set; } = new EmployeeModel();
        public EmployeeModel DepartmentLead { get; set; } = new EmployeeModel();
        #endregion

        #region Constructor
        public MainViewModel()
        {
            LoadListOfCompanies();
        }
        #endregion

        #region Loading Functions
        internal void LoadListOfCompanies()
        {
            ListOfCompanies = _functions.GetCompanies();

        }

        internal void LoadListOfDivisions(int parentNodeID)
        {
            ListOfDivisions = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfProjects(int parentNodeID)
        {
            ListOfProjects = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfDepartments(int parentNodeID)
        {
            ListOfDepartments = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfEmployees(int parentNodeID)
        {
            ListOfEmployees = _functions.GetEmployeesByNode(parentNodeID);
        }

        internal string GetLeader(int employeeID)
        {
            EmployeeModel employee = _functions.GetEmployeeByID(employeeID);
            return $"{employee.FirstName} {employee.LastName}";
        }
        #endregion

        #region Removal Functions
        internal void RemoveNode(int nodeID)
        {
            foreach (var item in _functions.GetChildren(nodeID))
            {
                RemoveNode(item.NodeID);
            }

            // Zamestnanci sa dajú vymazať jedným SQL príkazom a nie v cykle.
            foreach (var item in _functions.GetEmployeesByNode(nodeID))
            {
                _functions.RemoveEmployee(item.EmployeeID);
            }

            _functions.RemoveNode(nodeID);

        }

        internal void RemoveEmployee(int employeeID)
        {
            _functions.RemoveEmployee(employeeID);
        }
        #endregion
    }
}
