using System.Windows.Forms;

namespace Canteen.ver1
{
    partial class DashBoard
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
        private void DashBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                totaltextBox.Text += e.KeyChar.ToString();
            }
            // Check if the pressed key is one of the operators (+, -, *, /, %, or .)
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%' || e.KeyChar == '.')
            {
                totaltextBox.Text += e.KeyChar.ToString();
            }
            // Check if the pressed key is Enter, which acts as the equal button
            else if (e.KeyChar == (char)Keys.Enter)
            {
                equalbtn_Click(sender, e);
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datelabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.chargebtn = new System.Windows.Forms.Button();
            this.cashpaymentbtn = new System.Windows.Forms.Button();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 788);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Canteen.ver1.Properties.Resources.sasa;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.datelabel);
            this.panel3.Controls.Add(this.timelabel);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.backbtn);
            this.panel3.Controls.Add(this.chargebtn);
            this.panel3.Controls.Add(this.cashpaymentbtn);
            this.panel3.Controls.Add(this.totaltextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 784);
            this.panel3.TabIndex = 32;
            // 
            // datelabel
            // 
            this.datelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datelabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(9, 702);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(152, 73);
            this.datelabel.TabIndex = 34;
            this.datelabel.Text = "Date";
            // 
            // timelabel
            // 
            this.timelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timelabel.AutoSize = true;
            this.timelabel.BackColor = System.Drawing.Color.Transparent;
            this.timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timelabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(9, 629);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(165, 73);
            this.timelabel.TabIndex = 33;
            this.timelabel.Text = "Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-18, -18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImage = global::Canteen.ver1.Properties.Resources._123;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(1311, 11);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(56, 56);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 30;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // chargebtn
            // 
            this.chargebtn.BackColor = System.Drawing.Color.Lime;
            this.chargebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chargebtn.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargebtn.Location = new System.Drawing.Point(747, 301);
            this.chargebtn.Name = "chargebtn";
            this.chargebtn.Size = new System.Drawing.Size(348, 98);
            this.chargebtn.TabIndex = 27;
            this.chargebtn.Text = "CHARGE";
            this.chargebtn.UseVisualStyleBackColor = false;
            this.chargebtn.Click += new System.EventHandler(this.chargebtn_Click);
            // 
            // cashpaymentbtn
            // 
            this.cashpaymentbtn.BackColor = System.Drawing.Color.IndianRed;
            this.cashpaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashpaymentbtn.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashpaymentbtn.Location = new System.Drawing.Point(339, 301);
            this.cashpaymentbtn.Name = "cashpaymentbtn";
            this.cashpaymentbtn.Size = new System.Drawing.Size(348, 98);
            this.cashpaymentbtn.TabIndex = 26;
            this.cashpaymentbtn.Text = "CASH";
            this.cashpaymentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cashpaymentbtn.UseVisualStyleBackColor = false;
            this.cashpaymentbtn.Click += new System.EventHandler(this.cashpaymentbtn_Click);
            // 
            // totaltextBox
            // 
            this.totaltextBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltextBox.Location = new System.Drawing.Point(339, 215);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(756, 81);
            this.totaltextBox.TabIndex = 3;
            this.totaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 77);
            this.label2.TabIndex = 28;
            this.label2.Text = "Amount to Pay";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Panel panel2;
        private Button chargebtn;
        private Button cashpaymentbtn;
        private Label label2;
        private Panel panel3;
        private PictureBox backbtn;
        private DateTimePicker dateTimePicker1;
        private Label timelabel;
        private Label datelabel;
        private Timer timer1;
    }
}