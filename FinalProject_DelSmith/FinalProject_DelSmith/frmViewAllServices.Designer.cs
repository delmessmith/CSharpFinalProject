namespace FinalProject_DelSmith
{
    partial class frmViewAllServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAllServices));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboEmployee = new System.Windows.Forms.ToolStripComboBox();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataSet = new FinalProject_DelSmith.ServicesDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new FinalProject_DelSmith.ServicesDataSetTableAdapters.ServicesTableAdapter();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceMilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNotesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowAll,
            this.toolStripLabel1,
            this.cboEmployee,
            this.btnEdit,
            this.btnDelete,
            this.btnAdd,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShowAll
            // 
            this.btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(57, 22);
            this.btnShowAll.Text = "Show All";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel1.Text = "Employee:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(121, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 22);
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 22);
            this.btnDelete.Text = "Delete";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 22);
            this.btnAdd.Text = "Add";
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 22);
            this.btnClose.Text = "Close";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.serviceDescriptionDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn1,
            this.serviceDateDataGridViewTextBoxColumn,
            this.serviceMilesDataGridViewTextBoxColumn,
            this.nextServiceDateDataGridViewTextBoxColumn,
            this.nextServiceMilesDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn1,
            this.serviceNotesDataGridViewTextBoxColumn1});
            this.dgvEmployees.DataSource = this.servicesBindingSource;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 28);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(943, 200);
            this.dgvEmployees.TabIndex = 4;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // serviceNotesDataGridViewTextBoxColumn
            // 
            this.serviceNotesDataGridViewTextBoxColumn.DataPropertyName = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn.HeaderText = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn.Name = "serviceNotesDataGridViewTextBoxColumn";
            // 
            // servicesDataSet
            // 
            this.servicesDataSet.DataSetName = "ServicesDataSet";
            this.servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.servicesDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn1
            // 
            this.vehicleIDDataGridViewTextBoxColumn1.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.Name = "vehicleIDDataGridViewTextBoxColumn1";
            // 
            // serviceDateDataGridViewTextBoxColumn
            // 
            this.serviceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.HeaderText = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.Name = "serviceDateDataGridViewTextBoxColumn";
            // 
            // serviceMilesDataGridViewTextBoxColumn
            // 
            this.serviceMilesDataGridViewTextBoxColumn.DataPropertyName = "ServiceMiles";
            this.serviceMilesDataGridViewTextBoxColumn.HeaderText = "ServiceMiles";
            this.serviceMilesDataGridViewTextBoxColumn.Name = "serviceMilesDataGridViewTextBoxColumn";
            // 
            // nextServiceDateDataGridViewTextBoxColumn
            // 
            this.nextServiceDateDataGridViewTextBoxColumn.DataPropertyName = "NextServiceDate";
            this.nextServiceDateDataGridViewTextBoxColumn.HeaderText = "NextServiceDate";
            this.nextServiceDateDataGridViewTextBoxColumn.Name = "nextServiceDateDataGridViewTextBoxColumn";
            // 
            // nextServiceMilesDataGridViewTextBoxColumn
            // 
            this.nextServiceMilesDataGridViewTextBoxColumn.DataPropertyName = "NextServiceMiles";
            this.nextServiceMilesDataGridViewTextBoxColumn.HeaderText = "NextServiceMiles";
            this.nextServiceMilesDataGridViewTextBoxColumn.Name = "nextServiceMilesDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            // 
            // serviceNotesDataGridViewTextBoxColumn1
            // 
            this.serviceNotesDataGridViewTextBoxColumn1.DataPropertyName = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn1.HeaderText = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn1.Name = "serviceNotesDataGridViewTextBoxColumn1";
            // 
            // frmViewAllServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmViewAllServices";
            this.Text = "View All Services";
            this.Load += new System.EventHandler(this.frmViewAllServices_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShowAll;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboEmployee;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNotesDataGridViewTextBoxColumn;
        private ServicesDataSet servicesDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private ServicesDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMilesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextServiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextServiceMilesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNotesDataGridViewTextBoxColumn1;
    }
}