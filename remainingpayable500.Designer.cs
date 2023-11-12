namespace Canteen.ver1
{
    partial class remainingpayable500
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
            this.Remaining500limitlabel = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Reach 500 limit Credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay:";
            // 
            // Remaining500limitlabel
            // 
            this.Remaining500limitlabel.AutoSize = true;
            this.Remaining500limitlabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remaining500limitlabel.Location = new System.Drawing.Point(275, 96);
            this.Remaining500limitlabel.Name = "Remaining500limitlabel";
            this.Remaining500limitlabel.Size = new System.Drawing.Size(64, 73);
            this.Remaining500limitlabel.TabIndex = 2;
            this.Remaining500limitlabel.Text = "0";
            this.Remaining500limitlabel.Click += new System.EventHandler(this.Remaining500limitlabel_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(10, 189);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(270, 55);
            this.cancelbtn.TabIndex = 38;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // proceedbtn
            // 
            this.proceedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedbtn.Location = new System.Drawing.Point(318, 189);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(270, 55);
            this.proceedbtn.TabIndex = 37;
            this.proceedbtn.Text = "Procceed";
            this.proceedbtn.UseVisualStyleBackColor = true;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // remainingpayable500
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 256);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.proceedbtn);
            this.Controls.Add(this.Remaining500limitlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "remainingpayable500";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remaining Payable";
            this.Load += new System.EventHandler(this.remainingpayable500_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Remaining500limitlabel;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button proceedbtn;
    }
}