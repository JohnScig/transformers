namespace OrganizationalStructure
{
    partial class FrmNewSection
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSuperiorSection = new System.Windows.Forms.Label();
            this.cmbSuperiorSection = new System.Windows.Forms.ComboBox();
            this.pnlSectionInfo = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.cmbSectionType = new System.Windows.Forms.ComboBox();
            this.lblSectionType = new System.Windows.Forms.Label();
            this.pnlSectionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 44);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(3, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Názov:";
            // 
            // lblCompCode
            // 
            this.lblCompCode.AutoSize = true;
            this.lblCompCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompCode.Location = new System.Drawing.Point(3, 121);
            this.lblCompCode.Name = "lblCompCode";
            this.lblCompCode.Size = new System.Drawing.Size(35, 16);
            this.lblCompCode.TabIndex = 4;
            this.lblCompCode.Text = "Kód:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(261, 117);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(37, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(247, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSuperiorSection
            // 
            this.lblSuperiorSection.AutoSize = true;
            this.lblSuperiorSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuperiorSection.Location = new System.Drawing.Point(3, 79);
            this.lblSuperiorSection.Name = "lblSuperiorSection";
            this.lblSuperiorSection.Size = new System.Drawing.Size(126, 16);
            this.lblSuperiorSection.TabIndex = 9;
            this.lblSuperiorSection.Text = "Nadriadená sekcia:";
            // 
            // cmbSuperiorSection
            // 
            this.cmbSuperiorSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuperiorSection.FormattingEnabled = true;
            this.cmbSuperiorSection.Location = new System.Drawing.Point(144, 79);
            this.cmbSuperiorSection.Name = "cmbSuperiorSection";
            this.cmbSuperiorSection.Size = new System.Drawing.Size(154, 21);
            this.cmbSuperiorSection.TabIndex = 10;
            this.cmbSuperiorSection.SelectedValueChanged += new System.EventHandler(this.cmbSuperiorSection_SelectedValueChanged);
            // 
            // pnlSectionInfo
            // 
            this.pnlSectionInfo.Controls.Add(this.lblCode);
            this.pnlSectionInfo.Controls.Add(this.cmbSectionType);
            this.pnlSectionInfo.Controls.Add(this.lblName);
            this.pnlSectionInfo.Controls.Add(this.lblSectionType);
            this.pnlSectionInfo.Controls.Add(this.txtName);
            this.pnlSectionInfo.Controls.Add(this.lblCompCode);
            this.pnlSectionInfo.Controls.Add(this.cmbSuperiorSection);
            this.pnlSectionInfo.Controls.Add(this.txtCode);
            this.pnlSectionInfo.Controls.Add(this.lblSuperiorSection);
            this.pnlSectionInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlSectionInfo.Name = "pnlSectionInfo";
            this.pnlSectionInfo.Size = new System.Drawing.Size(310, 150);
            this.pnlSectionInfo.TabIndex = 11;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(182, 120);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(73, 13);
            this.lblCode.TabIndex = 14;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSectionType
            // 
            this.cmbSectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSectionType.FormattingEnabled = true;
            this.cmbSectionType.Location = new System.Drawing.Point(144, 9);
            this.cmbSectionType.Name = "cmbSectionType";
            this.cmbSectionType.Size = new System.Drawing.Size(154, 21);
            this.cmbSectionType.TabIndex = 13;
            this.cmbSectionType.DropDownClosed += new System.EventHandler(this.cmbSectionType_DropDownClosed);
            // 
            // lblSectionType
            // 
            this.lblSectionType.AutoSize = true;
            this.lblSectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionType.Location = new System.Drawing.Point(3, 9);
            this.lblSectionType.Name = "lblSectionType";
            this.lblSectionType.Size = new System.Drawing.Size(35, 16);
            this.lblSectionType.TabIndex = 12;
            this.lblSectionType.Text = "Typ:";
            // 
            // FrmNewSection
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 199);
            this.Controls.Add(this.pnlSectionInfo);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmNewSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nová sekcia";
            this.pnlSectionInfo.ResumeLayout(false);
            this.pnlSectionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSuperiorSection;
        private System.Windows.Forms.ComboBox cmbSuperiorSection;
        private System.Windows.Forms.Panel pnlSectionInfo;
        private System.Windows.Forms.Label lblSectionType;
        private System.Windows.Forms.ComboBox cmbSectionType;
        private System.Windows.Forms.Label lblCode;
    }
}