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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.staffname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.fourbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.sixbtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.onebtn = new System.Windows.Forms.Button();
            this.equalbtn = new System.Windows.Forms.Button();
            this.dotbtn = new System.Windows.Forms.Button();
            this.zerobtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.negativebtn = new System.Windows.Forms.Button();
            this.timesbtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.ninebtn = new System.Windows.Forms.Button();
            this.eightbtn = new System.Windows.Forms.Button();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.percentbtn = new System.Windows.Forms.Button();
            this.paybtn = new System.Windows.Forms.Button();
            this.plusbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAWO CANTEEN MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logoutbtn);
            this.panel1.Controls.Add(this.staffname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 403);
            this.panel1.TabIndex = 2;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logoutbtn.Location = new System.Drawing.Point(0, 380);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(186, 23);
            this.Logoutbtn.TabIndex = 28;
            this.Logoutbtn.Text = "Log out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // staffname
            // 
            this.staffname.AutoSize = true;
            this.staffname.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffname.Location = new System.Drawing.Point(31, 116);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(129, 31);
            this.staffname.TabIndex = 4;
            this.staffname.Text = "staffname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Canteen.ver1.Properties.Resources.profile_image;
            this.pictureBox1.Location = new System.Drawing.Point(47, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // totaltextBox
            // 
            this.totaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltextBox.Location = new System.Drawing.Point(20, 44);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(363, 38);
            this.totaltextBox.TabIndex = 3;
            this.totaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fourbtn
            // 
            this.fourbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourbtn.Location = new System.Drawing.Point(21, 157);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(80, 63);
            this.fourbtn.TabIndex = 4;
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = true;
            this.fourbtn.Click += new System.EventHandler(this.fourbtn_Click);
            // 
            // fivebtn
            // 
            this.fivebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivebtn.Location = new System.Drawing.Point(107, 157);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(80, 63);
            this.fivebtn.TabIndex = 5;
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = true;
            this.fivebtn.Click += new System.EventHandler(this.fivebtn_Click);
            // 
            // sixbtn
            // 
            this.sixbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixbtn.Location = new System.Drawing.Point(193, 157);
            this.sixbtn.Name = "sixbtn";
            this.sixbtn.Size = new System.Drawing.Size(80, 63);
            this.sixbtn.TabIndex = 6;
            this.sixbtn.Text = "6";
            this.sixbtn.UseVisualStyleBackColor = true;
            this.sixbtn.Click += new System.EventHandler(this.sixbtn_Click);
            // 
            // threebtn
            // 
            this.threebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebtn.Location = new System.Drawing.Point(193, 226);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(80, 63);
            this.threebtn.TabIndex = 9;
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = true;
            this.threebtn.Click += new System.EventHandler(this.threebtn_Click);
            // 
            // twobtn
            // 
            this.twobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twobtn.Location = new System.Drawing.Point(107, 226);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(80, 63);
            this.twobtn.TabIndex = 8;
            this.twobtn.Text = "2";
            this.twobtn.UseVisualStyleBackColor = true;
            this.twobtn.Click += new System.EventHandler(this.twobtn_Click);
            // 
            // onebtn
            // 
            this.onebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebtn.Location = new System.Drawing.Point(21, 226);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(80, 63);
            this.onebtn.TabIndex = 7;
            this.onebtn.Text = "1";
            this.onebtn.UseVisualStyleBackColor = true;
            this.onebtn.Click += new System.EventHandler(this.onebtn_Click);
            // 
            // equalbtn
            // 
            this.equalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalbtn.Location = new System.Drawing.Point(193, 295);
            this.equalbtn.Name = "equalbtn";
            this.equalbtn.Size = new System.Drawing.Size(80, 63);
            this.equalbtn.TabIndex = 12;
            this.equalbtn.Text = "=";
            this.equalbtn.UseVisualStyleBackColor = true;
            this.equalbtn.Click += new System.EventHandler(this.equalbtn_Click);
            // 
            // dotbtn
            // 
            this.dotbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotbtn.Location = new System.Drawing.Point(21, 295);
            this.dotbtn.Name = "dotbtn";
            this.dotbtn.Size = new System.Drawing.Size(80, 63);
            this.dotbtn.TabIndex = 11;
            this.dotbtn.Text = ".";
            this.dotbtn.UseVisualStyleBackColor = true;
            this.dotbtn.Click += new System.EventHandler(this.dotbtn_Click);
            // 
            // zerobtn
            // 
            this.zerobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerobtn.Location = new System.Drawing.Point(107, 295);
            this.zerobtn.Name = "zerobtn";
            this.zerobtn.Size = new System.Drawing.Size(80, 63);
            this.zerobtn.TabIndex = 10;
            this.zerobtn.Text = "0";
            this.zerobtn.UseVisualStyleBackColor = true;
            this.zerobtn.Click += new System.EventHandler(this.zerobtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(303, 88);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(166, 63);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // negativebtn
            // 
            this.negativebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativebtn.Location = new System.Drawing.Point(303, 157);
            this.negativebtn.Name = "negativebtn";
            this.negativebtn.Size = new System.Drawing.Size(80, 63);
            this.negativebtn.TabIndex = 15;
            this.negativebtn.Text = "-";
            this.negativebtn.UseVisualStyleBackColor = true;
            this.negativebtn.Click += new System.EventHandler(this.negativebtn_Click);
            // 
            // timesbtn
            // 
            this.timesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesbtn.Location = new System.Drawing.Point(389, 226);
            this.timesbtn.Name = "timesbtn";
            this.timesbtn.Size = new System.Drawing.Size(80, 63);
            this.timesbtn.TabIndex = 18;
            this.timesbtn.Text = "x";
            this.timesbtn.UseVisualStyleBackColor = true;
            this.timesbtn.Click += new System.EventHandler(this.timesbtn_Click);
            // 
            // dividebtn
            // 
            this.dividebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebtn.Location = new System.Drawing.Point(303, 226);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(80, 63);
            this.dividebtn.TabIndex = 17;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = true;
            this.dividebtn.Click += new System.EventHandler(this.dividebtn_Click);
            // 
            // ninebtn
            // 
            this.ninebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebtn.Location = new System.Drawing.Point(193, 88);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(80, 63);
            this.ninebtn.TabIndex = 21;
            this.ninebtn.Text = "9";
            this.ninebtn.UseVisualStyleBackColor = true;
            this.ninebtn.Click += new System.EventHandler(this.ninebtn_Click);
            // 
            // eightbtn
            // 
            this.eightbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightbtn.Location = new System.Drawing.Point(107, 88);
            this.eightbtn.Name = "eightbtn";
            this.eightbtn.Size = new System.Drawing.Size(80, 63);
            this.eightbtn.TabIndex = 20;
            this.eightbtn.Text = "8";
            this.eightbtn.UseVisualStyleBackColor = true;
            this.eightbtn.Click += new System.EventHandler(this.eightbtn_Click);
            // 
            // sevenbtn
            // 
            this.sevenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbtn.Location = new System.Drawing.Point(21, 88);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(80, 63);
            this.sevenbtn.TabIndex = 19;
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = true;
            this.sevenbtn.Click += new System.EventHandler(this.sevenbtn_Click);
            // 
            // percentbtn
            // 
            this.percentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentbtn.Location = new System.Drawing.Point(389, 295);
            this.percentbtn.Name = "percentbtn";
            this.percentbtn.Size = new System.Drawing.Size(80, 63);
            this.percentbtn.TabIndex = 23;
            this.percentbtn.Text = "%";
            this.percentbtn.UseVisualStyleBackColor = true;
            this.percentbtn.Click += new System.EventHandler(this.percentbtn_Click);
            // 
            // paybtn
            // 
            this.paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.Location = new System.Drawing.Point(389, 43);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(80, 38);
            this.paybtn.TabIndex = 25;
            this.paybtn.Text = "Pay";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // plusbtn
            // 
            this.plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbtn.Location = new System.Drawing.Point(389, 157);
            this.plusbtn.Name = "plusbtn";
            this.plusbtn.Size = new System.Drawing.Size(80, 63);
            this.plusbtn.TabIndex = 26;
            this.plusbtn.Text = "+";
            this.plusbtn.UseVisualStyleBackColor = true;
            this.plusbtn.Click += new System.EventHandler(this.plusbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delbtn);
            this.panel2.Controls.Add(this.plusbtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.paybtn);
            this.panel2.Controls.Add(this.dividebtn);
            this.panel2.Controls.Add(this.percentbtn);
            this.panel2.Controls.Add(this.totaltextBox);
            this.panel2.Controls.Add(this.ninebtn);
            this.panel2.Controls.Add(this.fourbtn);
            this.panel2.Controls.Add(this.eightbtn);
            this.panel2.Controls.Add(this.fivebtn);
            this.panel2.Controls.Add(this.sevenbtn);
            this.panel2.Controls.Add(this.sixbtn);
            this.panel2.Controls.Add(this.timesbtn);
            this.panel2.Controls.Add(this.onebtn);
            this.panel2.Controls.Add(this.twobtn);
            this.panel2.Controls.Add(this.negativebtn);
            this.panel2.Controls.Add(this.threebtn);
            this.panel2.Controls.Add(this.clearbtn);
            this.panel2.Controls.Add(this.zerobtn);
            this.panel2.Controls.Add(this.equalbtn);
            this.panel2.Controls.Add(this.dotbtn);
            this.panel2.Location = new System.Drawing.Point(192, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 374);
            this.panel2.TabIndex = 27;
            // 
            // Delbtn
            // 
            this.Delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.Location = new System.Drawing.Point(303, 295);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(80, 63);
            this.Delbtn.TabIndex = 27;
            this.Delbtn.Text = "Del";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label staffname;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.Button sixbtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button equalbtn;
        private System.Windows.Forms.Button dotbtn;
        private System.Windows.Forms.Button zerobtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button negativebtn;
        private System.Windows.Forms.Button timesbtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Button eightbtn;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Button percentbtn;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Button plusbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logoutbtn;
        private Button Delbtn;
    }
}