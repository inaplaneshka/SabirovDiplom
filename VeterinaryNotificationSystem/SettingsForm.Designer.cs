namespace VeterinaryNotificationSystem
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageNotifications;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxSMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSMSProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMSSender;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEmailPort;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numExaminationDays;
        private System.Windows.Forms.Button btnTestSMS;
        private System.Windows.Forms.Button btnTestEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageNotifications = new System.Windows.Forms.TabPage();
            this.btnTestEmail = new System.Windows.Forms.Button();
            this.btnTestSMS = new System.Windows.Forms.Button();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.numEmailPort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSMS = new System.Windows.Forms.GroupBox();
            this.txtSMSSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMSProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.numExaminationDays = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageNotifications.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEmailPort)).BeginInit();
            this.groupBoxSMS.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExaminationDays)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.panelHeader.Size = new System.Drawing.Size(980, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.tabControlSettings);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(980, 430);
            this.panelBody.TabIndex = 1;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageNotifications);
            this.tabControlSettings.Controls.Add(this.tabPageGeneral);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(20, 20);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(940, 390);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPageNotifications
            // 
            this.tabPageNotifications.Controls.Add(this.btnTestEmail);
            this.tabPageNotifications.Controls.Add(this.btnTestSMS);
            this.tabPageNotifications.Controls.Add(this.groupBoxEmail);
            this.tabPageNotifications.Controls.Add(this.groupBoxSMS);
            this.tabPageNotifications.Location = new System.Drawing.Point(4, 29);
            this.tabPageNotifications.Name = "tabPageNotifications";
            this.tabPageNotifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotifications.Size = new System.Drawing.Size(932, 357);
            this.tabPageNotifications.TabIndex = 0;
            this.tabPageNotifications.Text = "Уведомления";
            this.tabPageNotifications.UseVisualStyleBackColor = true;
            // 
            // btnTestEmail
            // 
            this.btnTestEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnTestEmail.FlatAppearance.BorderSize = 0;
            this.btnTestEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestEmail.ForeColor = System.Drawing.Color.White;
            this.btnTestEmail.Location = new System.Drawing.Point(801, 316);
            this.btnTestEmail.Name = "btnTestEmail";
            this.btnTestEmail.Size = new System.Drawing.Size(100, 30);
            this.btnTestEmail.TabIndex = 3;
            this.btnTestEmail.Text = "Тест Email";
            this.btnTestEmail.UseVisualStyleBackColor = false;
            this.btnTestEmail.Click += new System.EventHandler(this.btnTestEmail_Click);
            // 
            // btnTestSMS
            // 
            this.btnTestSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTestSMS.FlatAppearance.BorderSize = 0;
            this.btnTestSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestSMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestSMS.ForeColor = System.Drawing.Color.White;
            this.btnTestSMS.Location = new System.Drawing.Point(686, 316);
            this.btnTestSMS.Name = "btnTestSMS";
            this.btnTestSMS.Size = new System.Drawing.Size(100, 30);
            this.btnTestSMS.TabIndex = 2;
            this.btnTestSMS.Text = "Тест SMS";
            this.btnTestSMS.UseVisualStyleBackColor = false;
            this.btnTestSMS.Click += new System.EventHandler(this.btnTestSMS_Click);
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmail.Controls.Add(this.chkUseSSL);
            this.groupBoxEmail.Controls.Add(this.numEmailPort);
            this.groupBoxEmail.Controls.Add(this.label6);
            this.groupBoxEmail.Controls.Add(this.txtEmailServer);
            this.groupBoxEmail.Controls.Add(this.label5);
            this.groupBoxEmail.Controls.Add(this.txtEmailSender);
            this.groupBoxEmail.Controls.Add(this.label4);
            this.groupBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxEmail.Location = new System.Drawing.Point(20, 180);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(892, 120);
            this.groupBoxEmail.TabIndex = 1;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Настройки Email";
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkUseSSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.chkUseSSL.Location = new System.Drawing.Point(666, 73);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(174, 27);
            this.chkUseSSL.TabIndex = 6;
            this.chkUseSSL.Text = "Использовать SSL";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // numEmailPort
            // 
            this.numEmailPort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numEmailPort.Location = new System.Drawing.Point(537, 72);
            this.numEmailPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numEmailPort.Name = "numEmailPort";
            this.numEmailPort.Size = new System.Drawing.Size(100, 30);
            this.numEmailPort.TabIndex = 5;
            this.numEmailPort.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(430, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Порт SMTP:";
            // 
            // txtEmailServer
            // 
            this.txtEmailServer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailServer.Location = new System.Drawing.Point(200, 73);
            this.txtEmailServer.Name = "txtEmailServer";
            this.txtEmailServer.Size = new System.Drawing.Size(220, 30);
            this.txtEmailServer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "SMTP сервер (хост):";
            // 
            // txtEmailSender
            // 
            this.txtEmailSender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailSender.Location = new System.Drawing.Point(200, 33);
            this.txtEmailSender.Name = "txtEmailSender";
            this.txtEmailSender.Size = new System.Drawing.Size(300, 30);
            this.txtEmailSender.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(30, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email отправителя:";
            // 
            // groupBoxSMS
            // 
            this.groupBoxSMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSMS.Controls.Add(this.txtSMSSender);
            this.groupBoxSMS.Controls.Add(this.label3);
            this.groupBoxSMS.Controls.Add(this.txtSMSProvider);
            this.groupBoxSMS.Controls.Add(this.label2);
            this.groupBoxSMS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxSMS.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSMS.Name = "groupBoxSMS";
            this.groupBoxSMS.Size = new System.Drawing.Size(892, 120);
            this.groupBoxSMS.TabIndex = 0;
            this.groupBoxSMS.TabStop = false;
            this.groupBoxSMS.Text = "Настройки SMS";
            // 
            // txtSMSSender
            // 
            this.txtSMSSender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSMSSender.Location = new System.Drawing.Point(200, 73);
            this.txtSMSSender.Name = "txtSMSSender";
            this.txtSMSSender.Size = new System.Drawing.Size(300, 30);
            this.txtSMSSender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя отправителя:";
            // 
            // txtSMSProvider
            // 
            this.txtSMSProvider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSMSProvider.Location = new System.Drawing.Point(200, 33);
            this.txtSMSProvider.Name = "txtSMSProvider";
            this.txtSMSProvider.Size = new System.Drawing.Size(300, 30);
            this.txtSMSProvider.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Провайдер SMS:";
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBoxGeneral);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(932, 361);
            this.tabPageGeneral.TabIndex = 1;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.numExaminationDays);
            this.groupBoxGeneral.Controls.Add(this.label8);
            this.groupBoxGeneral.Controls.Add(this.txtWorkingHours);
            this.groupBoxGeneral.Controls.Add(this.label7);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxGeneral.Location = new System.Drawing.Point(20, 20);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(892, 120);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Общие настройки";
            // 
            // numExaminationDays
            // 
            this.numExaminationDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numExaminationDays.Location = new System.Drawing.Point(300, 73);
            this.numExaminationDays.Maximum = new decimal(new int[] {
            730,
            0,
            0,
            0});
            this.numExaminationDays.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numExaminationDays.Name = "numExaminationDays";
            this.numExaminationDays.Size = new System.Drawing.Size(100, 30);
            this.numExaminationDays.TabIndex = 3;
            this.numExaminationDays.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(30, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Период между плановыми осмотрами (дней):";
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWorkingHours.Location = new System.Drawing.Point(200, 33);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(200, 30);
            this.txtWorkingHours.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(30, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Рабочие часы отправки:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 500);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelFooter.Size = new System.Drawing.Size(980, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(836, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageNotifications.ResumeLayout(false);
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEmailPort)).EndInit();
            this.groupBoxSMS.ResumeLayout(false);
            this.groupBoxSMS.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExaminationDays)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }


    }
}