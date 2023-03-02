namespace x_ui_Selenium
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbNeeds = new System.Windows.Forms.GroupBox();
            this.txtTotalTraffic = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnGetConfigs = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bgInformation = new System.Windows.Forms.GroupBox();
            this.txtSubDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnSendConfigs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubAddress = new System.Windows.Forms.TextBox();
            this.btnStopBot = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChatId = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbNeeds.SuspendLayout();
            this.bgInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pgBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pgBar
            // 
            this.pgBar.Maximum = 150;
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 496);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbNeeds);
            this.tabPage1.Controls.Add(this.btnAddUser);
            this.tabPage1.Controls.Add(this.btnGetConfigs);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.bgInformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbNeeds
            // 
            this.gbNeeds.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbNeeds.Controls.Add(this.txtTotalTraffic);
            this.gbNeeds.Controls.Add(this.txtName);
            this.gbNeeds.Controls.Add(this.txtTo);
            this.gbNeeds.Controls.Add(this.label5);
            this.gbNeeds.Controls.Add(this.txtFrom);
            this.gbNeeds.Controls.Add(this.lbl);
            this.gbNeeds.Controls.Add(this.label2);
            this.gbNeeds.Controls.Add(this.label1);
            this.gbNeeds.Location = new System.Drawing.Point(8, 213);
            this.gbNeeds.Name = "gbNeeds";
            this.gbNeeds.Size = new System.Drawing.Size(333, 136);
            this.gbNeeds.TabIndex = 11;
            this.gbNeeds.TabStop = false;
            this.gbNeeds.Text = "Need : ";
            // 
            // txtTotalTraffic
            // 
            this.txtTotalTraffic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalTraffic.Location = new System.Drawing.Point(92, 109);
            this.txtTotalTraffic.Name = "txtTotalTraffic";
            this.txtTotalTraffic.Size = new System.Drawing.Size(235, 22);
            this.txtTotalTraffic.TabIndex = 8;
            this.txtTotalTraffic.Text = "30";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtName.Location = new System.Drawing.Point(92, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTo.Location = new System.Drawing.Point(92, 53);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(235, 22);
            this.txtTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Traffic :";
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFrom.Location = new System.Drawing.Point(92, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(235, 22);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.Text = "2";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 14);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(8, 394);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(333, 33);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnGetConfigs
            // 
            this.btnGetConfigs.Location = new System.Drawing.Point(8, 433);
            this.btnGetConfigs.Name = "btnGetConfigs";
            this.btnGetConfigs.Size = new System.Drawing.Size(333, 29);
            this.btnGetConfigs.TabIndex = 11;
            this.btnGetConfigs.Text = "Get Configs";
            this.btnGetConfigs.UseVisualStyleBackColor = true;
            this.btnGetConfigs.Click += new System.EventHandler(this.btnGetConfigs_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(333, 33);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // bgInformation
            // 
            this.bgInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bgInformation.Controls.Add(this.txtSubAddress);
            this.bgInformation.Controls.Add(this.txtSubDomain);
            this.bgInformation.Controls.Add(this.txtPassword);
            this.bgInformation.Controls.Add(this.txtPort);
            this.bgInformation.Controls.Add(this.label7);
            this.bgInformation.Controls.Add(this.txtUsername);
            this.bgInformation.Controls.Add(this.label4);
            this.bgInformation.Controls.Add(this.txtUrl);
            this.bgInformation.Controls.Add(this.label3);
            this.bgInformation.Controls.Add(this.lblPassword);
            this.bgInformation.Controls.Add(this.lblUsername);
            this.bgInformation.Controls.Add(this.lblUrl);
            this.bgInformation.Location = new System.Drawing.Point(8, 6);
            this.bgInformation.Name = "bgInformation";
            this.bgInformation.Size = new System.Drawing.Size(333, 201);
            this.bgInformation.TabIndex = 10;
            this.bgInformation.TabStop = false;
            this.bgInformation.Text = "Panel Information : ";
            // 
            // txtSubDomain
            // 
            this.txtSubDomain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSubDomain.Location = new System.Drawing.Point(92, 140);
            this.txtSubDomain.Name = "txtSubDomain";
            this.txtSubDomain.Size = new System.Drawing.Size(235, 22);
            this.txtSubDomain.TabIndex = 4;
            this.txtSubDomain.Text = "s1";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(92, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.Size = new System.Drawing.Size(235, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "admin12";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPort.Location = new System.Drawing.Point(92, 56);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(235, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "2053";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(92, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sub Domain :";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUrl.Location = new System.Drawing.Point(92, 28);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(235, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "mohsenvahedi.top";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 14);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 14);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username :";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(19, 28);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(55, 14);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Domain :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.btnStopBot);
            this.groupBox1.Controls.Add(this.btnSendConfigs);
            this.groupBox1.Controls.Add(this.txtChatId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Information : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Token : ";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(66, 24);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(271, 22);
            this.txtToken.TabIndex = 1;
            // 
            // btnSendConfigs
            // 
            this.btnSendConfigs.Location = new System.Drawing.Point(9, 91);
            this.btnSendConfigs.Name = "btnSendConfigs";
            this.btnSendConfigs.Size = new System.Drawing.Size(328, 23);
            this.btnSendConfigs.TabIndex = 2;
            this.btnSendConfigs.Text = "Start Bot";
            this.btnSendConfigs.UseVisualStyleBackColor = true;
            this.btnSendConfigs.Click += new System.EventHandler(this.btnSendConfigs_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sub Address :";
            // 
            // txtSubAddress
            // 
            this.txtSubAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSubAddress.Location = new System.Drawing.Point(92, 168);
            this.txtSubAddress.Name = "txtSubAddress";
            this.txtSubAddress.Size = new System.Drawing.Size(235, 22);
            this.txtSubAddress.TabIndex = 4;
            this.txtSubAddress.Text = "dns";
            // 
            // btnStopBot
            // 
            this.btnStopBot.Location = new System.Drawing.Point(10, 120);
            this.btnStopBot.Name = "btnStopBot";
            this.btnStopBot.Size = new System.Drawing.Size(328, 23);
            this.btnStopBot.TabIndex = 2;
            this.btnStopBot.Text = "Stop Bot";
            this.btnStopBot.UseVisualStyleBackColor = true;
            this.btnStopBot.Click += new System.EventHandler(this.btnStopBot_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chat ID :";
            // 
            // txtChatId
            // 
            this.txtChatId.Location = new System.Drawing.Point(66, 52);
            this.txtChatId.Name = "txtChatId";
            this.txtChatId.Size = new System.Drawing.Size(271, 22);
            this.txtChatId.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-UI Robot Selenium";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbNeeds.ResumeLayout(false);
            this.gbNeeds.PerformLayout();
            this.bgInformation.ResumeLayout(false);
            this.bgInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pgBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbNeeds;
        private System.Windows.Forms.TextBox txtTotalTraffic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnGetConfigs;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox bgInformation;
        private System.Windows.Forms.TextBox txtSubDomain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendConfigs;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStopBot;
        private System.Windows.Forms.TextBox txtChatId;
        private System.Windows.Forms.Label label8;
    }
}

