using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStructureApp
{
    public partial class EmployeeView : Form
    {
        private EmployeeViewModel _employeeViewModel;
        private int _firmId;
        private int _departmentId;

        public EmployeeView(EmployeeViewModel employeeViewModel, int firmId, int departmentId)
        {
            _employeeViewModel = employeeViewModel;
            _firmId = firmId;
            _departmentId = departmentId;
            InitializeComponent();
        }

        public EmployeeView(EmployeeViewModel employeeViewModel, int firmId, int departmentId, int employeeId)
        {
            _employeeViewModel = employeeViewModel;
            _firmId = firmId;
            _departmentId = departmentId;
            _employeeViewModel.GetEmployeeById(employeeId);
            _employeeViewModel.IsEdit = true;
            InitializeComponent();
            InitForEdit();
        }

        public EmployeeView(EmployeeViewModel employeeViewModel, int firmId, int departmentId, int employeeId, bool isShow)
        {
            _employeeViewModel = employeeViewModel;
            _firmId = firmId;
            _departmentId = departmentId;
            _employeeViewModel.GetEmployeeById(employeeId);
            _employeeViewModel.IsShow = isShow;
            InitializeComponent();
            InitForShow();
        }

        private void InitForEdit()
        {
            this.Text = "Oprav zamestnanca";
            txtTitle.Text = _employeeViewModel.EmployeeToEdit.Title;
            txtName.Text = _employeeViewModel.EmployeeToEdit.Name;
            txtSurname.Text = _employeeViewModel.EmployeeToEdit.Surname;
            txtPhone.Text = _employeeViewModel.EmployeeToEdit.Phone;
            txtEmail.Text = _employeeViewModel.EmployeeToEdit.Email;
        }

        private void InitForShow()
        {
            this.Text = "Ukáž zamestnanca";
            txtTitle.Text = _employeeViewModel.EmployeeToEdit.Title;
            txtName.Text = _employeeViewModel.EmployeeToEdit.Name;
            txtSurname.Text = _employeeViewModel.EmployeeToEdit.Surname;
            txtPhone.Text = _employeeViewModel.EmployeeToEdit.Phone;
            txtEmail.Text = _employeeViewModel.EmployeeToEdit.Email;
            btnOk.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _employeeViewModel.Title = txtTitle.Text;
            _employeeViewModel.Name = txtName.Text;
            _employeeViewModel.Surname = txtSurname.Text;
            _employeeViewModel.Phone = txtPhone.Text;
            _employeeViewModel.Email = txtEmail.Text;

            if (_employeeViewModel.IsEdit)
            {
                _employeeViewModel.EmployeeToEdit.Title = txtTitle.Text;
                _employeeViewModel.EmployeeToEdit.Name = txtName.Text;
                _employeeViewModel.EmployeeToEdit.Surname = txtSurname.Text;
                _employeeViewModel.EmployeeToEdit.Phone = txtPhone.Text;
                _employeeViewModel.EmployeeToEdit.Email = txtEmail.Text;
                _employeeViewModel.EditEmployee();
            }
            else
            {
                if (_departmentId != 0)
                {
                    _employeeViewModel.AddEmployee(_firmId, _departmentId);
                }
                else
                {
                    _employeeViewModel.AddEmployee(_firmId);
                }
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
