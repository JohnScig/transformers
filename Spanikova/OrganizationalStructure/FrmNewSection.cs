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
    public partial class FrmNewSection : Form
    {
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmNewSection()
        {
            InitializeComponent();
            FillCmbSectionType();
        }

        private void FillCmbSectionType()
        {
            cmbSectionType.DataSource = new BindingSource(_logic.GetOrganizationalLevels(), null);
            cmbSectionType.DisplayMember = "Value";
            cmbSectionType.ValueMember = "Key";
        }

        private void FillCmbSuperiorSection(OrganizationalLevel level)
        {
            cmbSuperiorSection.DataSource = _logic.GetSectionsByLevel(level);
            cmbSuperiorSection.DisplayMember = "Name";
        }

        private void cmbSectionType_DropDownClosed(object sender, EventArgs e)
        {
            OrganizationalLevel selectedLevel = (OrganizationalLevel) cmbSectionType.SelectedValue;
            if(selectedLevel > 0)
            {
                FillCmbSuperiorSection(selectedLevel-1);
            }else
            {
                cmbSuperiorSection.DataSource = null;
            }
        }

        private void cmbSuperiorSection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSuperiorSection.SelectedValue != null)
            {
                string selectedValue = ((Section)cmbSuperiorSection.SelectedValue).Code;
                lblCode.Text = ((Section)cmbSuperiorSection.SelectedValue).Code;
            }
            else
            {
                lblCode.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Section section = new Section();
                section.Name = txtName.Text;
                section.Code = $"{lblCode.Text}{txtCode.Text}";
                section.OrganizationalLevel = (OrganizationalLevel)cmbSectionType.SelectedValue;
                section.SuperiorSectionID = (cmbSuperiorSection.SelectedValue == null) ? null : (int?)((Section)cmbSuperiorSection.SelectedValue).ID;
                if (_logic.InsertSection(section))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Vloženie sekcie nebolo úspešné\nKód musí byť unikátny.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
