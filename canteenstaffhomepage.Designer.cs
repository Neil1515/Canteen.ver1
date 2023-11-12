namespace Canteen.ver1
{
    partial class canteenstaffhomepage
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
            this.staffnamelabel = new System.Windows.Forms.Label();
            this.TopPanelAdmin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.merchandisebtn = new Guna.UI2.WinForms.Guna2Button();
            this.historylogsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageaccount1 = new Guna.UI2.WinForms.Guna2Button();
            this.reports1btn = new Guna.UI2.WinForms.Guna2Button();
            this.customercreditbtn = new Guna.UI2.WinForms.Guna2Button();
            this.customerpay1btn = new Guna.UI2.WinForms.Guna2Button();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashpanel = new System.Windows.Forms.Panel();
            this.canteenstaffpicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Logoutbrn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanelAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logoutbrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffnamelabel
            // 
            this.staffnamelabel.AutoSize = true;
            this.staffnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.staffnamelabel.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnamelabel.Location = new System.Drawing.Point(1178, 13);
            this.staffnamelabel.Name = "staffnamelabel";
            this.staffnamelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.staffnamelabel.Size = new System.Drawing.Size(76, 33);
            this.staffnamelabel.TabIndex = 38;
            this.staffnamelabel.Text = "Staff";
            this.staffnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staffnamelabel.Click += new System.EventHandler(this.staffnamelabel_Click);
            // 
            // TopPanelAdmin
            // 
            this.TopPanelAdmin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopPanelAdmin.Controls.Add(this.canteenstaffpicture);
            this.TopPanelAdmin.Controls.Add(this.Logoutbrn);
            this.TopPanelAdmin.Controls.Add(this.label2);
            this.TopPanelAdmin.Controls.Add(this.staffnamelabel);
            this.TopPanelAdmin.Controls.Add(this.pictureBox1);
            this.TopPanelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.TopPanelAdmin.Name = "TopPanelAdmin";
            this.TopPanelAdmin.Size = new System.Drawing.Size(1370, 59);
            this.TopPanelAdmin.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "SAWO CANTEEN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.merchandisebtn);
            this.panel2.Controls.Add(this.historylogsbtn);
            this.panel2.Controls.Add(this.manageaccount1);
            this.panel2.Controls.Add(this.reports1btn);
            this.panel2.Controls.Add(this.customercreditbtn);
            this.panel2.Controls.Add(this.customerpay1btn);
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 67);
            this.panel2.TabIndex = 40;
            // 
            // merchandisebtn
            // 
            this.merchandisebtn.BackColor = System.Drawing.Color.White;
            this.merchandisebtn.BorderRadius = 1;
            this.merchandisebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.merchandisebtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.merchandisebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.merchandisebtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.merchandisebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.merchandisebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.merchandisebtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.merchandisebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.merchandisebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.merchandisebtn.FillColor = System.Drawing.Color.White;
            this.merchandisebtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merchandisebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.merchandisebtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.merchandisebtn.Location = new System.Drawing.Point(1176, 0);
            this.merchandisebtn.Name = "merchandisebtn";
            this.merchandisebtn.Size = new System.Drawing.Size(196, 67);
            this.merchandisebtn.TabIndex = 41;
            this.merchandisebtn.Text = "MERCHANDISE";
            // 
            // historylogsbtn
            // 
            this.historylogsbtn.BackColor = System.Drawing.Color.White;
            this.historylogsbtn.BorderRadius = 1;
            this.historylogsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.historylogsbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.historylogsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.historylogsbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.historylogsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.historylogsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.historylogsbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.historylogsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.historylogsbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.historylogsbtn.FillColor = System.Drawing.Color.White;
            this.historylogsbtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historylogsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historylogsbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.historylogsbtn.Location = new System.Drawing.Point(980, 0);
            this.historylogsbtn.Name = "historylogsbtn";
            this.historylogsbtn.Size = new System.Drawing.Size(196, 67);
            this.historylogsbtn.TabIndex = 40;
            this.historylogsbtn.Text = "HISTORY LOGS";
            this.historylogsbtn.Click += new System.EventHandler(this.historylogsbtn_Click);
            // 
            // manageaccount1
            // 
            this.manageaccount1.BackColor = System.Drawing.Color.White;
            this.manageaccount1.BorderRadius = 1;
            this.manageaccount1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manageaccount1.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.manageaccount1.CheckedState.FillColor = System.Drawing.Color.White;
            this.manageaccount1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.manageaccount1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageaccount1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageaccount1.DisabledState.FillColor = System.Drawing.Color.White;
            this.manageaccount1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageaccount1.Dock = System.Windows.Forms.DockStyle.Left;
            this.manageaccount1.FillColor = System.Drawing.Color.White;
            this.manageaccount1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageaccount1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageaccount1.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.manageaccount1.Location = new System.Drawing.Point(784, 0);
            this.manageaccount1.Name = "manageaccount1";
            this.manageaccount1.Size = new System.Drawing.Size(196, 67);
            this.manageaccount1.TabIndex = 39;
            this.manageaccount1.Text = "MANAGE ACCOUNT";
            this.manageaccount1.Click += new System.EventHandler(this.manageaccount1_Click);
            // 
            // reports1btn
            // 
            this.reports1btn.BackColor = System.Drawing.Color.White;
            this.reports1btn.BorderRadius = 1;
            this.reports1btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.reports1btn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.reports1btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.reports1btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.reports1btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reports1btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reports1btn.DisabledState.FillColor = System.Drawing.Color.White;
            this.reports1btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reports1btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.reports1btn.FillColor = System.Drawing.Color.White;
            this.reports1btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports1btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reports1btn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.reports1btn.Location = new System.Drawing.Point(588, 0);
            this.reports1btn.Name = "reports1btn";
            this.reports1btn.Size = new System.Drawing.Size(196, 67);
            this.reports1btn.TabIndex = 38;
            this.reports1btn.Text = "REPORTS";
            this.reports1btn.Click += new System.EventHandler(this.reports1btn_Click);
            // 
            // customercreditbtn
            // 
            this.customercreditbtn.BackColor = System.Drawing.Color.White;
            this.customercreditbtn.BorderRadius = 1;
            this.customercreditbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customercreditbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.customercreditbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.customercreditbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.customercreditbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customercreditbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customercreditbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.customercreditbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customercreditbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.customercreditbtn.FillColor = System.Drawing.Color.White;
            this.customercreditbtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customercreditbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customercreditbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.customercreditbtn.Location = new System.Drawing.Point(392, 0);
            this.customercreditbtn.Name = "customercreditbtn";
            this.customercreditbtn.Size = new System.Drawing.Size(196, 67);
            this.customercreditbtn.TabIndex = 37;
            this.customercreditbtn.Text = "CUSTOMER CREDIT";
            this.customercreditbtn.Click += new System.EventHandler(this.customercreditbtn_Click);
            // 
            // customerpay1btn
            // 
            this.customerpay1btn.BackColor = System.Drawing.Color.White;
            this.customerpay1btn.BorderRadius = 1;
            this.customerpay1btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerpay1btn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.customerpay1btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.customerpay1btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.customerpay1btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerpay1btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerpay1btn.DisabledState.FillColor = System.Drawing.Color.White;
            this.customerpay1btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerpay1btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.customerpay1btn.FillColor = System.Drawing.Color.White;
            this.customerpay1btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerpay1btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerpay1btn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.customerpay1btn.Location = new System.Drawing.Point(196, 0);
            this.customerpay1btn.Name = "customerpay1btn";
            this.customerpay1btn.Size = new System.Drawing.Size(196, 67);
            this.customerpay1btn.TabIndex = 36;
            this.customerpay1btn.Text = "CUSTOMER PAY";
            this.customerpay1btn.Click += new System.EventHandler(this.customerpay1btn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.White;
            this.homebtn.BorderRadius = 1;
            this.homebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homebtn.Checked = true;
            this.homebtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.homebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.homebtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.homebtn.FillColor = System.Drawing.Color.White;
            this.homebtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homebtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.homebtn.Location = new System.Drawing.Point(0, 0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(196, 67);
            this.homebtn.TabIndex = 35;
            this.homebtn.Text = "HOME";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // dashpanel
            // 
            this.dashpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashpanel.Location = new System.Drawing.Point(0, 126);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(1370, 662);
            this.dashpanel.TabIndex = 41;
            // 
            // canteenstaffpicture
            // 
            this.canteenstaffpicture.BackColor = System.Drawing.Color.Transparent;
            this.canteenstaffpicture.FillColor = System.Drawing.Color.Transparent;
            this.canteenstaffpicture.Image = global::Canteen.ver1.Properties.Resources.profile_image;
            this.canteenstaffpicture.ImageRotate = 0F;
            this.canteenstaffpicture.Location = new System.Drawing.Point(1258, 3);
            this.canteenstaffpicture.Name = "canteenstaffpicture";
            this.canteenstaffpicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.canteenstaffpicture.Size = new System.Drawing.Size(53, 53);
            this.canteenstaffpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canteenstaffpicture.TabIndex = 34;
            this.canteenstaffpicture.TabStop = false;
            this.canteenstaffpicture.UseTransparentBackground = true;
            // 
            // Logoutbrn
            // 
            this.Logoutbrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logoutbrn.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbrn.BackgroundImage = global::Canteen.ver1.Properties.Resources._8723070_logout_icon;
            this.Logoutbrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoutbrn.Location = new System.Drawing.Point(1318, 8);
            this.Logoutbrn.Name = "Logoutbrn";
            this.Logoutbrn.Size = new System.Drawing.Size(44, 44);
            this.Logoutbrn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logoutbrn.TabIndex = 35;
            this.Logoutbrn.TabStop = false;
            this.Logoutbrn.Click += new System.EventHandler(this.Logoutbrn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Canteen.ver1.Properties.Resources.km_20231020_1080p_30f_20231020_084652__online_video_cutter_com_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // canteenstaffhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.dashpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopPanelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "canteenstaffhomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canteen Staff Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopPanelAdmin.ResumeLayout(false);
            this.TopPanelAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canteenstaffpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logoutbrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Logoutbrn;
        private System.Windows.Forms.Label staffnamelabel;
        private System.Windows.Forms.Panel TopPanelAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox canteenstaffpicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button manageaccount1;
        private Guna.UI2.WinForms.Guna2Button reports1btn;
        private Guna.UI2.WinForms.Guna2Button customercreditbtn;
        private Guna.UI2.WinForms.Guna2Button customerpay1btn;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private System.Windows.Forms.Panel dashpanel;
        private Guna.UI2.WinForms.Guna2Button historylogsbtn;
        private Guna.UI2.WinForms.Guna2Button merchandisebtn;
    }
}