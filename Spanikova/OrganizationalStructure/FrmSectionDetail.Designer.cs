namespace OrganizationalStructure
{
    partial class FrmSectionDetail
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblSectionType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblSectionCode = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.lblSectionManager = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompany.Location = new System.Drawing.Point(38, 24);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(45, 16);
            this.lblCompany.TabIndex = 22;
            this.lblCompany.Text = "Firma:";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionName.Location = new System.Drawing.Point(38, 66);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(45, 16);
            this.lblSectionName.TabIndex = 24;
            this.lblSectionName.Text = "Meno:";
            // 
            // lblSectionType
            // 
            this.lblSectionType.AutoSize = true;
            this.lblSectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionType.Location = new System.Drawing.Point(38, 109);
            this.lblSectionType.Name = "lblSectionType";
            this.lblSectionType.Size = new System.Drawing.Size(35, 16);
            this.lblSectionType.TabIndex = 26;
            this.lblSectionType.Text = "Typ:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblType.Location = new System.Drawing.Point(178, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 16);
            this.lblType.TabIndex = 27;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCode.Location = new System.Drawing.Point(178, 148);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 16);
            this.lblCode.TabIndex = 29;
            // 
            // lblSectionCode
            // 
            this.lblSectionCode.AutoSize = true;
            this.lblSectionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionCode.Location = new System.Drawing.Point(38, 148);
            this.lblSectionCode.Name = "lblSectionCode";
            this.lblSectionCode.Size = new System.Drawing.Size(35, 16);
            this.lblSectionCode.TabIndex = 28;
            this.lblSectionCode.Text = "Kód:";
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(181, 24);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(149, 21);
            this.cmbCompanies.TabIndex = 30;
            this.cmbCompanies.SelectedValueChanged += new System.EventHandler(this.cmbCompanies_SelectedValueChanged);
            // 
            // cmbSections
            // 
            this.cmbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(181, 66);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(149, 21);
            this.cmbSections.TabIndex = 31;
            this.cmbSections.SelectedValueChanged += new System.EventHandler(this.cmbSections_SelectedValueChanged);
            // 
            // lblSectionManager
            // 
            this.lblSectionManager.AutoSize = true;
            this.lblSectionManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionManager.Location = new System.Drawing.Point(38, 191);
            this.lblSectionManager.Name = "lblSectionManager";
            this.lblSectionManager.Size = new System.Drawing.Size(53, 16);
            this.lblSectionManager.TabIndex = 32;
            this.lblSectionManager.Text = "Vedúci:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManager.Location = new System.Drawing.Point(178, 191);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(0, 16);
            this.lblManager.TabIndex = 33;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(255, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmSectionDetail
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 275);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblSectionManager);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblSectionCode);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSectionType);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.lblCompany);
            this.Name = "FrmSectionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Label lblSectionType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblSectionCode;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Label lblSectionManager;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnOK;
    }
}