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
using Data;

namespace CompanyStructureApp
{
    public partial class AddFirmView : Form
    {
        private AddFirmViewModel _addFirmViewModel;
        private TypeOfNode _typeOfNode;
        private int _parentId;
        private int _firmId;

        public AddFirmView(AddFirmViewModel addFirmViewModel, TypeOfNode typeOfNode)
        {
            _addFirmViewModel = addFirmViewModel;
            _typeOfNode = typeOfNode;
            InitializeComponent();
            Init();
        }

        public AddFirmView(AddFirmViewModel addFirmViewModel, TypeOfNode typeOfNode, int firmId)
        {
            _addFirmViewModel = addFirmViewModel;
            _typeOfNode = typeOfNode;
            _firmId = firmId;
            _parentId = firmId;
            InitializeComponent();
            Init();
        }

        public AddFirmView(AddFirmViewModel addFirmViewModel, TypeOfNode typeOfNode, int parentId, int firmId)
        {
            _addFirmViewModel = addFirmViewModel;
            _typeOfNode = typeOfNode;
            _parentId = parentId;
            _firmId = firmId;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (_firmId == 0)
            {
                cmbHeadOfFirm.Enabled = false;
            }

            else
            {
                _addFirmViewModel.GetEmployeesByFirmId(_firmId);

                foreach (Employee employee in _addFirmViewModel.Employees)
                {
                    cmbHeadOfFirm.Items.Add($"{employee.Name} {employee.Surname}");
                }
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _addFirmViewModel.CodeOfNode = txtCode.Text;
            _addFirmViewModel.NameOfNode = txtName.Text;
            if (cmbHeadOfFirm.SelectedIndex > -1)
            {
                _addFirmViewModel.HeadOfNodeId = _addFirmViewModel.Employees[cmbHeadOfFirm.SelectedIndex].EmployeeId;
            }

            if (_parentId == 0)
            {
                _addFirmViewModel.AddNode(_typeOfNode);
            }
            else
            {
                _addFirmViewModel.AddNode(_typeOfNode, _parentId);
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            
        }
    }
}
