namespace CompanyStructureApp
{
    partial class FirmsView
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
            this.dGVFirms = new System.Windows.Forms.DataGridView();
            this.btnAddFirm = new System.Windows.Forms.Button();
            this.btnEditFirm = new System.Windows.Forms.Button();
            this.btnShowFirm = new System.Windows.Forms.Button();
            this.lblFirmsList = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCompanytStructure = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFirms)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVFirms
            // 
            this.dGVFirms.AllowUserToAddRows = false;
            this.dGVFirms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFirms.Location = new System.Drawing.Point(15, 25);
            this.dGVFirms.MultiSelect = false;
            this.dGVFirms.Name = "dGVFirms";
            this.dGVFirms.ReadOnly = true;
            this.dGVFirms.RowHeadersVisible = false;
            this.dGVFirms.Size = new System.Drawing.Size(497, 426);
            this.dGVFirms.TabIndex = 1;
            // 
            // btnAddFirm
            // 
            this.btnAddFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFirm.Location = new System.Drawing.Point(15, 468);
            this.btnAddFirm.Name = "btnAddFirm";
            this.btnAddFirm.Size = new System.Drawing.Size(103, 23);
            this.btnAddFirm.TabIndex = 3;
            this.btnAddFirm.Text = "Pridaj ";
            this.btnAddFirm.UseVisualStyleBackColor = true;
            this.btnAddFirm.Click += new System.EventHandler(this.btnAddFirm_Click);
            // 
            // btnEditFirm
            // 
            this.btnEditFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditFirm.Location = new System.Drawing.Point(138, 468);
            this.btnEditFirm.Name = "btnEditFirm";
            this.btnEditFirm.Size = new System.Drawing.Size(99, 23);
            this.btnEditFirm.TabIndex = 4;
            this.btnEditFirm.Text = "Oprav";
            this.btnEditFirm.UseVisualStyleBackColor = true;
            this.btnEditFirm.Click += new System.EventHandler(this.btnEditFirm_Click);
            // 
            // btnShowFirm
            // 
            this.btnShowFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFirm.Location = new System.Drawing.Point(257, 468);
            this.btnShowFirm.Name = "btnShowFirm";
            this.btnShowFirm.Size = new System.Drawing.Size(93, 23);
            this.btnShowFirm.TabIndex = 5;
            this.btnShowFirm.Text = "Ukáž";
            this.btnShowFirm.UseVisualStyleBackColor = true;
            this.btnShowFirm.Click += new System.EventHandler(this.btnShowFirm_Click);
            // 
            // lblFirmsList
            // 
            this.lblFirmsList.AutoSize = true;
            this.lblFirmsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirmsList.Location = new System.Drawing.Point(12, 9);
            this.lblFirmsList.Name = "lblFirmsList";
            this.lblFirmsList.Size = new System.Drawing.Size(85, 13);
            this.lblFirmsList.TabIndex = 6;
            this.lblFirmsList.Text = "Zoznam firiem";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(420, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Zatvor";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCompanytStructure
            // 
            this.btnCompanytStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanytStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCompanytStructure.Location = new System.Drawing.Point(15, 505);
            this.btnCompanytStructure.Name = "btnCompanytStructure";
            this.btnCompanytStructure.Size = new System.Drawing.Size(175, 23);
            this.btnCompanytStructure.TabIndex = 8;
            this.btnCompanytStructure.Text = "Organizačná štruktúra";
            this.btnCompanytStructure.UseVisualStyleBackColor = true;
            this.btnCompanytStructure.Click += new System.EventHandler(this.btnCompanytStructure_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.Location = new System.Drawing.Point(209, 505);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(141, 23);
            this.btnEmployees.TabIndex = 9;
            this.btnEmployees.Text = "Zamestnanci";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // FirmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 546);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCompanytStructure);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFirmsList);
            this.Controls.Add(this.btnShowFirm);
            this.Controls.Add(this.btnEditFirm);
            this.Controls.Add(this.btnAddFirm);
            this.Controls.Add(this.dGVFirms);
            this.Name = "FirmsView";
            this.Text = "Firmy";
            this.Load += new System.EventHandler(this.FirmsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFirms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVFirms;
        private System.Windows.Forms.Button btnAddFirm;
        private System.Windows.Forms.Button btnEditFirm;
        private System.Windows.Forms.Button btnShowFirm;
        private System.Windows.Forms.Label lblFirmsList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCompanytStructure;
        private System.Windows.Forms.Button btnEmployees;
    }
}

