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
            this.mnuClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceMilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNotesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesDataSet = new FinalProject_DelSmith.ServicesDataSet();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesTableAdapter = new FinalProject_DelSmith.ServicesDataSetTableAdapters.ServicesTableAdapter();
            this.mnuAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.mnuAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuClose
            // 
            this.mnuClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuClose.Image = ((System.Drawing.Image)(resources.GetObject("mnuClose.Image")));
            this.mnuClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(40, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.ToolTipText = "Close";
            this.mnuClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgvEmployees.Size = new System.Drawing.Size(1072, 200);
            this.dgvEmployees.TabIndex = 4;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIdDataGridViewTextBoxColumn.Width = 77;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.Width = 121;
            // 
            // vehicleIDDataGridViewTextBoxColumn1
            // 
            this.vehicleIDDataGridViewTextBoxColumn1.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.Name = "vehicleIDDataGridViewTextBoxColumn1";
            this.vehicleIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // serviceDateDataGridViewTextBoxColumn
            // 
            this.serviceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.HeaderText = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.Name = "serviceDateDataGridViewTextBoxColumn";
            this.serviceDateDataGridViewTextBoxColumn.Width = 91;
            // 
            // serviceMilesDataGridViewTextBoxColumn
            // 
            this.serviceMilesDataGridViewTextBoxColumn.DataPropertyName = "ServiceMiles";
            this.serviceMilesDataGridViewTextBoxColumn.HeaderText = "ServiceMiles";
            this.serviceMilesDataGridViewTextBoxColumn.Name = "serviceMilesDataGridViewTextBoxColumn";
            this.serviceMilesDataGridViewTextBoxColumn.Width = 92;
            // 
            // nextServiceDateDataGridViewTextBoxColumn
            // 
            this.nextServiceDateDataGridViewTextBoxColumn.DataPropertyName = "NextServiceDate";
            this.nextServiceDateDataGridViewTextBoxColumn.HeaderText = "NextServiceDate";
            this.nextServiceDateDataGridViewTextBoxColumn.Name = "nextServiceDateDataGridViewTextBoxColumn";
            this.nextServiceDateDataGridViewTextBoxColumn.Width = 113;
            // 
            // nextServiceMilesDataGridViewTextBoxColumn
            // 
            this.nextServiceMilesDataGridViewTextBoxColumn.DataPropertyName = "NextServiceMiles";
            this.nextServiceMilesDataGridViewTextBoxColumn.HeaderText = "NextServiceMiles";
            this.nextServiceMilesDataGridViewTextBoxColumn.Name = "nextServiceMilesDataGridViewTextBoxColumn";
            this.nextServiceMilesDataGridViewTextBoxColumn.Width = 114;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // serviceNotesDataGridViewTextBoxColumn1
            // 
            this.serviceNotesDataGridViewTextBoxColumn1.DataPropertyName = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn1.HeaderText = "ServiceNotes";
            this.serviceNotesDataGridViewTextBoxColumn1.Name = "serviceNotesDataGridViewTextBoxColumn1";
            this.serviceNotesDataGridViewTextBoxColumn1.Width = 96;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.servicesDataSet;
            // 
            // servicesDataSet
            // 
            this.servicesDataSet.DataSetName = "ServicesDataSet";
            this.servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // mnuAdd
            // 
            this.mnuAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAdd.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdd.Image")));
            this.mnuAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(33, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
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
            this.Activated += new System.EventHandler(this.frmViewAllServices_Activated);
            this.Load += new System.EventHandler(this.frmViewAllServices_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuClose;
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
        private System.Windows.Forms.ToolStripButton mnuAdd;
    }
}