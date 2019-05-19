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
    public partial class FrmUpdateEmployee : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmUpdateEmployee()
        {
            InitializeComponent();
            FillCmbEmployees();
        }

        private void FillCmbEmployees()
        {
            cmbEmployees.DataSource = _logic.GetAllEmployees();
            cmbEmployees.DisplayMember = "FullName";
        }

        private void FillCmbCompanies()
        {
            cmbCompanies.DataSource = _logic.GetSectionsByLevel(OrganizationalLevel.Company);
            cmbCompanies.DisplayMember = "Name";
            cmbCompanies.ValueMember = "Code";
        }

        private void FillCmbDepartments(string companyCode)
        {
            cmbDepartments.DisplayMember = null;
            cmbDepartments.DataSource = _logic.GetDepartmentsByCompany(companyCode);
            cmbDepartments.DisplayMember = "Name";
            cmbDepartments.ValueMember = "Code";
        }

        private void FillFormData(Employee employee)
        {
            txtTitle.Text = employee.Title ?? "";
            txtName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            FillCmbCompanies();
            if (employee.DepartmentCode != null)
            {
                cmbCompanies.SelectedValue = _logic.GetCompanyByCode(employee.DepartmentCode.Substring(0, 2)).Code;
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFormData((Employee)cmbEmployees.SelectedValue);
        }

        private void cmbCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCmbDepartments(cmbCompanies.SelectedValue.ToString());
        }

        // Validácie nie sú jednoduché. Nedokázal som normálne vyplniť formulár a nevedel som prečo.
        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                Employee employee = (Employee)cmbEmployees.SelectedValue;
                employee.FirstName = txtName.Text;
                employee.LastName = txtLastName.Text;
                employee.Title = txtTitle.Text ?? null;
                employee.Phone = txtPhone.Text;
                employee.Email = txtEmail.Text;
                employee.DepartmentCode = cmbDepartments.SelectedValue.ToString();
                _logic.UpdateEmployee(employee);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employeeId = ((Employee)cmbEmployees.SelectedValue).ID;
            if (_logic.DeleteEmployee(employeeId))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Vymazanie nebolo úspešné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
