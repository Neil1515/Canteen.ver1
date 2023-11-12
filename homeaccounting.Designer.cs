namespace Canteen.ver1.ACCOUNTING_CONTROL
{
    partial class homeaccounting
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCanteenStaff = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalCustomer = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TotalCanteenStaff);
            this.panel3.Location = new System.Drawing.Point(78, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 287);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "TOTAL CANTEEN STAFF";
            // 
            // TotalCanteenStaff
            // 
            this.TotalCanteenStaff.AutoSize = true;
            this.TotalCanteenStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalCanteenStaff.Font = new System.Drawing.Font("Times New Roman", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCanteenStaff.Location = new System.Drawing.Point(178, 31);
            this.TotalCanteenStaff.Name = "TotalCanteenStaff";
            this.TotalCanteenStaff.Size = new System.Drawing.Size(195, 226);
            this.TotalCanteenStaff.TabIndex = 4;
            this.TotalCanteenStaff.Text = "0";
            this.TotalCanteenStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TotalCustomer);
            this.panel4.Location = new System.Drawing.Point(691, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 287);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL CUSTOMER";
            // 
            // TotalCustomer
            // 
            this.TotalCustomer.AutoSize = true;
            this.TotalCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalCustomer.Font = new System.Drawing.Font("Times New Roman", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomer.Location = new System.Drawing.Point(162, 32);
            this.TotalCustomer.Name = "TotalCustomer";
            this.TotalCustomer.Size = new System.Drawing.Size(195, 226);
            this.TotalCustomer.TabIndex = 3;
            this.TotalCustomer.Text = "0";
            this.TotalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeaccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "homeaccounting";
            this.Size = new System.Drawing.Size(1284, 535);
            this.Load += new System.EventHandler(this.homeaccounting_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalCanteenStaff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalCustomer;
    }
}
