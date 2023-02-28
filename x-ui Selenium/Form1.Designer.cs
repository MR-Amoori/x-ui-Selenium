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
            this.bgInformation = new System.Windows.Forms.GroupBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbNeeds = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtTotalTraffic = new System.Windows.Forms.TextBox();
            this.bgInformation.SuspendLayout();
            this.gbNeeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgInformation
            // 
            this.bgInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bgInformation.Controls.Add(this.txtPassword);
            this.bgInformation.Controls.Add(this.txtUsername);
            this.bgInformation.Controls.Add(this.txtUrl);
            this.bgInformation.Controls.Add(this.lblPassword);
            this.bgInformation.Controls.Add(this.lblUsername);
            this.bgInformation.Controls.Add(this.lblUrl);
            this.bgInformation.Location = new System.Drawing.Point(13, 12);
            this.bgInformation.Name = "bgInformation";
            this.bgInformation.Size = new System.Drawing.Size(336, 115);
            this.bgInformation.TabIndex = 0;
            this.bgInformation.TabStop = false;
            this.bgInformation.Text = "Panel Information : ";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(19, 28);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 14);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 59);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 14);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 14);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUrl.Location = new System.Drawing.Point(92, 28);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(238, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://s1.mohsenvahedi.top:2053/";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(92, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(238, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "admin";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(92, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.Size = new System.Drawing.Size(238, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "admin12";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(337, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbNeeds
            // 
            this.gbNeeds.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbNeeds.Controls.Add(this.txtTotalTraffic);
            this.gbNeeds.Controls.Add(this.txtTo);
            this.gbNeeds.Controls.Add(this.txtFrom);
            this.gbNeeds.Controls.Add(this.label3);
            this.gbNeeds.Controls.Add(this.label2);
            this.gbNeeds.Controls.Add(this.label1);
            this.gbNeeds.Location = new System.Drawing.Point(13, 133);
            this.gbNeeds.Name = "gbNeeds";
            this.gbNeeds.Size = new System.Drawing.Size(334, 116);
            this.gbNeeds.TabIndex = 6;
            this.gbNeeds.TabStop = false;
            this.gbNeeds.Text = "Need : ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Traffic :";
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFrom.Location = new System.Drawing.Point(92, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(236, 22);
            this.txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTo.Location = new System.Drawing.Point(92, 53);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(236, 22);
            this.txtTo.TabIndex = 6;
            // 
            // txtTotalTraffic
            // 
            this.txtTotalTraffic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalTraffic.Location = new System.Drawing.Point(92, 81);
            this.txtTotalTraffic.Name = "txtTotalTraffic";
            this.txtTotalTraffic.Size = new System.Drawing.Size(236, 22);
            this.txtTotalTraffic.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 293);
            this.Controls.Add(this.gbNeeds);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.bgInformation);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-UI Robot Selenium";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.bgInformation.ResumeLayout(false);
            this.bgInformation.PerformLayout();
            this.gbNeeds.ResumeLayout(false);
            this.gbNeeds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgInformation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox gbNeeds;
        private System.Windows.Forms.TextBox txtTotalTraffic;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

