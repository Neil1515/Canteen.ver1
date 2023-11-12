namespace Canteen.ver1
{
    partial class paymentcash
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
            this.label2 = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.excessAmountlabel = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Continue to pay ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 109);
            this.label2.TabIndex = 1;
            this.label2.Text = "CASH";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(256, 170);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(214, 66);
            this.confirmbtn.TabIndex = 3;
            this.confirmbtn.Text = "CONFIRM";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // excessAmountlabel
            // 
            this.excessAmountlabel.AutoSize = true;
            this.excessAmountlabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excessAmountlabel.Location = new System.Drawing.Point(272, 118);
            this.excessAmountlabel.Name = "excessAmountlabel";
            this.excessAmountlabel.Size = new System.Drawing.Size(37, 42);
            this.excessAmountlabel.TabIndex = 4;
            this.excessAmountlabel.Text = "0";
            this.excessAmountlabel.Click += new System.EventHandler(this.excessAmountlabel_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(19, 170);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(214, 66);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click_1);
            // 
            // paymentcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 248);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.excessAmountlabel);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "paymentcash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentcash";
            this.Load += new System.EventHandler(this.paymentcash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label excessAmountlabel;
        private System.Windows.Forms.Button cancelbtn;
    }
}