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
    public partial class FrmViewEmployee : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmViewEmployee()
        {
            InitializeComponent();
            FillCmbEmployees();
        }

        private void FillLabels(Employee employee)
        {
            lblTitle.Text = employee.Title ?? "";
            lblName.Text = employee.FirstName;
            lblLastName.Text = employee.LastName;
            lblPhone.Text = employee.Phone;
            lblEmail.Text = employee.Email;
            lblDepartment.Text = employee.DepartmentCode;
        }

        private void FillCmbEmployees()
        {
            cmbEmployees.DataSource = _logic.GetAllEmployees();
            cmbEmployees.DisplayMember = "FullName";
        }

        private void cmbEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            FillLabels((Employee)cmbEmployees.SelectedValue);
        }
    }
}
