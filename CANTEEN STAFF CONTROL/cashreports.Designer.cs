namespace Canteen.ver1.CANTEEN_STAFF_CONTROL
{
    partial class cashreports
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
            this.TotalAmountSaleslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashpaymentblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenDBDataSet = new Canteen.ver1.CanteenDBDataSet();
            this.cashpaymentblTableAdapter = new Canteen.ver1.CanteenDBDataSetTableAdapters.cashpaymentblTableAdapter();
            this.tableAdapterManager = new Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpaymentblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalAmountSaleslabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 595);
            this.panel1.TabIndex = 36;
            // 
            // TotalAmountSaleslabel
            // 
            this.TotalAmountSaleslabel.AutoSize = true;
            this.TotalAmountSaleslabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountSaleslabel.Location = new System.Drawing.Point(957, 112);
            this.TotalAmountSaleslabel.Name = "TotalAmountSaleslabel";
            this.TotalAmountSaleslabel.Size = new System.Drawing.Size(21, 23);
            this.TotalAmountSaleslabel.TabIndex = 34;
            this.TotalAmountSaleslabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Total Amount Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Tracker";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(738, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(574, 50);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cashpaymentblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(114, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(601, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "PAID AMOUNT";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.dateDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashpaymentblBindingSource
            // 
            this.cashpaymentblBindingSource.DataMember = "cashpaymentbl";
            this.cashpaymentblBindingSource.DataSource = this.canteenDBDataSet;
            // 
            // canteenDBDataSet
            // 
            this.canteenDBDataSet.DataSetName = "CanteenDBDataSet";
            this.canteenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashpaymentblTableAdapter
            // 
            this.cashpaymentblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CanteenstaffTableAdapter = null;
            this.tableAdapterManager.cashpaymentblTableAdapter = this.cashpaymentblTableAdapter;
            this.tableAdapterManager.customerchargestblTableAdapter = null;
            this.tableAdapterManager.customertblTableAdapter = null;
            this.tableAdapterManager.historylogstblTableAdapter = null;
            this.tableAdapterManager.paycreditreportstblTableAdapter = null;
            this.tableAdapterManager.tblaccountingTableAdapter = null;
            this.tableAdapterManager.tbladminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cashreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "cashreports";
            this.Size = new System.Drawing.Size(1370, 595);
            this.Load += new System.EventHandler(this.cashreports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpaymentblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalAmountSaleslabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cashpaymentblBindingSource;
        private CanteenDBDataSet canteenDBDataSet;
        private CanteenDBDataSetTableAdapters.cashpaymentblTableAdapter cashpaymentblTableAdapter;
        private CanteenDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}
