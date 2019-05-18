namespace CompanyStructureApp
{
    partial class AddFirmView
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lblHeadOfFirm = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbHeadOfFirm = new System.Windows.Forms.ComboBox();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCode.Location = new System.Drawing.Point(42, 43);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Kód";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(42, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Názov";
            // 
            // lblHeadOfFirm
            // 
            this.lblHeadOfFirm.AutoSize = true;
            this.lblHeadOfFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeadOfFirm.Location = new System.Drawing.Point(42, 122);
            this.lblHeadOfFirm.Name = "lblHeadOfFirm";
            this.lblHeadOfFirm.Size = new System.Drawing.Size(46, 13);
            this.lblHeadOfFirm.TabIndex = 2;
            this.lblHeadOfFirm.Text = "Vedúci";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOk.Location = new System.Drawing.Point(229, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(310, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Zruš";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbHeadOfFirm
            // 
            this.cmbHeadOfFirm.FormattingEnabled = true;
            this.cmbHeadOfFirm.Location = new System.Drawing.Point(113, 122);
            this.cmbHeadOfFirm.Name = "cmbHeadOfFirm";
            this.cmbHeadOfFirm.Size = new System.Drawing.Size(230, 21);
            this.cmbHeadOfFirm.TabIndex = 9;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(350, 122);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(35, 23);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "...";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(113, 36);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 11;
            // 
            // AddFirmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 256);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.cmbHeadOfFirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeadOfFirm);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lblCode);
            this.Name = "AddFirmView";
            this.Text = "Pridaj firmu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblHeadOfFirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbHeadOfFirm;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TextBox txtCode;
    }
}