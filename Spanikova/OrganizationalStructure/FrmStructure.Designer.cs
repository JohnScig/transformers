namespace OrganizationalStructure
{
    partial class FrmStructure
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
            this.lblCompanies = new System.Windows.Forms.Label();
            this.dtGrdCompanies = new System.Windows.Forms.DataGridView();
            this.btnNewSection = new System.Windows.Forms.Button();
            this.pnlCompanies = new System.Windows.Forms.Panel();
            this.btnDetailOfSection = new System.Windows.Forms.Button();
            this.btnUpdateSection = new System.Windows.Forms.Button();
            this.pnlDivisions = new System.Windows.Forms.Panel();
            this.dtGrdDivisions = new System.Windows.Forms.DataGridView();
            this.lblDivisions = new System.Windows.Forms.Label();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.dtGrdProjects = new System.Windows.Forms.DataGridView();
            this.lblProjects = new System.Windows.Forms.Label();
            this.pnlDepartments = new System.Windows.Forms.Panel();
            this.dtGrdDepartments = new System.Windows.Forms.DataGridView();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.dtGrdEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnDetailOfEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pnlSectionBtns = new System.Windows.Forms.Panel();
            this.lblSections = new System.Windows.Forms.Label();
            this.pnlEmployeesBtns = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCompanies)).BeginInit();
            this.pnlCompanies.SuspendLayout();
            this.pnlDivisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDivisions)).BeginInit();
            this.pnlProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProjects)).BeginInit();
            this.pnlDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDepartments)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdEmployees)).BeginInit();
            this.pnlSectionBtns.SuspendLayout();
            this.pnlEmployeesBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanies
            // 
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompanies.Location = new System.Drawing.Point(28, 13);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(52, 20);
            this.lblCompanies.TabIndex = 0;
            this.lblCompanies.Text = "Firmy";
            // 
            // dtGrdCompanies
            // 
            this.dtGrdCompanies.AllowUserToAddRows = false;
            this.dtGrdCompanies.AllowUserToDeleteRows = false;
            this.dtGrdCompanies.AllowUserToResizeColumns = false;
            this.dtGrdCompanies.AllowUserToResizeRows = false;
            this.dtGrdCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCompanies.Location = new System.Drawing.Point(0, 51);
            this.dtGrdCompanies.Name = "dtGrdCompanies";
            this.dtGrdCompanies.ReadOnly = true;
            this.dtGrdCompanies.RowHeadersVisible = false;
            this.dtGrdCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdCompanies.Size = new System.Drawing.Size(233, 397);
            this.dtGrdCompanies.TabIndex = 1;
            this.dtGrdCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdCompanies_CellClick);
            // 
            // btnNewSection
            // 
            this.btnNewSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewSection.Location = new System.Drawing.Point(329, 42);
            this.btnNewSection.Name = "btnNewSection";
            this.btnNewSection.Size = new System.Drawing.Size(103, 36);
            this.btnNewSection.TabIndex = 2;
            this.btnNewSection.Tag = "0";
            this.btnNewSection.Text = "Nová";
            this.btnNewSection.UseVisualStyleBackColor = false;
            this.btnNewSection.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // pnlCompanies
            // 
            this.pnlCompanies.Controls.Add(this.dtGrdCompanies);
            this.pnlCompanies.Controls.Add(this.lblCompanies);
            this.pnlCompanies.Location = new System.Drawing.Point(12, 127);
            this.pnlCompanies.Name = "pnlCompanies";
            this.pnlCompanies.Size = new System.Drawing.Size(245, 448);
            this.pnlCompanies.TabIndex = 6;
            // 
            // btnDetailOfSection
            // 
            this.btnDetailOfSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetailOfSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetailOfSection.Location = new System.Drawing.Point(23, 42);
            this.btnDetailOfSection.Name = "btnDetailOfSection";
            this.btnDetailOfSection.Size = new System.Drawing.Size(103, 36);
            this.btnDetailOfSection.TabIndex = 4;
            this.btnDetailOfSection.Tag = "0";
            this.btnDetailOfSection.Text = "Zobraziť ";
            this.btnDetailOfSection.UseVisualStyleBackColor = false;
            this.btnDetailOfSection.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnUpdateSection
            // 
            this.btnUpdateSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateSection.Location = new System.Drawing.Point(147, 42);
            this.btnUpdateSection.Name = "btnUpdateSection";
            this.btnUpdateSection.Size = new System.Drawing.Size(143, 36);
            this.btnUpdateSection.TabIndex = 3;
            this.btnUpdateSection.Tag = "0";
            this.btnUpdateSection.Text = "Upraviť / Zmazať";
            this.btnUpdateSection.UseVisualStyleBackColor = false;
            this.btnUpdateSection.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // pnlDivisions
            // 
            this.pnlDivisions.Controls.Add(this.dtGrdDivisions);
            this.pnlDivisions.Controls.Add(this.lblDivisions);
            this.pnlDivisions.Location = new System.Drawing.Point(263, 127);
            this.pnlDivisions.Name = "pnlDivisions";
            this.pnlDivisions.Size = new System.Drawing.Size(246, 448);
            this.pnlDivisions.TabIndex = 7;
            // 
            // dtGrdDivisions
            // 
            this.dtGrdDivisions.AllowUserToAddRows = false;
            this.dtGrdDivisions.AllowUserToDeleteRows = false;
            this.dtGrdDivisions.AllowUserToResizeColumns = false;
            this.dtGrdDivisions.AllowUserToResizeRows = false;
            this.dtGrdDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDivisions.Location = new System.Drawing.Point(0, 51);
            this.dtGrdDivisions.Name = "dtGrdDivisions";
            this.dtGrdDivisions.ReadOnly = true;
            this.dtGrdDivisions.RowHeadersVisible = false;
            this.dtGrdDivisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdDivisions.Size = new System.Drawing.Size(234, 397);
            this.dtGrdDivisions.TabIndex = 1;
            this.dtGrdDivisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdDivisions_CellClick);
            // 
            // lblDivisions
            // 
            this.lblDivisions.AutoSize = true;
            this.lblDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDivisions.Location = new System.Drawing.Point(28, 13);
            this.lblDivisions.Name = "lblDivisions";
            this.lblDivisions.Size = new System.Drawing.Size(104, 20);
            this.lblDivisions.TabIndex = 0;
            this.lblDivisions.Text = "Divízie firmy";
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.dtGrdProjects);
            this.pnlProjects.Controls.Add(this.lblProjects);
            this.pnlProjects.Location = new System.Drawing.Point(515, 127);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(253, 448);
            this.pnlProjects.TabIndex = 8;
            // 
            // dtGrdProjects
            // 
            this.dtGrdProjects.AllowUserToAddRows = false;
            this.dtGrdProjects.AllowUserToDeleteRows = false;
            this.dtGrdProjects.AllowUserToResizeColumns = false;
            this.dtGrdProjects.AllowUserToResizeRows = false;
            this.dtGrdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdProjects.Location = new System.Drawing.Point(0, 51);
            this.dtGrdProjects.Name = "dtGrdProjects";
            this.dtGrdProjects.ReadOnly = true;
            this.dtGrdProjects.RowHeadersVisible = false;
            this.dtGrdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdProjects.Size = new System.Drawing.Size(239, 397);
            this.dtGrdProjects.TabIndex = 1;
            this.dtGrdProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdProjects_CellClick);
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjects.Location = new System.Drawing.Point(28, 13);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(127, 20);
            this.lblProjects.TabIndex = 0;
            this.lblProjects.Text = "Projekty divízie";
            // 
            // pnlDepartments
            // 
            this.pnlDepartments.Controls.Add(this.dtGrdDepartments);
            this.pnlDepartments.Controls.Add(this.lblDepartments);
            this.pnlDepartments.Location = new System.Drawing.Point(774, 127);
            this.pnlDepartments.Name = "pnlDepartments";
            this.pnlDepartments.Size = new System.Drawing.Size(250, 448);
            this.pnlDepartments.TabIndex = 9;
            // 
            // dtGrdDepartments
            // 
            this.dtGrdDepartments.AllowUserToAddRows = false;
            this.dtGrdDepartments.AllowUserToDeleteRows = false;
            this.dtGrdDepartments.AllowUserToResizeColumns = false;
            this.dtGrdDepartments.AllowUserToResizeRows = false;
            this.dtGrdDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDepartments.Location = new System.Drawing.Point(0, 51);
            this.dtGrdDepartments.Name = "dtGrdDepartments";
            this.dtGrdDepartments.ReadOnly = true;
            this.dtGrdDepartments.RowHeadersVisible = false;
            this.dtGrdDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdDepartments.Size = new System.Drawing.Size(236, 397);
            this.dtGrdDepartments.TabIndex = 1;
            this.dtGrdDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdDepartments_CellClick);
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartments.Location = new System.Drawing.Point(28, 13);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(160, 20);
            this.lblDepartments.TabIndex = 0;
            this.lblDepartments.Text = "Oddelenia projektu";
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.dtGrdEmployees);
            this.pnlEmployees.Controls.Add(this.lblEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(1030, 127);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(249, 448);
            this.pnlEmployees.TabIndex = 10;
            // 
            // dtGrdEmployees
            // 
            this.dtGrdEmployees.AllowUserToAddRows = false;
            this.dtGrdEmployees.AllowUserToDeleteRows = false;
            this.dtGrdEmployees.AllowUserToResizeColumns = false;
            this.dtGrdEmployees.AllowUserToResizeRows = false;
            this.dtGrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdEmployees.Location = new System.Drawing.Point(0, 51);
            this.dtGrdEmployees.Name = "dtGrdEmployees";
            this.dtGrdEmployees.ReadOnly = true;
            this.dtGrdEmployees.RowHeadersVisible = false;
            this.dtGrdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdEmployees.Size = new System.Drawing.Size(236, 397);
            this.dtGrdEmployees.TabIndex = 1;
            this.dtGrdEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdEmployees_CellClick);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployees.Location = new System.Drawing.Point(28, 13);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(185, 20);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Zamestanci oddelenia";
            // 
            // btnDetailOfEmployee
            // 
            this.btnDetailOfEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetailOfEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetailOfEmployee.Location = new System.Drawing.Point(45, 42);
            this.btnDetailOfEmployee.Name = "btnDetailOfEmployee";
            this.btnDetailOfEmployee.Size = new System.Drawing.Size(128, 36);
            this.btnDetailOfEmployee.TabIndex = 7;
            this.btnDetailOfEmployee.Text = "Zobraziť";
            this.btnDetailOfEmployee.UseVisualStyleBackColor = false;
            this.btnDetailOfEmployee.Click += new System.EventHandler(this.btnDetailOfEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(202, 42);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(198, 36);
            this.btnUpdateEmployee.TabIndex = 6;
            this.btnUpdateEmployee.Text = "Upraviť / zmazať";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.Location = new System.Drawing.Point(429, 42);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(132, 36);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Nový";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // pnlSectionBtns
            // 
            this.pnlSectionBtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSectionBtns.Controls.Add(this.lblSections);
            this.pnlSectionBtns.Controls.Add(this.btnDetailOfSection);
            this.pnlSectionBtns.Controls.Add(this.btnNewSection);
            this.pnlSectionBtns.Controls.Add(this.btnUpdateSection);
            this.pnlSectionBtns.Location = new System.Drawing.Point(37, 21);
            this.pnlSectionBtns.Name = "pnlSectionBtns";
            this.pnlSectionBtns.Size = new System.Drawing.Size(460, 100);
            this.pnlSectionBtns.TabIndex = 11;
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSections.Location = new System.Drawing.Point(20, 13);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(56, 16);
            this.lblSections.TabIndex = 6;
            this.lblSections.Text = "Sekcie";
            // 
            // pnlEmployeesBtns
            // 
            this.pnlEmployeesBtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeesBtns.Controls.Add(this.label1);
            this.pnlEmployeesBtns.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployeesBtns.Controls.Add(this.btnEmployees);
            this.pnlEmployeesBtns.Controls.Add(this.btnDetailOfEmployee);
            this.pnlEmployeesBtns.Location = new System.Drawing.Point(595, 21);
            this.pnlEmployeesBtns.Name = "pnlEmployeesBtns";
            this.pnlEmployeesBtns.Size = new System.Drawing.Size(603, 100);
            this.pnlEmployeesBtns.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zamestnanci";
            // 
            // FrmStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 608);
            this.Controls.Add(this.pnlEmployeesBtns);
            this.Controls.Add(this.pnlSectionBtns);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.pnlDepartments);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlDivisions);
            this.Controls.Add(this.pnlCompanies);
            this.Name = "FrmStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizačná štruktúra";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCompanies)).EndInit();
            this.pnlCompanies.ResumeLayout(false);
            this.pnlCompanies.PerformLayout();
            this.pnlDivisions.ResumeLayout(false);
            this.pnlDivisions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDivisions)).EndInit();
            this.pnlProjects.ResumeLayout(false);
            this.pnlProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProjects)).EndInit();
            this.pnlDepartments.ResumeLayout(false);
            this.pnlDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDepartments)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdEmployees)).EndInit();
            this.pnlSectionBtns.ResumeLayout(false);
            this.pnlSectionBtns.PerformLayout();
            this.pnlEmployeesBtns.ResumeLayout(false);
            this.pnlEmployeesBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanies;
        private System.Windows.Forms.DataGridView dtGrdCompanies;
        private System.Windows.Forms.Button btnNewSection;
        private System.Windows.Forms.Panel pnlCompanies;
        private System.Windows.Forms.Panel pnlDivisions;
        private System.Windows.Forms.DataGridView dtGrdDivisions;
        private System.Windows.Forms.Label lblDivisions;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.DataGridView dtGrdProjects;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Panel pnlDepartments;
        private System.Windows.Forms.DataGridView dtGrdDepartments;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridView dtGrdEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnUpdateSection;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDetailOfSection;
        private System.Windows.Forms.Button btnDetailOfEmployee;
        private System.Windows.Forms.Panel pnlSectionBtns;
        private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.Panel pnlEmployeesBtns;
        private System.Windows.Forms.Label label1;
    }
}

