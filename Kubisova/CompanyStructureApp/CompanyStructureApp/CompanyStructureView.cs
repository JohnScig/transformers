using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;


namespace CompanyStructureApp
{
    public partial class CompanyStructureView : Form
    {
        private CompanyStructureViewModel _companyStructureViewModel;
        private int _firmId; 

        public CompanyStructureView(CompanyStructureViewModel companyStructureViewModel, int firmId)
        {
            _companyStructureViewModel = companyStructureViewModel;
            _companyStructureViewModel.GetFirmById(firmId);
            _firmId = firmId;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            using (var addFirmView = new AddFirmView(new AddFirmViewModel(), Data.TypeOfNode.Division, _firmId))
            {
                addFirmView.Text = "Pridaj divíziu";
                addFirmView.StartPosition = FormStartPosition.CenterParent;
                addFirmView.ShowDialog();

                if (addFirmView.DialogResult == DialogResult.OK)
                {
                    _companyStructureViewModel.GetDivisions();
                    dGVDivision.DataSource = _companyStructureViewModel.Divisions;
                    LoadGridProjects();
                }
            }
        }

        private void CompanyStructureView_Load(object sender, EventArgs e)
        {
            txtFirmCode.Text = _companyStructureViewModel.Firm.CodeOfNode;
            txtFirmName.Text = _companyStructureViewModel.Firm.NameOfNode;

            LoadGridDivisions();
            LoadGridProjects();
            LoadGridDepartments();
        }

        private void LoadGridDivisions()
        {
            _companyStructureViewModel.GetDivisions();
            dGVDivision.DataSource = _companyStructureViewModel.Divisions;
            dGVDivision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDivision.Columns[0].Visible = false;
            dGVDivision.Columns[3].Visible = false;
            dGVDivision.Columns[4].Visible = false;
        }

        private void LoadGridProjects()
        {
            if (_companyStructureViewModel.Divisions.Count > 0)
            {
                _companyStructureViewModel.GetProjects(_companyStructureViewModel.Divisions[0].NodeId);
                dGVProject.DataSource = _companyStructureViewModel.Projects;
                dGVProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dGVProject.Columns[0].Visible = false;
                dGVProject.Columns[3].Visible = false;
                dGVProject.Columns[4].Visible = false;
            }
        }

        private void LoadGridDepartments()
        {
            if (_companyStructureViewModel.Divisions.Count > 0 &&_companyStructureViewModel.Projects !=null
                &&_companyStructureViewModel.Projects.Count>0)
            {
                _companyStructureViewModel.GetDepartments(_companyStructureViewModel.Projects[0].NodeId);
                dGVDepartment.DataSource = _companyStructureViewModel.Departments;
                dGVDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dGVDepartment.Columns[0].Visible = false;
                dGVDepartment.Columns[3].Visible = false;
                dGVDepartment.Columns[4].Visible = false;
            }
            else
            {
                dGVDepartment.DataSource = null;
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (dGVDivision.CurrentRow != null)
            {
                int index = dGVDivision.CurrentRow.Index;
                int divisionId = _companyStructureViewModel.Divisions[index].NodeId;

                using (var addFirmView = new AddFirmView(new AddFirmViewModel(), Data.TypeOfNode.Project, divisionId, _firmId))
                {
                    addFirmView.Text = "Pridaj projekt";
                    addFirmView.StartPosition = FormStartPosition.CenterParent;
                    addFirmView.ShowDialog();

                    if (addFirmView.DialogResult == DialogResult.OK)
                    {
                        _companyStructureViewModel.GetProjects(divisionId);
                        dGVProject.DataSource = _companyStructureViewModel.Projects;
                    }
                }
            }
        }

        private void dGVDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _companyStructureViewModel.GetProjects(_companyStructureViewModel.Divisions[e.RowIndex].NodeId);
            dGVProject.DataSource = null;
            dGVProject.DataSource = _companyStructureViewModel.Projects;
            dGVProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVProject.Columns[0].Visible = false;
            dGVProject.Columns[3].Visible = false;
            dGVProject.Columns[4].Visible = false;

            LoadGridDepartments();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (dGVProject.CurrentRow != null)
            {
                int index = dGVProject.CurrentRow.Index;
                int projectId = _companyStructureViewModel.Projects[index].NodeId;

                using (var addFirmView = new AddFirmView(new AddFirmViewModel(), Data.TypeOfNode.Department, projectId, _firmId))
                {
                    addFirmView.Text = "Pridaj oddelenie";
                    addFirmView.StartPosition = FormStartPosition.CenterParent;
                    addFirmView.ShowDialog();

                    if (addFirmView.DialogResult == DialogResult.OK)
                    {
                        _companyStructureViewModel.GetDepartments(projectId);
                        dGVDepartment.DataSource = _companyStructureViewModel.Departments;
                    }
                }
            }
        }

        private void dGVDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGVProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _companyStructureViewModel.GetDepartments(_companyStructureViewModel.Projects[e.RowIndex].NodeId);
            dGVDepartment.DataSource = null;
            dGVDepartment.DataSource = _companyStructureViewModel.Departments;
            dGVDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDepartment.Columns[0].Visible = false;
            dGVDepartment.Columns[3].Visible = false;
            dGVDepartment.Columns[4].Visible = false;
        }

        private void btnEmployeesOfDepartment_Click(object sender, EventArgs e)
        {
            if (dGVDepartment.CurrentRow != null)
            {
                int index = dGVDepartment.CurrentRow.Index;
                int departmentId = _companyStructureViewModel.Departments[index].NodeId;

                using (var employeesView = new EmployeesView(new EmployeesViewModel(), _firmId, departmentId))
                {
                    employeesView.StartPosition = FormStartPosition.CenterParent;
                    employeesView.ShowDialog();
                }
            }
        }
    }
}
