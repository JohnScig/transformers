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
    public partial class FrmSectionDetail : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmSectionDetail()
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

        private void FillLabels(Section section)
        {
            lblType.Text = EnumDescriptor.GetEnumDescription(section.OrganizationalLevel);
            lblCode.Text = section.Code;
            Employee manager = _logic.GetManagerOfSection(section.ManagerID);
            lblManager.Text = (manager != null) ? manager.FullName : "";
            FillLblSectionManager(section.OrganizationalLevel);
        }

        private void cmbCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            string companyCode = ((Section)cmbCompanies.SelectedValue).Code;
            FillCmbSections(companyCode);
        }

        private void cmbSections_SelectedValueChanged(object sender, EventArgs e)
        {
            Section section = (Section)cmbSections.SelectedValue;
            FillLabels(section);
        }

        private void FillLblSectionManager(OrganizationalLevel orgLevel)
        {
            switch (orgLevel)
            {
                case OrganizationalLevel.Company:
                    lblSectionManager.Text = "Riaditeľ:";
                        break;
                case OrganizationalLevel.Division:
                    lblSectionManager.Text = "Vedúci divízie:";
                    break;
                case OrganizationalLevel.Project:
                    lblSectionManager.Text = "Vedúci projektu:";
                    break;
                case OrganizationalLevel.Department:
                    lblSectionManager.Text = "Vedúci oddelenia:";
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
