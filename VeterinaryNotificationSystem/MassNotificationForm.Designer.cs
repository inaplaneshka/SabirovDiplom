namespace VeterinaryNotificationSystem
{
    partial class MassNotificationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControlMass;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.TabPage tabPageRecipients;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.DateTimePicker dtpScheduledTime;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSendNow;
        private System.Windows.Forms.Panel panelRecipientsHeader;
        private System.Windows.Forms.Button btnFilterAnimals;
        private System.Windows.Forms.Button btnFilterOwners;
        private System.Windows.Forms.Label lblSelectionCount;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridView dataOwners;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnimals;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTest;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControlMass = new System.Windows.Forms.TabControl();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.chkSendNow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.dtpScheduledTime = new System.Windows.Forms.DateTimePicker();
            this.dtpScheduledDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageRecipients = new System.Windows.Forms.TabPage();
            this.dataOwners = new System.Windows.Forms.DataGridView();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnimals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRecipientsHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilterAnimals = new System.Windows.Forms.Button();
            this.btnFilterOwners = new System.Windows.Forms.Button();
            this.lblSelectionCount = new System.Windows.Forms.Label();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tabControlMass.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.tabPageRecipients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOwners)).BeginInit();
            this.panelRecipientsHeader.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(900, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Массовая рассылка";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.tabControlMass);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(900, 500);
            this.panelBody.TabIndex = 1;
            // 
            // tabControlMass
            // 
            this.tabControlMass.Controls.Add(this.tabPageMessage);
            this.tabControlMass.Controls.Add(this.tabPageRecipients);
            this.tabControlMass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMass.Location = new System.Drawing.Point(20, 20);
            this.tabControlMass.Name = "tabControlMass";
            this.tabControlMass.SelectedIndex = 0;
            this.tabControlMass.Size = new System.Drawing.Size(860, 460);
            this.tabControlMass.TabIndex = 0;
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageMessage.Controls.Add(this.groupBoxSettings);
            this.tabPageMessage.Controls.Add(this.groupBoxMessage);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 24);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessage.Size = new System.Drawing.Size(852, 432);
            this.tabPageMessage.TabIndex = 0;
            this.tabPageMessage.Text = "Сообщение";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.chkSendNow);
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.cmbChannel);
            this.groupBoxSettings.Controls.Add(this.dtpScheduledTime);
            this.groupBoxSettings.Controls.Add(this.dtpScheduledDate);
            this.groupBoxSettings.Controls.Add(this.label6);
            this.groupBoxSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxSettings.Location = new System.Drawing.Point(20, 260);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(812, 120);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки отправки";
            // 
            // chkSendNow
            // 
            this.chkSendNow.AutoSize = true;
            this.chkSendNow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSendNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.chkSendNow.Location = new System.Drawing.Point(600, 75);
            this.chkSendNow.Name = "chkSendNow";
            this.chkSendNow.Size = new System.Drawing.Size(123, 23);
            this.chkSendNow.TabIndex = 5;
            this.chkSendNow.Text = "Отправить сейчас";
            this.chkSendNow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Канал отправки*:";
            // 
            // cmbChannel
            // 
            this.cmbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(160, 32);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(200, 25);
            this.cmbChannel.TabIndex = 1;
            // 
            // dtpScheduledTime
            // 
            this.dtpScheduledTime.CustomFormat = "HH:mm";
            this.dtpScheduledTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpScheduledTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduledTime.Location = new System.Drawing.Point(300, 72);
            this.dtpScheduledTime.Name = "dtpScheduledTime";
            this.dtpScheduledTime.ShowUpDown = true;
            this.dtpScheduledTime.Size = new System.Drawing.Size(100, 25);
            this.dtpScheduledTime.TabIndex = 4;
            // 
            // dtpScheduledDate
            // 
            this.dtpScheduledDate.CustomFormat = "dd.MM.yyyy";
            this.dtpScheduledDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpScheduledDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduledDate.Location = new System.Drawing.Point(160, 72);
            this.dtpScheduledDate.Name = "dtpScheduledDate";
            this.dtpScheduledDate.Size = new System.Drawing.Size(140, 25);
            this.dtpScheduledDate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(30, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата отправки:";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMessage.Controls.Add(this.btnTest);
            this.groupBoxMessage.Controls.Add(this.label2);
            this.groupBoxMessage.Controls.Add(this.txtMessage);
            this.groupBoxMessage.Controls.Add(this.txtTitle);
            this.groupBoxMessage.Controls.Add(this.label3);
            this.groupBoxMessage.Controls.Add(this.cmbTemplate);
            this.groupBoxMessage.Controls.Add(this.label4);
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxMessage.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(812, 220);
            this.groupBoxMessage.TabIndex = 0;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Текст уведомления";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest.Location = new System.Drawing.Point(720, 67);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(60, 25);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сообщение:";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessage.Location = new System.Drawing.Point(160, 107);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(620, 100);
            this.txtMessage.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitle.Location = new System.Drawing.Point(160, 67);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(550, 25);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заголовок:";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(160, 27);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(300, 25);
            this.cmbTemplate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Шаблон:";
            // 
            // tabPageRecipients
            // 
            this.tabPageRecipients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageRecipients.Controls.Add(this.dataOwners);
            this.tabPageRecipients.Controls.Add(this.panelRecipientsHeader);
            this.tabPageRecipients.Location = new System.Drawing.Point(4, 24);
            this.tabPageRecipients.Name = "tabPageRecipients";
            this.tabPageRecipients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipients.Size = new System.Drawing.Size(852, 432);
            this.tabPageRecipients.TabIndex = 1;
            this.tabPageRecipients.Text = "Получатели";
            // 
            // dataOwners
            // 
            this.dataOwners.AllowUserToAddRows = false;
            this.dataOwners.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataOwners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOwners.BackgroundColor = System.Drawing.Color.White;
            this.dataOwners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOwners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataOwners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOwners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataOwners.ColumnHeadersHeight = 40;
            this.dataOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colOwnerId,
            this.colOwnerName,
            this.colOwnerPhone,
            this.colOwnerAddress,
            this.colAnimals});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOwners.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOwners.EnableHeadersVisualStyles = false;
            this.dataOwners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataOwners.Location = new System.Drawing.Point(3, 93);
            this.dataOwners.Name = "dataOwners";
            this.dataOwners.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataOwners.RowHeadersVisible = false;
            this.dataOwners.RowHeadersWidth = 50;
            this.dataOwners.RowTemplate.Height = 35;
            this.dataOwners.Size = new System.Drawing.Size(846, 336);
            this.dataOwners.TabIndex = 1;
            // 
            // colSelected
            // 
            this.colSelected.FillWeight = 50F;
            this.colSelected.HeaderText = "";
            this.colSelected.Name = "colSelected";
            // 
            // colOwnerId
            // 
            this.colOwnerId.DataPropertyName = "Id";
            this.colOwnerId.FillWeight = 50F;
            this.colOwnerId.HeaderText = "ID";
            this.colOwnerId.Name = "colOwnerId";
            this.colOwnerId.ReadOnly = true;
            // 
            // colOwnerName
            // 
            this.colOwnerName.DataPropertyName = "Name";
            this.colOwnerName.FillWeight = 180F;
            this.colOwnerName.HeaderText = "ФИО владельца";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.ReadOnly = true;
            // 
            // colOwnerPhone
            // 
            this.colOwnerPhone.DataPropertyName = "Phone";
            this.colOwnerPhone.FillWeight = 120F;
            this.colOwnerPhone.HeaderText = "Телефон";
            this.colOwnerPhone.Name = "colOwnerPhone";
            this.colOwnerPhone.ReadOnly = true;
            // 
            // colOwnerAddress
            // 
            this.colOwnerAddress.DataPropertyName = "Address";
            this.colOwnerAddress.FillWeight = 150F;
            this.colOwnerAddress.HeaderText = "Адрес";
            this.colOwnerAddress.Name = "colOwnerAddress";
            this.colOwnerAddress.ReadOnly = true;
            // 
            // colAnimals
            // 
            this.colAnimals.DataPropertyName = "Animals";
            this.colAnimals.FillWeight = 150F;
            this.colAnimals.HeaderText = "Животные";
            this.colAnimals.Name = "colAnimals";
            this.colAnimals.ReadOnly = true;
            // 
            // panelRecipientsHeader
            // 
            this.panelRecipientsHeader.BackColor = System.Drawing.Color.White;
            this.panelRecipientsHeader.Controls.Add(this.txtSearch);
            this.panelRecipientsHeader.Controls.Add(this.label7);
            this.panelRecipientsHeader.Controls.Add(this.btnFilterAnimals);
            this.panelRecipientsHeader.Controls.Add(this.btnFilterOwners);
            this.panelRecipientsHeader.Controls.Add(this.lblSelectionCount);
            this.panelRecipientsHeader.Controls.Add(this.btnDeselectAll);
            this.panelRecipientsHeader.Controls.Add(this.btnSelectAll);
            this.panelRecipientsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecipientsHeader.Location = new System.Drawing.Point(3, 3);
            this.panelRecipientsHeader.Name = "panelRecipientsHeader";
            this.panelRecipientsHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelRecipientsHeader.Size = new System.Drawing.Size(846, 90);
            this.panelRecipientsHeader.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(560, 50);
            this.txtSearch.Name = "txtSearch";
           
            this.txtSearch.Size = new System.Drawing.Size(270, 25);
            this.txtSearch.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(480, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Поиск:";
            // 
            // btnFilterAnimals
            // 
            this.btnFilterAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnFilterAnimals.FlatAppearance.BorderSize = 0;
            this.btnFilterAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAnimals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterAnimals.ForeColor = System.Drawing.Color.White;
            this.btnFilterAnimals.Location = new System.Drawing.Point(340, 10);
            this.btnFilterAnimals.Name = "btnFilterAnimals";
            this.btnFilterAnimals.Size = new System.Drawing.Size(130, 30);
            this.btnFilterAnimals.TabIndex = 4;
            this.btnFilterAnimals.Text = "Фильтр животных";
            this.btnFilterAnimals.UseVisualStyleBackColor = false;
            // 
            // btnFilterOwners
            // 
            this.btnFilterOwners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterOwners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnFilterOwners.FlatAppearance.BorderSize = 0;
            this.btnFilterOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterOwners.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterOwners.ForeColor = System.Drawing.Color.White;
            this.btnFilterOwners.Location = new System.Drawing.Point(480, 10);
            this.btnFilterOwners.Name = "btnFilterOwners";
            this.btnFilterOwners.Size = new System.Drawing.Size(130, 30);
            this.btnFilterOwners.TabIndex = 3;
            this.btnFilterOwners.Text = "Фильтр владельцев";
            this.btnFilterOwners.UseVisualStyleBackColor = false;
            // 
            // lblSelectionCount
            // 
            this.lblSelectionCount.AutoSize = true;
            this.lblSelectionCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblSelectionCount.Location = new System.Drawing.Point(10, 15);
            this.lblSelectionCount.Name = "lblSelectionCount";
            this.lblSelectionCount.Size = new System.Drawing.Size(98, 19);
            this.lblSelectionCount.TabIndex = 2;
            this.lblSelectionCount.Text = "Выбрано: 0 из 0";
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeselectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnDeselectAll.FlatAppearance.BorderSize = 0;
            this.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselectAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeselectAll.ForeColor = System.Drawing.Color.White;
            this.btnDeselectAll.Location = new System.Drawing.Point(200, 10);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(130, 30);
            this.btnDeselectAll.TabIndex = 1;
            this.btnDeselectAll.Text = "Снять выделение";
            this.btnDeselectAll.UseVisualStyleBackColor = false;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(60, 10);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(130, 30);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Выбрать все";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSend);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 570);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFooter.Size = new System.Drawing.Size(900, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(740, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(590, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 40);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "ОТПРАВИТЬ";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // MassNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MassNotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Массовая рассылка уведомлений";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tabControlMass.ResumeLayout(false);
            this.tabPageMessage.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.tabPageRecipients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOwners)).EndInit();
            this.panelRecipientsHeader.ResumeLayout(false);
            this.panelRecipientsHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}