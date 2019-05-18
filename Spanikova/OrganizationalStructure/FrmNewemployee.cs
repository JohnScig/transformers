using OrganizationalStructure.Data.Enums;
using OrganizationalStructure.Logic;
using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationalStructure
{
    public partial class FrmNewEmployee : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmNewEmployee()
        {
            InitializeComponent();
            FillCmbCompanies();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Employee employee = new Employee();
                employee.Title = txtTitle.Text;
                employee.FirstName = txtName.Text;
                employee.LastName = txtLastName.Text;
                employee.Phone = txtPhone.Text;
                employee.Email = txtEmail.Text;
                employee.DepartmentCode = cmbDepartments.SelectedValue.ToString();
                _logic.InsertEmployee(employee);
            }
        }

        private void FillCmbCompanies()
        {
            cmbCompanies.DataSource = _logic.GetSectionsByLevel(OrganizationalLevel.Company);
            cmbCompanies.DisplayMember = "Name";
        }

        private void FillCmbDepartments(string companyCode)
        {
            cmbDepartments.DisplayMember = null;
            cmbDepartments.DataSource = _logic.GetDepartmentsByCompany(companyCode);
            cmbDepartments.DisplayMember = "Name";
            cmbDepartments.ValueMember = "Code";
        }

        private void cmbCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCmbDepartments(((Section)cmbCompanies.SelectedValue).Code);
        }

        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
