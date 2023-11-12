namespace Canteen.ver1.ADMIN_CONTROL
{
    partial class canteenstaff
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
            System.Windows.Forms.Label accountingnameLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.canteenstaffpicture = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.canteenstaffnametextBox = new System.Windows.Forms.TextBox();
            this.canteenstaffuserbtn = new System.Windows.Forms.Button();
            this.canteenstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenDBDataSet = new Canteen.ver1.CanteenDBDataSet();
            this.canteenstaffTableAdapter = new Canteen.ver1.CanteenDBDataSetTableAdapters.CanteenstaffTableAdapter();
            this.tableAdapterManager = new Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager();
            accountingnameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.canteenstaffuserbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 678);
            this.panel3.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.uploadbtn);
            this.groupBox1.Controls.Add(accountingnameLabel);
            this.groupBox1.Controls.Add(this.canteenstaffpicture);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.idtextBox);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.canteenstaffnametextBox);
            this.groupBox1.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 573);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD CANTEEN STAFF ACCOUNT";
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
            // canteenstaffpicture
            // 
            this.canteenstaffpicture.Image = global::Canteen.ver1.Properties.Resources.username;
            this.canteenstaffpicture.Location = new System.Drawing.Point(306, 35);
            this.canteenstaffpicture.Name = "canteenstaffpicture";
            this.canteenstaffpicture.Size = new System.Drawing.Size(214, 172);
            this.canteenstaffpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canteenstaffpicture.TabIndex = 37;
            this.canteenstaffpicture.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(195, 402);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(442, 42);
            this.usernameTextBox.TabIndex = 35;
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(195, 266);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(442, 42);
            this.idtextBox.TabIndex = 30;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(195, 470);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(442, 42);
            this.passwordtextBox.TabIndex = 33;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // canteenstaffnametextBox
            // 
            this.canteenstaffnametextBox.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canteenstaffnametextBox.Location = new System.Drawing.Point(195, 334);
            this.canteenstaffnametextBox.Name = "canteenstaffnametextBox";
            this.canteenstaffnametextBox.Size = new System.Drawing.Size(442, 42);
            this.canteenstaffnametextBox.TabIndex = 31;
            // 
            // canteenstaffuserbtn
            // 
            this.canteenstaffuserbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.canteenstaffuserbtn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canteenstaffuserbtn.Location = new System.Drawing.Point(632, 591);
            this.canteenstaffuserbtn.Name = "canteenstaffuserbtn";
            this.canteenstaffuserbtn.Size = new System.Drawing.Size(223, 51);
            this.canteenstaffuserbtn.TabIndex = 42;
            this.canteenstaffuserbtn.Text = "Show Users";
            this.canteenstaffuserbtn.UseVisualStyleBackColor = true;
            this.canteenstaffuserbtn.Click += new System.EventHandler(this.canteenstaffuserbtn_Click);
            // 
            // canteenstaffBindingSource
            // 
            this.canteenstaffBindingSource.DataMember = "Canteenstaff";
            this.canteenstaffBindingSource.DataSource = this.canteenDBDataSet;
            // 
            // canteenDBDataSet
            // 
            this.canteenDBDataSet.DataSetName = "CanteenDBDataSet";
            this.canteenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // canteenstaffTableAdapter
            // 
            this.canteenstaffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CanteenstaffTableAdapter = this.canteenstaffTableAdapter;
            this.tableAdapterManager.cashpaymentblTableAdapter = null;
            this.tableAdapterManager.customerchargestblTableAdapter = null;
            this.tableAdapterManager.customertblTableAdapter = null;
            this.tableAdapterManager.historylogstblTableAdapter = null;
            this.tableAdapterManager.paycreditreportstblTableAdapter = null;
            this.tableAdapterManager.tblaccountingTableAdapter = null;
            this.tableAdapterManager.tbladminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Canteen.ver1.CanteenDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // canteenstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "canteenstaff";
            this.Size = new System.Drawing.Size(1370, 678);
            this.Load += new System.EventHandler(this.canteenstaff_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource canteenstaffBindingSource;
        private CanteenDBDataSet canteenDBDataSet;
        private CanteenDBDataSetTableAdapters.CanteenstaffTableAdapter canteenstaffTableAdapter;
        private CanteenDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button canteenstaffuserbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.PictureBox canteenstaffpicture;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox canteenstaffnametextBox;
    }
}
