namespace Canteen.ver1
{
    partial class UseMealVoucher
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterCustomerIDtextBox = new System.Windows.Forms.TextBox();
            this.DisplayNameTxtbox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ninebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.payablelabel = new System.Windows.Forms.Label();
            this.VoucherBalacelabel = new System.Windows.Forms.Label();
            this.RemainingBalancelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your ID:";
            // 
            // EnterCustomerIDtextBox
            // 
            this.EnterCustomerIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCustomerIDtextBox.Location = new System.Drawing.Point(12, 57);
            this.EnterCustomerIDtextBox.Name = "EnterCustomerIDtextBox";
            this.EnterCustomerIDtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EnterCustomerIDtextBox.Size = new System.Drawing.Size(251, 38);
            this.EnterCustomerIDtextBox.TabIndex = 5;
            this.EnterCustomerIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterCustomerIDtextBox.TextChanged += new System.EventHandler(this.EnterCustomerIDtextBox_TextChanged);
            // 
            // DisplayNameTxtbox
            // 
            this.DisplayNameTxtbox.AutoSize = true;
            this.DisplayNameTxtbox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameTxtbox.Location = new System.Drawing.Point(21, 98);
            this.DisplayNameTxtbox.Name = "DisplayNameTxtbox";
            this.DisplayNameTxtbox.Size = new System.Drawing.Size(242, 31);
            this.DisplayNameTxtbox.TabIndex = 6;
            this.DisplayNameTxtbox.Text = "Display Name Here";
            this.DisplayNameTxtbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisplayNameTxtbox.Click += new System.EventHandler(this.DisplayNameTxtbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meal Voucher";
            // 
            // ninebtn
            // 
            this.ninebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebtn.Location = new System.Drawing.Point(75, 204);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(147, 36);
            this.ninebtn.TabIndex = 22;
            this.ninebtn.Text = "Procceed";
            this.ninebtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemainingBalancelabel);
            this.panel1.Controls.Add(this.VoucherBalacelabel);
            this.panel1.Controls.Add(this.payablelabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ninebtn);
            this.panel1.Controls.Add(this.DisplayNameTxtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EnterCustomerIDtextBox);
            this.panel1.Location = new System.Drawing.Point(4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 245);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Remaining Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Payable:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Voucher Balance:";
            // 
            // payablelabel
            // 
            this.payablelabel.AutoSize = true;
            this.payablelabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payablelabel.Location = new System.Drawing.Point(181, 130);
            this.payablelabel.Name = "payablelabel";
            this.payablelabel.Size = new System.Drawing.Size(20, 23);
            this.payablelabel.TabIndex = 28;
            this.payablelabel.Text = "0";
            this.payablelabel.Click += new System.EventHandler(this.payablelabel_Click);
            // 
            // VoucherBalacelabel
            // 
            this.VoucherBalacelabel.AutoSize = true;
            this.VoucherBalacelabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoucherBalacelabel.Location = new System.Drawing.Point(181, 155);
            this.VoucherBalacelabel.Name = "VoucherBalacelabel";
            this.VoucherBalacelabel.Size = new System.Drawing.Size(20, 23);
            this.VoucherBalacelabel.TabIndex = 29;
            this.VoucherBalacelabel.Text = "0";
            this.VoucherBalacelabel.Click += new System.EventHandler(this.VoucherBalacelabel_Click);
            // 
            // RemainingBalancelabel
            // 
            this.RemainingBalancelabel.AutoSize = true;
            this.RemainingBalancelabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingBalancelabel.Location = new System.Drawing.Point(181, 178);
            this.RemainingBalancelabel.Name = "RemainingBalancelabel";
            this.RemainingBalancelabel.Size = new System.Drawing.Size(20, 23);
            this.RemainingBalancelabel.TabIndex = 30;
            this.RemainingBalancelabel.Text = "0";
            this.RemainingBalancelabel.Click += new System.EventHandler(this.RemainingBalancelabel_Click);
            // 
            // UseMealVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 243);
            this.Controls.Add(this.panel1);
            this.Name = "UseMealVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseMealVoucher";
            this.Load += new System.EventHandler(this.UseMealVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterCustomerIDtextBox;
        private System.Windows.Forms.Label DisplayNameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RemainingBalancelabel;
        private System.Windows.Forms.Label VoucherBalacelabel;
        private System.Windows.Forms.Label payablelabel;
    }
}