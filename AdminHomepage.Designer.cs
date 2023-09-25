namespace Canteen.ver1
{
    partial class AdminHomepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddMealVoucherbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addcutomerbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.TotalCustomer = new System.Windows.Forms.Label();
            this.TotalCanteenStaff = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 396);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "admin name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Canteen.ver1.Properties.Resources.profile_image;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TotalCustomer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(218, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL CUSTOMER";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TotalCanteenStaff);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(424, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TOTAL CANTEEN STAFF";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 103);
            this.button2.TabIndex = 4;
            this.button2.Text = "ADD STAFF ACCOUNT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddMealVoucherbtn
            // 
            this.AddMealVoucherbtn.Location = new System.Drawing.Point(424, 160);
            this.AddMealVoucherbtn.Name = "AddMealVoucherbtn";
            this.AddMealVoucherbtn.Size = new System.Drawing.Size(200, 103);
            this.AddMealVoucherbtn.TabIndex = 5;
            this.AddMealVoucherbtn.Text = "ADD CUSTOMER MEAL VOUCHER";
            this.AddMealVoucherbtn.UseVisualStyleBackColor = true;
            this.AddMealVoucherbtn.Click += new System.EventHandler(this.AddMealVoucherbtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 103);
            this.button4.TabIndex = 6;
            this.button4.Text = "NONE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addcutomerbtn
            // 
            this.addcutomerbtn.Location = new System.Drawing.Point(218, 160);
            this.addcutomerbtn.Name = "addcutomerbtn";
            this.addcutomerbtn.Size = new System.Drawing.Size(200, 103);
            this.addcutomerbtn.TabIndex = 7;
            this.addcutomerbtn.Text = "ADD CUSTOMER";
            this.addcutomerbtn.UseVisualStyleBackColor = true;
            this.addcutomerbtn.Click += new System.EventHandler(this.addcutomerbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(12, 349);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(179, 35);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseCompatibleTextRendering = true;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // TotalCustomer
            // 
            this.TotalCustomer.AutoSize = true;
            this.TotalCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalCustomer.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomer.Location = new System.Drawing.Point(71, 23);
            this.TotalCustomer.Name = "TotalCustomer";
            this.TotalCustomer.Size = new System.Drawing.Size(54, 61);
            this.TotalCustomer.TabIndex = 3;
            this.TotalCustomer.Text = "0";
            this.TotalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalCustomer.Click += new System.EventHandler(this.TotalCustomer_Click);
            // 
            // TotalCanteenStaff
            // 
            this.TotalCanteenStaff.AutoSize = true;
            this.TotalCanteenStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalCanteenStaff.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCanteenStaff.Location = new System.Drawing.Point(75, 22);
            this.TotalCanteenStaff.Name = "TotalCanteenStaff";
            this.TotalCanteenStaff.Size = new System.Drawing.Size(54, 61);
            this.TotalCanteenStaff.TabIndex = 4;
            this.TotalCanteenStaff.Text = "0";
            this.TotalCanteenStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 396);
            this.Controls.Add(this.addcutomerbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddMealVoucherbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHomepage";
            this.Text = "AdminHomepage";
            this.Load += new System.EventHandler(this.AdminHomepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddMealVoucherbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addcutomerbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label TotalCustomer;
        private System.Windows.Forms.Label TotalCanteenStaff;
    }
}