namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    partial class paidcreditreports
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
            this.canteenDBDataSet = new Canteen.ver1.CanteenDBDataSet();
            this.paycreditreportstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paycreditreportstblTableAdapter = new Canteen.ver1.CanteenDBDataSetTableAdapters.paycreditreportstblTableAdapter();
            this.tableAdapterManager = new Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager();
            this.paycreditreportstblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycreditreportstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycreditreportstblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // canteenDBDataSet
            // 
            this.canteenDBDataSet.DataSetName = "CanteenDBDataSet";
            this.canteenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paycreditreportstblBindingSource
            // 
            this.paycreditreportstblBindingSource.DataMember = "paycreditreportstbl";
            this.paycreditreportstblBindingSource.DataSource = this.canteenDBDataSet;
            // 
            // paycreditreportstblTableAdapter
            // 
            this.paycreditreportstblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CanteenstaffTableAdapter = null;
            this.tableAdapterManager.cashpaymentblTableAdapter = null;
            this.tableAdapterManager.customerchargestblTableAdapter = null;
            this.tableAdapterManager.customertblTableAdapter = null;
            this.tableAdapterManager.historylogstblTableAdapter = null;
            this.tableAdapterManager.paycreditreportstblTableAdapter = this.paycreditreportstblTableAdapter;
            this.tableAdapterManager.tblaccountingTableAdapter = null;
            this.tableAdapterManager.tbladminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paycreditreportstblDataGridView
            // 
            this.paycreditreportstblDataGridView.AllowUserToAddRows = false;
            this.paycreditreportstblDataGridView.AllowUserToDeleteRows = false;
            this.paycreditreportstblDataGridView.AutoGenerateColumns = false;
            this.paycreditreportstblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paycreditreportstblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5});
            this.paycreditreportstblDataGridView.DataSource = this.paycreditreportstblBindingSource;
            this.paycreditreportstblDataGridView.Location = new System.Drawing.Point(42, 15);
            this.paycreditreportstblDataGridView.Name = "paycreditreportstblDataGridView";
            this.paycreditreportstblDataGridView.ReadOnly = true;
            this.paycreditreportstblDataGridView.Size = new System.Drawing.Size(1275, 546);
            this.paycreditreportstblDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customernameid";
            this.dataGridViewTextBoxColumn3.HeaderText = "CUSTOMER ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customername";
            this.dataGridViewTextBoxColumn4.HeaderText = "CUSTOMER NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amountpaid";
            this.dataGridViewTextBoxColumn2.HeaderText = "AMOUNT PAID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "canteenstaffnamerecievebaseonaccountlogin";
            this.dataGridViewTextBoxColumn6.HeaderText = "RECIEVE TO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "paidby";
            this.dataGridViewTextBoxColumn7.HeaderText = "PAID BY";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "daterecieve";
            this.dataGridViewTextBoxColumn5.HeaderText = "DATE RECIEVE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // paidcreditreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paycreditreportstblDataGridView);
            this.Name = "paidcreditreports";
            this.Size = new System.Drawing.Size(1370, 595);
            this.Load += new System.EventHandler(this.creditreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycreditreportstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycreditreportstblDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CanteenDBDataSet canteenDBDataSet;
        private System.Windows.Forms.BindingSource paycreditreportstblBindingSource;
        private CanteenDBDataSetTableAdapters.paycreditreportstblTableAdapter paycreditreportstblTableAdapter;
        private CanteenDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paycreditreportstblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
