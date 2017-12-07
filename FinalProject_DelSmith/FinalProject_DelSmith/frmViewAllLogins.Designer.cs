namespace FinalProject_DelSmith
{
    partial class frmViewAllLogins
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
            this.components = new System.ComponentModel.Container();
            this.dgvLogins = new System.Windows.Forms.DataGridView();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesDataSet = new FinalProject_DelSmith.ServicesDataSet();
            this.usernamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernamesTableAdapter = new FinalProject_DelSmith.ServicesDataSetTableAdapters.UsernamesTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogins
            // 
            this.dgvLogins.AllowUserToAddRows = false;
            this.dgvLogins.AllowUserToDeleteRows = false;
            this.dgvLogins.AutoGenerateColumns = false;
            this.dgvLogins.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvLogins.DataSource = this.usernamesBindingSource;
            this.dgvLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogins.Location = new System.Drawing.Point(0, 0);
            this.dgvLogins.Name = "dgvLogins";
            this.dgvLogins.ReadOnly = true;
            this.dgvLogins.Size = new System.Drawing.Size(343, 261);
            this.dgvLogins.TabIndex = 1;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            // 
            // servicesDataSet
            // 
            this.servicesDataSet.DataSetName = "ServicesDataSet";
            this.servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usernamesBindingSource
            // 
            this.usernamesBindingSource.DataMember = "Usernames";
            this.usernamesBindingSource.DataSource = this.servicesDataSet;
            // 
            // usernamesTableAdapter
            // 
            this.usernamesTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmViewAllLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.dgvLogins);
            this.Name = "frmViewAllLogins";
            this.Text = "View All Logins";
            this.Load += new System.EventHandler(this.frmViewAllLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogins;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private ServicesDataSet servicesDataSet;
        private System.Windows.Forms.BindingSource usernamesBindingSource;
        private ServicesDataSetTableAdapters.UsernamesTableAdapter usernamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loginsDataSetBindingSource;
    }
}