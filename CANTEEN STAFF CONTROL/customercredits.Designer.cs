namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    partial class customercredits
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importcreditsbtn = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.Paymanualbtn = new System.Windows.Forms.Button();
            this.creditpaymentdatagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenDBDataSet = new Canteen.ver1.CanteenDBDataSet();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customertblTableAdapter = new Canteen.ver1.CanteenDBDataSetTableAdapters.customertblTableAdapter();
            this.tableAdapterManager = new Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditpaymentdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.importcreditsbtn);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.Paymanualbtn);
            this.panel1.Controls.Add(this.creditpaymentdatagrid);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 595);
            this.panel1.TabIndex = 34;
            // 
            // importcreditsbtn
            // 
            this.importcreditsbtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importcreditsbtn.Location = new System.Drawing.Point(71, 8);
            this.importcreditsbtn.Name = "importcreditsbtn";
            this.importcreditsbtn.Size = new System.Drawing.Size(220, 43);
            this.importcreditsbtn.TabIndex = 22;
            this.importcreditsbtn.Text = "Import Credit Payment";
            this.importcreditsbtn.UseVisualStyleBackColor = true;
            this.importcreditsbtn.Click += new System.EventHandler(this.importcreditsbtn_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImage = global::Canteen.ver1.Properties.Resources._326679_refresh_reload_icon;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(904, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(29, 30);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshButton.TabIndex = 31;
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Paymanualbtn
            // 
            this.Paymanualbtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymanualbtn.Location = new System.Drawing.Point(297, 8);
            this.Paymanualbtn.Name = "Paymanualbtn";
            this.Paymanualbtn.Size = new System.Drawing.Size(220, 43);
            this.Paymanualbtn.TabIndex = 23;
            this.Paymanualbtn.Text = "Pay Manual";
            this.Paymanualbtn.UseVisualStyleBackColor = true;
            this.Paymanualbtn.Click += new System.EventHandler(this.Paymanualbtn_Click);
            // 
            // creditpaymentdatagrid
            // 
            this.creditpaymentdatagrid.AllowUserToAddRows = false;
            this.creditpaymentdatagrid.AllowUserToDeleteRows = false;
            this.creditpaymentdatagrid.AutoGenerateColumns = false;
            this.creditpaymentdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditpaymentdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.creditpaymentdatagrid.DataSource = this.customertblBindingSource;
            this.creditpaymentdatagrid.Location = new System.Drawing.Point(71, 60);
            this.creditpaymentdatagrid.Name = "creditpaymentdatagrid";
            this.creditpaymentdatagrid.ReadOnly = true;
            this.creditpaymentdatagrid.Size = new System.Drawing.Size(1221, 543);
            this.creditpaymentdatagrid.TabIndex = 0;
            this.creditpaymentdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.creditpaymentdatagrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "CREDITS";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customertblBindingSource
            // 
            this.customertblBindingSource.DataMember = "customertbl";
            this.customertblBindingSource.DataSource = this.canteenDBDataSet;
            // 
            // canteenDBDataSet
            // 
            this.canteenDBDataSet.DataSetName = "CanteenDBDataSet";
            this.canteenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(1025, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(267, 31);
            this.searchbox.TabIndex = 20;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(939, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search";
            // 
            // customertblTableAdapter
            // 
            this.customertblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CanteenstaffTableAdapter = null;
            this.tableAdapterManager.cashpaymentblTableAdapter = null;
            this.tableAdapterManager.customerchargestblTableAdapter = null;
            this.tableAdapterManager.customertblTableAdapter = this.customertblTableAdapter;
            this.tableAdapterManager.historylogstblTableAdapter = null;
            this.tableAdapterManager.paycreditreportstblTableAdapter = null;
            this.tableAdapterManager.tblaccountingTableAdapter = null;
            this.tableAdapterManager.tbladminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customercredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "customercredits";
            this.Size = new System.Drawing.Size(1370, 595);
            this.Load += new System.EventHandler(this.customercredits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditpaymentdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.Button Paymanualbtn;
        private System.Windows.Forms.DataGridView creditpaymentdatagrid;
        private System.Windows.Forms.Button importcreditsbtn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customertblBindingSource;
        private CanteenDBDataSet canteenDBDataSet;
        private CanteenDBDataSetTableAdapters.customertblTableAdapter customertblTableAdapter;
        private CanteenDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
