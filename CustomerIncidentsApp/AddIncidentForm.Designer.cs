namespace CustomerIncidentsApp
{
    partial class AddIncidentForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomerIdValue = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.customerIncidentsDataSet = new CustomerIncidentsApp.CustomerIncidentsDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CustomerIncidentsApp.CustomerIncidentsDataSetTableAdapters.ProductsTableAdapter();
            this.customerIncidentsDataSet1 = new CustomerIncidentsApp.CustomerIncidentsDataSet();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCustomerIdValue
            // 
            this.lblCustomerIdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerIdValue.Location = new System.Drawing.Point(118, 24);
            this.lblCustomerIdValue.Name = "lblCustomerIdValue";
            this.lblCustomerIdValue.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerIdValue.TabIndex = 2;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.Location = new System.Drawing.Point(12, 24);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerId.TabIndex = 3;
            this.lblCustomerId.Text = "Customer Id:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameValue.Location = new System.Drawing.Point(118, 59);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(217, 23);
            this.lblNameValue.TabIndex = 4;
            // 
            // cmbProducts
            // 
            this.cmbProducts.DataSource = this.productsBindingSource;
            this.cmbProducts.DisplayMember = "Name";
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(118, 120);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(217, 24);
            this.cmbProducts.TabIndex = 6;
            this.cmbProducts.ValueMember = "ProductCode";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 120);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 17);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 199);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 165);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(118, 160);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(281, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 199);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(281, 76);
            this.txtDescription.TabIndex = 11;
            // 
            // customerIncidentsDataSet
            // 
            this.customerIncidentsDataSet.DataSetName = "CustomerIncidentsDataSet";
            this.customerIncidentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.customerIncidentsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // customerIncidentsDataSet1
            // 
            this.customerIncidentsDataSet1.DataSetName = "CustomerIncidentsDataSet";
            this.customerIncidentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.customerIncidentsDataSet1;
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 326);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerIdValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.AddIncidentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIncidentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomerIdValue;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private CustomerIncidentsDataSet customerIncidentsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CustomerIncidentsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private CustomerIncidentsDataSet customerIncidentsDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}