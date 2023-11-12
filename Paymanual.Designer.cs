namespace Canteen.ver1
{
    partial class Paymanual
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
            this.confirmbtn = new System.Windows.Forms.Button();
            this.EnterIDnumbertextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerpictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Creditamountindatabasetxtbox = new System.Windows.Forms.Label();
            this.amountopay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.customerpictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(261, 261);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(152, 40);
            this.confirmbtn.TabIndex = 0;
            this.confirmbtn.Text = "CONFIRM";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // EnterIDnumbertextbox
            // 
            this.EnterIDnumbertextbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterIDnumbertextbox.Location = new System.Drawing.Point(177, 168);
            this.EnterIDnumbertextbox.Name = "EnterIDnumbertextbox";
            this.EnterIDnumbertextbox.Size = new System.Drawing.Size(235, 35);
            this.EnterIDnumbertextbox.TabIndex = 2;
            this.EnterIDnumbertextbox.TextChanged += new System.EventHandler(this.EnterIDnumbertextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "PAY CREDIT";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.namelabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Red;
            this.namelabel.Location = new System.Drawing.Point(7, 47);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(217, 40);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "NAME HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Id number";
            // 
            // customerpictureBox
            // 
            this.customerpictureBox.BackgroundImage = global::Canteen.ver1.Properties.Resources.profile_image;
            this.customerpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerpictureBox.Location = new System.Drawing.Point(7, 99);
            this.customerpictureBox.Name = "customerpictureBox";
            this.customerpictureBox.Size = new System.Drawing.Size(164, 158);
            this.customerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerpictureBox.TabIndex = 32;
            this.customerpictureBox.TabStop = false;
            this.customerpictureBox.Click += new System.EventHandler(this.customerpictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Amount to pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 55);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pay:";
            // 
            // Creditamountindatabasetxtbox
            // 
            this.Creditamountindatabasetxtbox.AutoSize = true;
            this.Creditamountindatabasetxtbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Creditamountindatabasetxtbox.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditamountindatabasetxtbox.Location = new System.Drawing.Point(265, 93);
            this.Creditamountindatabasetxtbox.Name = "Creditamountindatabasetxtbox";
            this.Creditamountindatabasetxtbox.Size = new System.Drawing.Size(48, 55);
            this.Creditamountindatabasetxtbox.TabIndex = 36;
            this.Creditamountindatabasetxtbox.Text = "0";
            this.Creditamountindatabasetxtbox.Click += new System.EventHandler(this.Creditamountindatabasetxtbox_Click);
            // 
            // amountopay
            // 
            this.amountopay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountopay.Location = new System.Drawing.Point(177, 222);
            this.amountopay.Name = "amountopay";
            this.amountopay.Size = new System.Drawing.Size(235, 35);
            this.amountopay.TabIndex = 37;
            this.amountopay.TextChanged += new System.EventHandler(this.amountopay_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Creditamountindatabasetxtbox);
            this.panel1.Controls.Add(this.amountopay);
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.EnterIDnumbertextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.customerpictureBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 307);
            this.panel1.TabIndex = 38;
            // 
            // Paymanual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 342);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paymanual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paymanual";
            this.Load += new System.EventHandler(this.Paymanual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerpictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.TextBox EnterIDnumbertextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox customerpictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Creditamountindatabasetxtbox;
        private System.Windows.Forms.TextBox amountopay;
        private System.Windows.Forms.Panel panel1;
    }
}