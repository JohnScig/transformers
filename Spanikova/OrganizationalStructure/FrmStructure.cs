using OrganizationalStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationalStructure.Logic;
using OrganizationalStructure.Models;

namespace OrganizationalStructure
{
    public partial class FrmStructure : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmStructure()
        {
            InitializeComponent();
            FillDtGrdSection(dtGrdCompanies, OrganizationalLevel.Company, null);
            EnablingBtns();
        }

        #region Buttons
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            using (FrmSectionDetail newForm = new FrmSectionDetail())
            {
                newForm.ShowDialog();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (FrmUpdateSection newForm = new FrmUpdateSection())
            {
                newForm.ShowDialog();
            }
            FillDtGrdSection(dtGrdCompanies, OrganizationalLevel.Company, null);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (FrmNewSection newForm = new FrmNewSection())
            {
                newForm.ShowDialog();
            }
            FillDtGrdSection(dtGrdCompanies, OrganizationalLevel.Company, null);
        }
        #endregion

        #region Fill DataGridViews

        // + Jedna metóda na naplnenie všetkých gridov.
        private void FillDtGrdSection(DataGridView dataGridView, OrganizationalLevel level, int? superiorSectionId)
        {
            // Stačí použiť jednoduché ==.
            if (level.Equals(OrganizationalLevel.Company))
            {
                dataGridView.DataSource = _logic.GetSectionsByLevel(level);
            }
            else
            {
                dataGridView.DataSource = _logic.GetSections(level, superiorSectionId);
            }
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["OrganizationalLevel"].Visible = false;
            dataGridView.Columns["ManagerID"].Visible = false;
            dataGridView.Columns["SuperiorSectionID"].Visible = false;
            dataGridView.Columns["Code"].HeaderText = "Kód";
            dataGridView.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["Name"].HeaderText = "Názov";
            dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EnablingBtns();
        }

        private void FillDtGrdEmployees(string departmentCode)
        {
            dtGrdEmployees.DataSource = _logic.GetEmployeesByDepartment(departmentCode);
            dtGrdEmployees.Columns["ID"].Visible = false;
            dtGrdEmployees.Columns["Phone"].Visible = false;
            dtGrdEmployees.Columns["Email"].Visible = false;
            dtGrdEmployees.Columns["DepartmentCode"].Visible = false;
            dtGrdEmployees.Columns["FullName"].Visible = false;
            dtGrdEmployees.Columns["FirstName"].HeaderText = "Meno";
            dtGrdEmployees.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGrdEmployees.Columns["LastName"].HeaderText = "Priezvisko";
            dtGrdEmployees.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGrdEmployees.Columns["Title"].HeaderText = "Titul";
            dtGrdEmployees.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

        #region Read data from datagridviews
        private Section ReadSectionFromDtGrd(DataGridView dtGrd)
        {
            Section section = new Section();
            section.ID = (int)dtGrd.SelectedCells[0].Value;
            section.Name = dtGrd.SelectedCells[1].Value.ToString();
            section.Code = dtGrd.SelectedCells[2].Value.ToString();
            section.OrganizationalLevel = (OrganizationalLevel)dtGrd.SelectedCells[3].Value;
            section.ManagerID = (int?)dtGrd.SelectedCells[4].Value;
            section.SuperiorSectionID = (int?)dtGrd.SelectedCells[5].Value;
            return section;
        }

        private Employee ReadEmployeeFromDtGrd()
        {
            Employee employee = new Employee();
            employee.ID = (int)dtGrdEmployees.SelectedCells[0].Value;
            employee.FirstName = dtGrdEmployees.SelectedCells[1].Value.ToString();
            employee.LastName = dtGrdEmployees.SelectedCells[2].Value.ToString();
            employee.Title = (dtGrdEmployees.SelectedCells[3].Value == null) ? null : dtGrdEmployees.SelectedCells[3].Value.ToString();
            employee.Phone = dtGrdEmployees.SelectedCells[4].Value.ToString();
            employee.Email = dtGrdEmployees.SelectedCells[5].Value.ToString();
            employee.DepartmentCode = dtGrdEmployees.SelectedCells[6].Value.ToString();
            return employee;
        }
        #endregion

        #region Datagridviews cell click
        private void dtGrdCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdDivisions, OrganizationalLevel.Division, section.ID);
            FillDtGrdSection(dtGrdProjects, OrganizationalLevel.Project, section.ID);
            FillDtGrdSection(dtGrdDepartments, OrganizationalLevel.Department, section.ID);
            FillDtGrdEmployees(section.Code);
        }

        private void dtGrdDivisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdProjects, OrganizationalLevel.Project, section.ID);
            FillDtGrdSection(dtGrdDepartments, OrganizationalLevel.Department, section.ID);
            FillDtGrdEmployees(section.Code);
        }

        private void dtGrdProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdDepartments, OrganizationalLevel.Department, section.ID);
            FillDtGrdEmployees(section.Code);
        }

        private void dtGrdDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdEmployees(section.Code);
        }

        private void dtGrdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = ReadEmployeeFromDtGrd();
        }
        #endregion

        private void EnablingBtns()
        {
            if (dtGrdCompanies.Rows.Count > 0)
            {
                dtGrdCompanies.CurrentCell = dtGrdCompanies.Rows[0].Cells["Name"];
                btnUpdateSection.Enabled = true;
                btnDetailOfSection.Enabled = true;
            }
            else
            {
                btnUpdateSection.Enabled = false;
                btnDetailOfSection.Enabled = false;
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            using (FrmNewEmployee newForm = new FrmNewEmployee())
            {
                newForm.ShowDialog();
            }
        }

        private void btnDetailOfEmployee_Click(object sender, EventArgs e)
        {
            using (FrmViewEmployee newForm = new FrmViewEmployee())
            {
                newForm.ShowDialog();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            using (FrmUpdateEmployee newForm = new FrmUpdateEmployee())
            {
                newForm.ShowDialog();
            }
            dtGrdEmployees.DataSource = null;
        }
    }
}

