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
    public partial class EmployeesView : Form
    {
        private EmployeesViewModel _employeesViewModel;
        private int _firmId;
        private int _departmentId;

        public EmployeesView(EmployeesViewModel employeesViewModel, int firmId, int departmentId)
        {
            _employeesViewModel = employeesViewModel;
            _firmId = firmId;
            _departmentId = departmentId;
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var employeeView = new EmployeeView(new EmployeeViewModel(), _firmId, _departmentId))
            {
                employeeView.StartPosition = FormStartPosition.CenterParent;
                employeeView.ShowDialog();

                if (employeeView.DialogResult == DialogResult.OK)
                {
                    _employeesViewModel.GetEmployeesByFirmId(_firmId);
                    dgvEmployees.DataSource = _employeesViewModel.Employees;
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow!=null)
            {
                int index = dgvEmployees.CurrentRow.Index;
                int employeeId = _employeesViewModel.Employees[index].EmployeeId;

                using (var employeeView = new EmployeeView(new EmployeeViewModel(), _firmId, _departmentId, employeeId))
                {
                    employeeView.StartPosition = FormStartPosition.CenterParent;
                    employeeView.ShowDialog();

                    if (employeeView.DialogResult == DialogResult.OK)
                    {
                        _employeesViewModel.GetEmployeesByFirmId(_firmId);
                        dgvEmployees.DataSource = _employeesViewModel.Employees;
                    }
                }
            }
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow!=null)
            {
                int index = dgvEmployees.CurrentRow.Index;
                int employeeId = _employeesViewModel.Employees[index].EmployeeId;
                bool isShow = true;

                using (var employeeView = new EmployeeView(new EmployeeViewModel(), _firmId, _departmentId, employeeId, isShow))
                {
                    employeeView.StartPosition = FormStartPosition.CenterParent;
                    employeeView.ShowDialog();
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                int index = dgvEmployees.CurrentRow.Index;
                int employeeId = _employeesViewModel.Employees[index].EmployeeId;
                _employeesViewModel.DeleteEmployee(employeeId);

                _employeesViewModel.GetEmployeesByFirmId(_firmId);
                dgvEmployees.DataSource = _employeesViewModel.Employees;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeesView_Load(object sender, EventArgs e)
        {
            if (_departmentId == 0)
            {
                _employeesViewModel.GetEmployeesByFirmId(_firmId);
            }
            else
            {
                _employeesViewModel.GetEmployeesByDepartmentId(_departmentId);
            }

            dgvEmployees.DataSource = _employeesViewModel.Employees;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.Columns[0].Visible = false;
            dgvEmployees.Columns[1].Visible = false;
            dgvEmployees.Columns[2].Visible = false;
        }
    }
}
