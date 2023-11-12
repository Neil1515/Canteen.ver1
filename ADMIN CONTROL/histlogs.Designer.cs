namespace Canteen.ver1.ADMIN_CONTROL
{
    partial class histlogs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.canteenDBDataSet0admin = new Canteen.ver1.CanteenDBDataSet0admin();
            this.historylogstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historylogstblTableAdapter = new Canteen.ver1.CanteenDBDataSet0adminTableAdapters.historylogstblTableAdapter();
            this.datetimeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet0admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeinDataGridViewTextBoxColumn,
            this.datetimeoutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historylogstblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(460, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(614, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // canteenDBDataSet0admin
            // 
            this.canteenDBDataSet0admin.DataSetName = "CanteenDBDataSet0admin";
            this.canteenDBDataSet0admin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historylogstblBindingSource
            // 
            this.historylogstblBindingSource.DataMember = "historylogstbl";
            this.historylogstblBindingSource.DataSource = this.canteenDBDataSet0admin;
            // 
            // historylogstblTableAdapter
            // 
            this.historylogstblTableAdapter.ClearBeforeFill = true;
            // 
            // datetimeinDataGridViewTextBoxColumn
            // 
            this.datetimeinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datetimeinDataGridViewTextBoxColumn.DataPropertyName = "datetimein";
            this.datetimeinDataGridViewTextBoxColumn.HeaderText = "DATE TIME IN";
            this.datetimeinDataGridViewTextBoxColumn.Name = "datetimeinDataGridViewTextBoxColumn";
            this.datetimeinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeoutDataGridViewTextBoxColumn
            // 
            this.datetimeoutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datetimeoutDataGridViewTextBoxColumn.DataPropertyName = "datetimeout";
            this.datetimeoutDataGridViewTextBoxColumn.HeaderText = "DATE TIME OUT";
            this.datetimeoutDataGridViewTextBoxColumn.Name = "datetimeoutDataGridViewTextBoxColumn";
            this.datetimeoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // histlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "histlogs";
            this.Size = new System.Drawing.Size(1370, 678);
            this.Load += new System.EventHandler(this.histlogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet0admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historylogstblBindingSource;
        private CanteenDBDataSet0admin canteenDBDataSet0admin;
        private CanteenDBDataSet0adminTableAdapters.historylogstblTableAdapter historylogstblTableAdapter;
    }
}
