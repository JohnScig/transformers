namespace CompanyStructureApp
{
    partial class EmployeesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployeesList = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeesList
            // 
            this.lblEmployeesList.AutoSize = true;
            this.lblEmployeesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeesList.Location = new System.Drawing.Point(12, 18);
            this.lblEmployeesList.Name = "lblEmployeesList";
            this.lblEmployeesList.Size = new System.Drawing.Size(136, 13);
            this.lblEmployeesList.TabIndex = 7;
            this.lblEmployeesList.Text = "Zoznam zamestnancov";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 589);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(103, 23);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Pridaj ";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 34);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.Size = new System.Drawing.Size(854, 549);
            this.dgvEmployees.TabIndex = 9;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditEmployee.Location = new System.Drawing.Point(137, 589);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(99, 23);
            this.btnEditEmployee.TabIndex = 10;
            this.btnEditEmployee.Text = "Oprav";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowEmployee.Location = new System.Drawing.Point(260, 589);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(93, 23);
            this.btnShowEmployee.TabIndex = 11;
            this.btnShowEmployee.Text = "Ukáž";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(774, 589);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Zatvor";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(375, 589);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "Vymaž";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblEmployeesList);
            this.MaximumSize = new System.Drawing.Size(894, 663);
            this.MinimumSize = new System.Drawing.Size(894, 663);
            this.Name = "EmployeesView";
            this.Text = "Zamestnanci";
            this.Load += new System.EventHandler(this.EmployeesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeesList;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}