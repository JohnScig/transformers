namespace CompanyStructureApp
{
    partial class CompanyStructureView
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
            this.lblCodeOfFirm = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirmCode = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.dGVDivision = new System.Windows.Forms.DataGridView();
            this.dGVProject = new System.Windows.Forms.DataGridView();
            this.dGVDepartment = new System.Windows.Forms.DataGridView();
            this.btnAddDivision = new System.Windows.Forms.Button();
            this.btnEditDivision = new System.Windows.Forms.Button();
            this.btnShowDivision = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnShowProject = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnShowDepartment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnEmployeesOfDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeOfFirm
            // 
            this.lblCodeOfFirm.AutoSize = true;
            this.lblCodeOfFirm.Location = new System.Drawing.Point(26, 24);
            this.lblCodeOfFirm.Name = "lblCodeOfFirm";
            this.lblCodeOfFirm.Size = new System.Drawing.Size(26, 13);
            this.lblCodeOfFirm.TabIndex = 0;
            this.lblCodeOfFirm.Text = "Kód";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(198, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Názov";
            // 
            // txtFirmCode
            // 
            this.txtFirmCode.Location = new System.Drawing.Point(58, 20);
            this.txtFirmCode.Name = "txtFirmCode";
            this.txtFirmCode.ReadOnly = true;
            this.txtFirmCode.Size = new System.Drawing.Size(116, 20);
            this.txtFirmCode.TabIndex = 3;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(242, 21);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.ReadOnly = true;
            this.txtFirmName.Size = new System.Drawing.Size(219, 20);
            this.txtFirmName.TabIndex = 4;
            // 
            // dGVDivision
            // 
            this.dGVDivision.AllowUserToAddRows = false;
            this.dGVDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDivision.Location = new System.Drawing.Point(12, 88);
            this.dGVDivision.Name = "dGVDivision";
            this.dGVDivision.ReadOnly = true;
            this.dGVDivision.RowHeadersVisible = false;
            this.dGVDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDivision.Size = new System.Drawing.Size(318, 437);
            this.dGVDivision.TabIndex = 6;
            this.dGVDivision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDivision_CellClick);
            // 
            // dGVProject
            // 
            this.dGVProject.AllowUserToAddRows = false;
            this.dGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProject.Location = new System.Drawing.Point(346, 88);
            this.dGVProject.Name = "dGVProject";
            this.dGVProject.ReadOnly = true;
            this.dGVProject.RowHeadersVisible = false;
            this.dGVProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProject.Size = new System.Drawing.Size(326, 437);
            this.dGVProject.TabIndex = 7;
            this.dGVProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProject_CellClick);
            // 
            // dGVDepartment
            // 
            this.dGVDepartment.AllowUserToAddRows = false;
            this.dGVDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDepartment.Location = new System.Drawing.Point(688, 88);
            this.dGVDepartment.Name = "dGVDepartment";
            this.dGVDepartment.ReadOnly = true;
            this.dGVDepartment.RowHeadersVisible = false;
            this.dGVDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDepartment.Size = new System.Drawing.Size(319, 437);
            this.dGVDepartment.TabIndex = 8;
            this.dGVDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDepartment_CellClick);
            // 
            // btnAddDivision
            // 
            this.btnAddDivision.Location = new System.Drawing.Point(12, 550);
            this.btnAddDivision.Name = "btnAddDivision";
            this.btnAddDivision.Size = new System.Drawing.Size(75, 23);
            this.btnAddDivision.TabIndex = 10;
            this.btnAddDivision.Text = "Pridaj";
            this.btnAddDivision.UseVisualStyleBackColor = true;
            this.btnAddDivision.Click += new System.EventHandler(this.btnAddDivision_Click);
            // 
            // btnEditDivision
            // 
            this.btnEditDivision.Location = new System.Drawing.Point(93, 550);
            this.btnEditDivision.Name = "btnEditDivision";
            this.btnEditDivision.Size = new System.Drawing.Size(75, 23);
            this.btnEditDivision.TabIndex = 11;
            this.btnEditDivision.Text = "Oprav";
            this.btnEditDivision.UseVisualStyleBackColor = true;
            // 
            // btnShowDivision
            // 
            this.btnShowDivision.Location = new System.Drawing.Point(174, 550);
            this.btnShowDivision.Name = "btnShowDivision";
            this.btnShowDivision.Size = new System.Drawing.Size(75, 23);
            this.btnShowDivision.TabIndex = 12;
            this.btnShowDivision.Text = "Ukáž";
            this.btnShowDivision.UseVisualStyleBackColor = true;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(346, 550);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 13;
            this.btnAddProject.Text = "Pridaj";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Location = new System.Drawing.Point(427, 550);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(75, 23);
            this.btnEditProject.TabIndex = 14;
            this.btnEditProject.Text = "Oprav";
            this.btnEditProject.UseVisualStyleBackColor = true;
            // 
            // btnShowProject
            // 
            this.btnShowProject.Location = new System.Drawing.Point(508, 550);
            this.btnShowProject.Name = "btnShowProject";
            this.btnShowProject.Size = new System.Drawing.Size(75, 23);
            this.btnShowProject.TabIndex = 15;
            this.btnShowProject.Text = "Ukáž";
            this.btnShowProject.UseVisualStyleBackColor = true;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(688, 550);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 16;
            this.btnAddDepartment.Text = "Pridaj";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(769, 550);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnEditDepartment.TabIndex = 17;
            this.btnEditDepartment.Text = "Oprav";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            // 
            // btnShowDepartment
            // 
            this.btnShowDepartment.Location = new System.Drawing.Point(850, 550);
            this.btnShowDepartment.Name = "btnShowDepartment";
            this.btnShowDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnShowDepartment.TabIndex = 18;
            this.btnShowDepartment.Text = "Ukáž";
            this.btnShowDepartment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(932, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Zatvor";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(13, 69);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(40, 13);
            this.lblDivision.TabIndex = 23;
            this.lblDivision.Text = "Divízie";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(346, 68);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(45, 13);
            this.lblProject.TabIndex = 24;
            this.lblProject.Text = "Projekty";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(688, 67);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(55, 13);
            this.lblDepartment.TabIndex = 25;
            this.lblDepartment.Text = "Oddelenia";
            // 
            // btnEmployeesOfDepartment
            // 
            this.btnEmployeesOfDepartment.Location = new System.Drawing.Point(691, 597);
            this.btnEmployeesOfDepartment.Name = "btnEmployeesOfDepartment";
            this.btnEmployeesOfDepartment.Size = new System.Drawing.Size(153, 23);
            this.btnEmployeesOfDepartment.TabIndex = 26;
            this.btnEmployeesOfDepartment.Text = "Zamestnanci oddelenia";
            this.btnEmployeesOfDepartment.UseVisualStyleBackColor = true;
            this.btnEmployeesOfDepartment.Click += new System.EventHandler(this.btnEmployeesOfDepartment_Click);
            // 
            // CompanyStructureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 660);
            this.Controls.Add(this.btnEmployeesOfDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnShowProject);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnShowDivision);
            this.Controls.Add(this.btnEditDivision);
            this.Controls.Add(this.btnAddDivision);
            this.Controls.Add(this.dGVDepartment);
            this.Controls.Add(this.dGVProject);
            this.Controls.Add(this.dGVDivision);
            this.Controls.Add(this.txtFirmName);
            this.Controls.Add(this.txtFirmCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCodeOfFirm);
            this.MaximumSize = new System.Drawing.Size(1038, 699);
            this.MinimumSize = new System.Drawing.Size(1038, 699);
            this.Name = "CompanyStructureView";
            this.Text = "Organizačná štruktúra firmy";
            this.Load += new System.EventHandler(this.CompanyStructureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeOfFirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirmCode;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.DataGridView dGVDivision;
        private System.Windows.Forms.DataGridView dGVProject;
        private System.Windows.Forms.DataGridView dGVDepartment;
        private System.Windows.Forms.Button btnAddDivision;
        private System.Windows.Forms.Button btnEditDivision;
        private System.Windows.Forms.Button btnShowDivision;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnShowProject;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnShowDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnEmployeesOfDepartment;
    }
}