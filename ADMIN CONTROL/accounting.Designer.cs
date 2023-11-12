namespace Canteen.ver1.ADMIN_CONTROL
{
    partial class accounting
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label accountingnameLabel;
            System.Windows.Forms.Label usernameLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.accountingnametextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.tblaccountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenDBDataSet = new Canteen.ver1.CanteenDBDataSet();
            this.updatebtn = new System.Windows.Forms.Button();
            this.tblaccountingTableAdapter = new Canteen.ver1.CanteenDBDataSetTableAdapters.tblaccountingTableAdapter();
            this.tableAdapterManager = new Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.accountinguserbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountingpicture = new System.Windows.Forms.PictureBox();
            passwordLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            accountingnameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(191, 447);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(108, 20);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "PASSWORD:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(191, 243);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 20);
            idLabel.TabIndex = 23;
            idLabel.Text = "ID:";
            // 
            // accountingnameLabel
            // 
            accountingnameLabel.AutoSize = true;
            accountingnameLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountingnameLabel.Location = new System.Drawing.Point(191, 311);
            accountingnameLabel.Name = "accountingnameLabel";
            accountingnameLabel.Size = new System.Drawing.Size(65, 20);
            accountingnameLabel.TabIndex = 25;
            accountingnameLabel.Text = "NAME:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(191, 379);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(112, 20);
            usernameLabel.TabIndex = 34;
            usernameLabel.Text = "USERNAME:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accountinguserbtn);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 678);
            this.panel3.TabIndex = 14;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(195, 402);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(442, 42);
            this.usernameTextBox.TabIndex = 35;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(195, 470);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(442, 42);
            this.passwordtextBox.TabIndex = 33;
            this.passwordtextBox.UseSystemPasswordChar = true;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // accountingnametextBox
            // 
            this.accountingnametextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountingnametextBox.Location = new System.Drawing.Point(195, 334);
            this.accountingnametextBox.Name = "accountingnametextBox";
            this.accountingnametextBox.Size = new System.Drawing.Size(442, 42);
            this.accountingnametextBox.TabIndex = 31;
            this.accountingnametextBox.TextChanged += new System.EventHandler(this.accountingnametextBox_TextChanged);
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(195, 266);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(442, 42);
            this.idtextBox.TabIndex = 30;
            this.idtextBox.TextChanged += new System.EventHandler(this.idtextBox_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(433, 518);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(204, 46);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // tblaccountingBindingSource
            // 
            this.tblaccountingBindingSource.DataMember = "tblaccounting";
            this.tblaccountingBindingSource.DataSource = this.canteenDBDataSet;
            // 
            // canteenDBDataSet
            // 
            this.canteenDBDataSet.DataSetName = "CanteenDBDataSet";
            this.canteenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(195, 518);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(204, 46);
            this.updatebtn.TabIndex = 3;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // tblaccountingTableAdapter
            // 
            this.tblaccountingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CanteenstaffTableAdapter = null;
            this.tableAdapterManager.cashpaymentblTableAdapter = null;
            this.tableAdapterManager.customerchargestblTableAdapter = null;
            this.tableAdapterManager.customertblTableAdapter = null;
            this.tableAdapterManager.historylogstblTableAdapter = null;
            this.tableAdapterManager.paycreditreportstblTableAdapter = null;
            this.tableAdapterManager.tblaccountingTableAdapter = this.tblaccountingTableAdapter;
            this.tableAdapterManager.tbladminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uploadbtn
            // 
            this.uploadbtn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbtn.Location = new System.Drawing.Point(420, 213);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(152, 37);
            this.uploadbtn.TabIndex = 38;
            this.uploadbtn.Text = "Upload";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(262, 213);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(152, 37);
            this.removebtn.TabIndex = 40;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountinguserbtn
            // 
            this.accountinguserbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountinguserbtn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinguserbtn.Location = new System.Drawing.Point(632, 591);
            this.accountinguserbtn.Name = "accountinguserbtn";
            this.accountinguserbtn.Size = new System.Drawing.Size(223, 51);
            this.accountinguserbtn.TabIndex = 41;
            this.accountinguserbtn.Text = "Show Users";
            this.accountinguserbtn.UseVisualStyleBackColor = true;
            this.accountinguserbtn.Click += new System.EventHandler(this.accountinguserbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.uploadbtn);
            this.groupBox1.Controls.Add(accountingnameLabel);
            this.groupBox1.Controls.Add(this.accountingpicture);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.idtextBox);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.accountingnametextBox);
            this.groupBox1.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 573);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ACCOUNTING ACCOUNT";
            // 
            // accountingpicture
            // 
            this.accountingpicture.Image = global::Canteen.ver1.Properties.Resources.username;
            this.accountingpicture.Location = new System.Drawing.Point(306, 35);
            this.accountingpicture.Name = "accountingpicture";
            this.accountingpicture.Size = new System.Drawing.Size(214, 172);
            this.accountingpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accountingpicture.TabIndex = 37;
            this.accountingpicture.TabStop = false;
            this.accountingpicture.Click += new System.EventHandler(this.accountingpicture_Click);
            // 
            // accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "accounting";
            this.Size = new System.Drawing.Size(1370, 678);
            this.Load += new System.EventHandler(this.accounting_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.BindingSource tblaccountingBindingSource;
        private CanteenDBDataSet canteenDBDataSet;
        private CanteenDBDataSetTableAdapters.tblaccountingTableAdapter tblaccountingTableAdapter;
        private CanteenDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox accountingnametextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.PictureBox accountingpicture;
        private System.Windows.Forms.Button accountinguserbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
