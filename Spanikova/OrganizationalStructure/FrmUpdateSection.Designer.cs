namespace OrganizationalStructure
{
    partial class FrmUpdateSection
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCompCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.cmbManagers = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 100);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(223, 141);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(73, 13);
            this.lblCode.TabIndex = 17;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompCode
            // 
            this.lblCompCode.AutoSize = true;
            this.lblCompCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompCode.Location = new System.Drawing.Point(44, 138);
            this.lblCompCode.Name = "lblCompCode";
            this.lblCompCode.Size = new System.Drawing.Size(35, 16);
            this.lblCompCode.TabIndex = 15;
            this.lblCompCode.Text = "Kód:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(302, 138);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(37, 20);
            this.txtCode.TabIndex = 16;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManager.Location = new System.Drawing.Point(44, 182);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(53, 16);
            this.lblManager.TabIndex = 18;
            this.lblManager.Text = "Vedúci:";
            // 
            // cmbManagers
            // 
            this.cmbManagers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManagers.FormattingEnabled = true;
            this.cmbManagers.Location = new System.Drawing.Point(185, 182);
            this.cmbManagers.Name = "cmbManagers";
            this.cmbManagers.Size = new System.Drawing.Size(154, 21);
            this.cmbManagers.TabIndex = 19;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "Uložiť zmeny";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(44, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nový názov:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompany.Location = new System.Drawing.Point(44, 18);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(45, 16);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Firma:";
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(185, 18);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(154, 21);
            this.cmbCompanies.TabIndex = 22;
            this.cmbCompanies.SelectedValueChanged += new System.EventHandler(this.cmbCompanies_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sekcia:";
            // 
            // cmbSections
            // 
            this.cmbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(185, 58);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(154, 21);
            this.cmbSections.TabIndex = 24;
            this.cmbSections.SelectedValueChanged += new System.EventHandler(this.cmbSections_SelectedValueChanged);
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.Location = new System.Drawing.Point(156, 220);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSection.TabIndex = 25;
            this.btnDeleteSection.Text = "Zmazať sekciu";
            this.btnDeleteSection.UseVisualStyleBackColor = true;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // 
            // FrmUpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 278);
            this.Controls.Add(this.btnDeleteSection);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbManagers);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCompCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "FrmUpdateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Úprava sekcie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCompCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox cmbManagers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Button btnDeleteSection;
    }
}