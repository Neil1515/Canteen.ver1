namespace Canteen.ver1
{
    partial class paymentmethod
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
            this.button1 = new System.Windows.Forms.Button();
            this.MealVoucherbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalpaylebel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "CASH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MealVoucherbtn
            // 
            this.MealVoucherbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealVoucherbtn.Location = new System.Drawing.Point(352, 132);
            this.MealVoucherbtn.Name = "MealVoucherbtn";
            this.MealVoucherbtn.Size = new System.Drawing.Size(164, 87);
            this.MealVoucherbtn.TabIndex = 1;
            this.MealVoucherbtn.Text = "USE MEAL VOUCHER";
            this.MealVoucherbtn.UseVisualStyleBackColor = true;
            this.MealVoucherbtn.Click += new System.EventHandler(this.MealVoucherbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAYMENT METHOD";
            // 
            // totalpaylebel
            // 
            this.totalpaylebel.AutoSize = true;
            this.totalpaylebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaylebel.Location = new System.Drawing.Point(26, 84);
            this.totalpaylebel.Name = "totalpaylebel";
            this.totalpaylebel.Size = new System.Drawing.Size(181, 31);
            this.totalpaylebel.TabIndex = 4;
            this.totalpaylebel.Text = "TOTAL PAY:";
            this.totalpaylebel.Click += new System.EventHandler(this.totalpaylebel_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(182, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "DEBT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // paymentmethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 228);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalpaylebel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MealVoucherbtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "paymentmethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentmethod";
            this.Load += new System.EventHandler(this.paymentmethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MealVoucherbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalpaylebel;
        private System.Windows.Forms.Button button2;
    }
}