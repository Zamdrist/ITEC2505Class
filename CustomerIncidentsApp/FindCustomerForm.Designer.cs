namespace CustomerIncidentsApp
{
    partial class FindCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomerForm));
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.stateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByStateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tsBtnClear = new System.Windows.Forms.ToolStripButton();
            this.fKIncidentsCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIncidentsDataSet = new CustomerIncidentsApp.CustomerIncidentsDataSet();
            this.customersTableAdapter = new CustomerIncidentsApp.CustomerIncidentsDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CustomerIncidentsApp.CustomerIncidentsDataSetTableAdapters.TableAdapterManager();
            this.incidentsTableAdapter = new CustomerIncidentsApp.CustomerIncidentsDataSetTableAdapters.IncidentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKIncidentsCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 49);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(966, 338);
            this.customersDataGridView.TabIndex = 1;
            this.customersDataGridView.TabStop = false;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripLabel,
            this.stateToolStripTextBox,
            this.fillByStateToolStripButton,
            this.tsBtnClear});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(990, 27);
            this.fillBy1ToolStrip.TabIndex = 2;
            this.fillBy1ToolStrip.TabStop = true;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // stateToolStripLabel
            // 
            this.stateToolStripLabel.Name = "stateToolStripLabel";
            this.stateToolStripLabel.Size = new System.Drawing.Size(46, 24);
            this.stateToolStripLabel.Text = "State:";
            // 
            // stateToolStripTextBox
            // 
            this.stateToolStripTextBox.Name = "stateToolStripTextBox";
            this.stateToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.stateToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stateToolStripTextBox_KeyDown);
            // 
            // fillByStateToolStripButton
            // 
            this.fillByStateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStateToolStripButton.Name = "fillByStateToolStripButton";
            this.fillByStateToolStripButton.Size = new System.Drawing.Size(41, 24);
            this.fillByStateToolStripButton.Text = "Find";
            this.fillByStateToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 393);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 32);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tsBtnClear
            // 
            this.tsBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClear.Image")));
            this.tsBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClear.Name = "tsBtnClear";
            this.tsBtnClear.Size = new System.Drawing.Size(47, 24);
            this.tsBtnClear.Text = "Clear";
            this.tsBtnClear.Click += new System.EventHandler(this.tsBtnClear_Click);
            // 
            // fKIncidentsCustomersBindingSource
            // 
            this.fKIncidentsCustomersBindingSource.DataMember = "FK_Incidents_Customers";
            this.fKIncidentsCustomersBindingSource.DataSource = this.customersBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ZipCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Zip Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn5.HeaderText = "State";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customerIncidentsDataSet;
            // 
            // customerIncidentsDataSet
            // 
            this.customerIncidentsDataSet.DataSetName = "CustomerIncidentsDataSet";
            this.customerIncidentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CustomerIncidentsApp.CustomerIncidentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // FindCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 437);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.customersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Customer";
            this.Load += new System.EventHandler(this.FindCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKIncidentsCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerIncidentsDataSet customerIncidentsDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CustomerIncidentsDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private CustomerIncidentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel stateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox stateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByStateToolStripButton;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource fKIncidentsCustomersBindingSource;
        private CustomerIncidentsDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}