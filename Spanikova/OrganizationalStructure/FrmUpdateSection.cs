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
    public partial class FrmUpdateSection : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmUpdateSection()
        {
            InitializeComponent();
            FillCmbCompanies();
        }

        private void FillCmbCompanies()
        {
            cmbCompanies.DataSource = _logic.GetSectionsByLevel(OrganizationalLevel.Company);
            cmbCompanies.DisplayMember = "Name";
        }

        private void FillCmbSections(string companyCode)
        {
            cmbSections.DataSource = _logic.GetSectionsByCompany(companyCode);
            cmbSections.DisplayMember = "Name";
        }

        private void FillCmbManagers(string companyCode)
        {
            cmbManagers.DataSource = _logic.GetAllEmployees();
            cmbManagers.DisplayMember = "FullName";
        }

        private void cmbCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            string companyCode = ((Section)cmbCompanies.SelectedValue).Code;
            FillCmbSections(companyCode);
            FillCmbManagers(companyCode);
        }

        private void cmbSections_SelectedValueChanged(object sender, EventArgs e)
        {
            Section section = (Section)cmbSections.SelectedValue;
            lblCode.Text = section.Code.Substring(0, section.Code.Length - 2);
            txtCode.Text = section.Code.Substring(section.Code.Length - 2, 2);
            txtName.Text = section.Name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Section section = (Section)cmbSections.SelectedValue;
                section.Name = txtName.Text;
                section.Code = $"{lblCode.Text}{txtCode.Text}";
                section.ManagerID = ((Employee)cmbManagers.SelectedValue).ID;
                if (_logic.UpdateSection(section))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Úprava sekcie nebola úspešná\nKód musí byť unikátny.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            string sectionCode = ((Section)cmbSections.SelectedValue).Code;
            OrganizationalLevel orgLevel = ((Section)cmbSections.SelectedValue).OrganizationalLevel;
            if (_logic.DeleteSection(sectionCode, orgLevel))
            {
                Close();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtCode.Text.Length != 2)
            {
                e.Cancel = true;
            }
        }
    }
}
