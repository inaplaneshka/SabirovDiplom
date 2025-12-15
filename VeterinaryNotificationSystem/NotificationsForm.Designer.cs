namespace VeterinaryNotificationSystem
{
    partial class NotificationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.TabPage tabPageTemplates;
        private System.Windows.Forms.Panel panelListHeader;
        private System.Windows.Forms.Button btnMassNotification;
        private System.Windows.Forms.Button btnSearchNotifications;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtSearchNotifications;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataNotifications;
        private System.Windows.Forms.Panel panelCreateHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelCreateBody;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnSendNow;
        private System.Windows.Forms.Button btnCancelNotification;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.DateTimePicker dtpScheduledTime;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbNotificationTemplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTemplatesHeader;
        private System.Windows.Forms.Label lblTemplateFormTitle;
        private System.Windows.Forms.Panel panelTemplatesBody;
        private System.Windows.Forms.Button btnCancelTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnEditTemplate;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.DataGridView dataTemplates;
        private System.Windows.Forms.GroupBox groupBoxTemplateEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTemplateVariables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTemplateTypeCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTemplateText;
        private System.Windows.Forms.TextBox txtTemplateTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelListFooter;
        private System.Windows.Forms.Button btnCancelScheduled;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.ComboBox cmbTemplateType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationScheduled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemplateStatus;
        private System.Windows.Forms.Panel panelCreateFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.panelListFooter = new System.Windows.Forms.Panel();
            this.btnCancelScheduled = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();
            this.panelListHeader = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTemplateType = new System.Windows.Forms.ComboBox();
            this.btnMassNotification = new System.Windows.Forms.Button();
            this.btnSearchNotifications = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchNotifications = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataNotifications = new System.Windows.Forms.DataGridView();
            this.colNotificationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.panelCreateFooter = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnSendNow = new System.Windows.Forms.Button();
            this.btnCancelNotification = new System.Windows.Forms.Button();
            this.panelCreateBody = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.dtpScheduledTime = new System.Windows.Forms.DateTimePicker();
            this.dtpScheduledDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectOwner = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbNotificationTemplate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCreateHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tabPageTemplates = new System.Windows.Forms.TabPage();
            this.panelTemplatesBody = new System.Windows.Forms.Panel();
            this.groupBoxTemplateEdit = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTemplateVariables = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTemplateTypeCreate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTemplateText = new System.Windows.Forms.TextBox();
            this.txtTemplateTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataTemplates = new System.Windows.Forms.DataGridView();
            this.colTemplateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemplateStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTemplatesHeader = new System.Windows.Forms.Panel();
            this.btnCancelTemplate = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btnEditTemplate = new System.Windows.Forms.Button();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.lblTemplateFormTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panelListFooter.SuspendLayout();
            this.panelListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifications)).BeginInit();
            this.tabPageCreate.SuspendLayout();
            this.panelCreateFooter.SuspendLayout();
            this.panelCreateBody.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.panelCreateHeader.SuspendLayout();
            this.tabPageTemplates.SuspendLayout();
            this.panelTemplatesBody.SuspendLayout();
            this.groupBoxTemplateEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTemplates)).BeginInit();
            this.panelTemplatesHeader.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уведомления";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPageList);
            this.tabControl.Controls.Add(this.tabPageCreate);
            this.tabControl.Controls.Add(this.tabPageTemplates);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 510);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageList.Controls.Add(this.panelListFooter);
            this.tabPageList.Controls.Add(this.panelListHeader);
            this.tabPageList.Controls.Add(this.dataNotifications);
            this.tabPageList.Location = new System.Drawing.Point(4, 5);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(972, 501);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Список";
            // 
            // panelListFooter
            // 
            this.panelListFooter.BackColor = System.Drawing.Color.White;
            this.panelListFooter.Controls.Add(this.btnCancelScheduled);
            this.panelListFooter.Controls.Add(this.btnResend);
            this.panelListFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListFooter.Location = new System.Drawing.Point(3, 421);
            this.panelListFooter.Name = "panelListFooter";
            this.panelListFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelListFooter.Size = new System.Drawing.Size(966, 77);
            this.panelListFooter.TabIndex = 2;
            // 
            // btnCancelScheduled
            // 
            this.btnCancelScheduled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnCancelScheduled.FlatAppearance.BorderSize = 0;
            this.btnCancelScheduled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelScheduled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelScheduled.ForeColor = System.Drawing.Color.White;
            this.btnCancelScheduled.Location = new System.Drawing.Point(140, 10);
            this.btnCancelScheduled.Name = "btnCancelScheduled";
            this.btnCancelScheduled.Size = new System.Drawing.Size(120, 40);
            this.btnCancelScheduled.TabIndex = 1;
            this.btnCancelScheduled.Text = "Отменить";
            this.btnCancelScheduled.UseVisualStyleBackColor = false;
            this.btnCancelScheduled.Click += new System.EventHandler(this.btnCancelScheduled_Click);
            // 
            // btnResend
            // 
            this.btnResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnResend.FlatAppearance.BorderSize = 0;
            this.btnResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResend.ForeColor = System.Drawing.Color.White;
            this.btnResend.Location = new System.Drawing.Point(20, 10);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(120, 40);
            this.btnResend.TabIndex = 0;
            this.btnResend.Text = "Повторить";
            this.btnResend.UseVisualStyleBackColor = false;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // panelListHeader
            // 
            this.panelListHeader.BackColor = System.Drawing.Color.White;
            this.panelListHeader.Controls.Add(this.label12);
            this.panelListHeader.Controls.Add(this.cmbTemplateType);
            this.panelListHeader.Controls.Add(this.btnMassNotification);
            this.panelListHeader.Controls.Add(this.btnSearchNotifications);
            this.panelListHeader.Controls.Add(this.cmbStatus);
            this.panelListHeader.Controls.Add(this.txtSearchNotifications);
            this.panelListHeader.Controls.Add(this.btnCreate);
            this.panelListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListHeader.Location = new System.Drawing.Point(3, 3);
            this.panelListHeader.Name = "panelListHeader";
            this.panelListHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelListHeader.Size = new System.Drawing.Size(966, 80);
            this.panelListHeader.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label12.Location = new System.Drawing.Point(420, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Шаблон:";
            // 
            // cmbTemplateType
            // 
            this.cmbTemplateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplateType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTemplateType.FormattingEnabled = true;
            this.cmbTemplateType.Location = new System.Drawing.Point(495, 23);
            this.cmbTemplateType.Name = "cmbTemplateType";
            this.cmbTemplateType.Size = new System.Drawing.Size(150, 28);
            this.cmbTemplateType.TabIndex = 6;
            // 
            // btnMassNotification
            // 
            this.btnMassNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMassNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnMassNotification.FlatAppearance.BorderSize = 0;
            this.btnMassNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMassNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMassNotification.ForeColor = System.Drawing.Color.White;
            this.btnMassNotification.Location = new System.Drawing.Point(826, 15);
            this.btnMassNotification.Name = "btnMassNotification";
            this.btnMassNotification.Size = new System.Drawing.Size(120, 40);
            this.btnMassNotification.TabIndex = 5;
            this.btnMassNotification.Text = "Массовая рассылка";
            this.btnMassNotification.UseVisualStyleBackColor = false;
            this.btnMassNotification.Click += new System.EventHandler(this.btnMassNotification_Click);
            // 
            // btnSearchNotifications
            // 
            this.btnSearchNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSearchNotifications.FlatAppearance.BorderSize = 0;
            this.btnSearchNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNotifications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchNotifications.ForeColor = System.Drawing.Color.White;
            this.btnSearchNotifications.Location = new System.Drawing.Point(310, 15);
            this.btnSearchNotifications.Name = "btnSearchNotifications";
            this.btnSearchNotifications.Size = new System.Drawing.Size(100, 40);
            this.btnSearchNotifications.TabIndex = 4;
            this.btnSearchNotifications.Text = "Поиск";
            this.btnSearchNotifications.UseVisualStyleBackColor = false;
            this.btnSearchNotifications.Click += new System.EventHandler(this.btnSearchNotifications_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(240, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(60, 28);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtSearchNotifications
            // 
            this.txtSearchNotifications.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchNotifications.Location = new System.Drawing.Point(20, 25);
            this.txtSearchNotifications.Name = "txtSearchNotifications";
            this.txtSearchNotifications.Size = new System.Drawing.Size(220, 30);
            this.txtSearchNotifications.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(700, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataNotifications
            // 
            this.dataNotifications.AllowUserToAddRows = false;
            this.dataNotifications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dataNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNotifications.ColumnHeadersHeight = 40;
            this.dataNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNotificationId,
            this.colNotificationTitle,
            this.colNotificationOwner,
            this.colNotificationAnimal,
            this.colNotificationChannel,
            this.colNotificationStatus,
            this.colNotificationScheduled,
            this.colNotificationCreated,
            this.colNotificationCreator});
            this.dataNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNotifications.EnableHeadersVisualStyles = false;
            this.dataNotifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataNotifications.Location = new System.Drawing.Point(3, 3);
            this.dataNotifications.Name = "dataNotifications";
            this.dataNotifications.ReadOnly = true;
            this.dataNotifications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNotifications.RowHeadersVisible = false;
            this.dataNotifications.RowHeadersWidth = 50;
            this.dataNotifications.RowTemplate.Height = 35;
            this.dataNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNotifications.Size = new System.Drawing.Size(966, 495);
            this.dataNotifications.TabIndex = 0;
            //this.dataNotifications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNotifications_CellDoubleClick);
            // 
            // colNotificationId
            // 
            this.colNotificationId.DataPropertyName = "Id";
            this.colNotificationId.FillWeight = 40F;
            this.colNotificationId.HeaderText = "ID";
            this.colNotificationId.MinimumWidth = 6;
            this.colNotificationId.Name = "colNotificationId";
            this.colNotificationId.ReadOnly = true;
            // 
            // colNotificationTitle
            // 
            this.colNotificationTitle.DataPropertyName = "Title";
            this.colNotificationTitle.FillWeight = 150F;
            this.colNotificationTitle.HeaderText = "Заголовок";
            this.colNotificationTitle.MinimumWidth = 6;
            this.colNotificationTitle.Name = "colNotificationTitle";
            this.colNotificationTitle.ReadOnly = true;
            // 
            // colNotificationOwner
            // 
            this.colNotificationOwner.DataPropertyName = "Owner";
            this.colNotificationOwner.FillWeight = 120F;
            this.colNotificationOwner.HeaderText = "Владелец";
            this.colNotificationOwner.MinimumWidth = 6;
            this.colNotificationOwner.Name = "colNotificationOwner";
            this.colNotificationOwner.ReadOnly = true;
            // 
            // colNotificationAnimal
            // 
            this.colNotificationAnimal.DataPropertyName = "Animal";
            this.colNotificationAnimal.HeaderText = "Животное";
            this.colNotificationAnimal.MinimumWidth = 6;
            this.colNotificationAnimal.Name = "colNotificationAnimal";
            this.colNotificationAnimal.ReadOnly = true;
            // 
            // colNotificationChannel
            // 
            this.colNotificationChannel.DataPropertyName = "Channel";
            this.colNotificationChannel.FillWeight = 80F;
            this.colNotificationChannel.HeaderText = "Канал";
            this.colNotificationChannel.MinimumWidth = 6;
            this.colNotificationChannel.Name = "colNotificationChannel";
            this.colNotificationChannel.ReadOnly = true;
            // 
            // colNotificationStatus
            // 
            this.colNotificationStatus.DataPropertyName = "Status";
            this.colNotificationStatus.HeaderText = "Статус";
            this.colNotificationStatus.MinimumWidth = 6;
            this.colNotificationStatus.Name = "colNotificationStatus";
            this.colNotificationStatus.ReadOnly = true;
            // 
            // colNotificationScheduled
            // 
            this.colNotificationScheduled.DataPropertyName = "Scheduled";
            this.colNotificationScheduled.FillWeight = 120F;
            this.colNotificationScheduled.HeaderText = "Запланировано";
            this.colNotificationScheduled.MinimumWidth = 6;
            this.colNotificationScheduled.Name = "colNotificationScheduled";
            this.colNotificationScheduled.ReadOnly = true;
            // 
            // colNotificationCreated
            // 
            this.colNotificationCreated.DataPropertyName = "Created";
            this.colNotificationCreated.HeaderText = "Создано";
            this.colNotificationCreated.MinimumWidth = 6;
            this.colNotificationCreated.Name = "colNotificationCreated";
            this.colNotificationCreated.ReadOnly = true;
            // 
            // colNotificationCreator
            // 
            this.colNotificationCreator.DataPropertyName = "Creator";
            this.colNotificationCreator.FillWeight = 120F;
            this.colNotificationCreator.HeaderText = "Создатель";
            this.colNotificationCreator.MinimumWidth = 6;
            this.colNotificationCreator.Name = "colNotificationCreator";
            this.colNotificationCreator.ReadOnly = true;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageCreate.Controls.Add(this.panelCreateFooter);
            this.tabPageCreate.Controls.Add(this.panelCreateBody);
            this.tabPageCreate.Controls.Add(this.panelCreateHeader);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 5);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(192, 91);
            this.tabPageCreate.TabIndex = 1;
            this.tabPageCreate.Text = "Создание";
            // 
            // panelCreateFooter
            // 
            this.panelCreateFooter.BackColor = System.Drawing.Color.White;
            this.panelCreateFooter.Controls.Add(this.btnPreview);
            this.panelCreateFooter.Controls.Add(this.btnSchedule);
            this.panelCreateFooter.Controls.Add(this.btnSendNow);
            this.panelCreateFooter.Controls.Add(this.btnCancelNotification);
            this.panelCreateFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCreateFooter.Location = new System.Drawing.Point(3, 11);
            this.panelCreateFooter.Name = "panelCreateFooter";
            this.panelCreateFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelCreateFooter.Size = new System.Drawing.Size(186, 77);
            this.panelCreateFooter.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(280, 10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(120, 40);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Предпросмотр";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(140, 10);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(140, 40);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Запланировать";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnSendNow
            // 
            this.btnSendNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnSendNow.FlatAppearance.BorderSize = 0;
            this.btnSendNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendNow.ForeColor = System.Drawing.Color.White;
            this.btnSendNow.Location = new System.Drawing.Point(20, 10);
            this.btnSendNow.Name = "btnSendNow";
            this.btnSendNow.Size = new System.Drawing.Size(120, 40);
            this.btnSendNow.TabIndex = 1;
            this.btnSendNow.Text = "Отправить сейчас";
            this.btnSendNow.UseVisualStyleBackColor = false;
            this.btnSendNow.Click += new System.EventHandler(this.btnSendNow_Click);
            // 
            // btnCancelNotification
            // 
            this.btnCancelNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelNotification.FlatAppearance.BorderSize = 0;
            this.btnCancelNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelNotification.ForeColor = System.Drawing.Color.White;
            this.btnCancelNotification.Location = new System.Drawing.Point(66, 10);
            this.btnCancelNotification.Name = "btnCancelNotification";
            this.btnCancelNotification.Size = new System.Drawing.Size(100, 40);
            this.btnCancelNotification.TabIndex = 0;
            this.btnCancelNotification.Text = "Отмена";
            this.btnCancelNotification.UseVisualStyleBackColor = false;
            this.btnCancelNotification.Click += new System.EventHandler(this.btnCancelNotification_Click);
            // 
            // panelCreateBody
            // 
            this.panelCreateBody.AutoScroll = true;
            this.panelCreateBody.BackColor = System.Drawing.Color.White;
            this.panelCreateBody.Controls.Add(this.groupBoxDetails);
            this.panelCreateBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateBody.Location = new System.Drawing.Point(3, 53);
            this.panelCreateBody.Name = "panelCreateBody";
            this.panelCreateBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelCreateBody.Size = new System.Drawing.Size(186, 35);
            this.panelCreateBody.TabIndex = 1;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.cmbChannel);
            this.groupBoxDetails.Controls.Add(this.dtpScheduledTime);
            this.groupBoxDetails.Controls.Add(this.dtpScheduledDate);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.btnSelectAnimal);
            this.groupBoxDetails.Controls.Add(this.txtAnimal);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.btnSelectOwner);
            this.groupBoxDetails.Controls.Add(this.txtOwner);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.txtMessage);
            this.groupBoxDetails.Controls.Add(this.txtTitle);
            this.groupBoxDetails.Controls.Add(this.lblMessage);
            this.groupBoxDetails.Controls.Add(this.lblTitle);
            this.groupBoxDetails.Controls.Add(this.cmbNotificationTemplate);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxDetails.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(146, 0);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Детали уведомления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(30, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Канал отправки*:";
            // 
            // cmbChannel
            // 
            this.cmbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(160, 247);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(200, 31);
            this.cmbChannel.TabIndex = 6;
            // 
            // dtpScheduledTime
            // 
            this.dtpScheduledTime.CustomFormat = "HH:mm";
            this.dtpScheduledTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpScheduledTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduledTime.Location = new System.Drawing.Point(300, 287);
            this.dtpScheduledTime.Name = "dtpScheduledTime";
            this.dtpScheduledTime.ShowUpDown = true;
            this.dtpScheduledTime.Size = new System.Drawing.Size(100, 30);
            this.dtpScheduledTime.TabIndex = 8;
            // 
            // dtpScheduledDate
            // 
            this.dtpScheduledDate.CustomFormat = "dd.MM.yyyy";
            this.dtpScheduledDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpScheduledDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduledDate.Location = new System.Drawing.Point(160, 287);
            this.dtpScheduledDate.Name = "dtpScheduledDate";
            this.dtpScheduledDate.Size = new System.Drawing.Size(140, 30);
            this.dtpScheduledDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(30, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата отправки:";
            // 
            // btnSelectAnimal
            // 
            this.btnSelectAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSelectAnimal.FlatAppearance.BorderSize = 0;
            this.btnSelectAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAnimal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAnimal.ForeColor = System.Drawing.Color.White;
            this.btnSelectAnimal.Location = new System.Drawing.Point(770, 167);
            this.btnSelectAnimal.Name = "btnSelectAnimal";
            this.btnSelectAnimal.Size = new System.Drawing.Size(100, 25);
            this.btnSelectAnimal.TabIndex = 4;
            this.btnSelectAnimal.Text = "Выбрать";
            this.btnSelectAnimal.UseVisualStyleBackColor = false;
            this.btnSelectAnimal.Click += new System.EventHandler(this.btnSelectAnimal_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnimal.Location = new System.Drawing.Point(160, 167);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.ReadOnly = true;
            this.txtAnimal.Size = new System.Drawing.Size(600, 30);
            this.txtAnimal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Животное:";
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSelectOwner.FlatAppearance.BorderSize = 0;
            this.btnSelectOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectOwner.ForeColor = System.Drawing.Color.White;
            this.btnSelectOwner.Location = new System.Drawing.Point(770, 127);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(100, 25);
            this.btnSelectOwner.TabIndex = 2;
            this.btnSelectOwner.Text = "Выбрать";
            this.btnSelectOwner.UseVisualStyleBackColor = false;
            this.btnSelectOwner.Click += new System.EventHandler(this.btnSelectOwner_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOwner.Location = new System.Drawing.Point(160, 127);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(600, 30);
            this.txtOwner.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Получатель:";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessage.Location = new System.Drawing.Point(160, 207);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(710, 30);
            this.txtMessage.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitle.Location = new System.Drawing.Point(160, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(710, 30);
            this.txtTitle.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblMessage.Location = new System.Drawing.Point(30, 210);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(107, 23);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Сообщение:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Заголовок:";
            // 
            // cmbNotificationTemplate
            // 
            this.cmbNotificationTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotificationTemplate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNotificationTemplate.FormattingEnabled = true;
            this.cmbNotificationTemplate.Location = new System.Drawing.Point(160, 47);
            this.cmbNotificationTemplate.Name = "cmbNotificationTemplate";
            this.cmbNotificationTemplate.Size = new System.Drawing.Size(300, 31);
            this.cmbNotificationTemplate.TabIndex = 1;
            this.cmbNotificationTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbNotificationTemplate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(30, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Шаблон:";
            // 
            // panelCreateHeader
            // 
            this.panelCreateHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelCreateHeader.Controls.Add(this.lblFormTitle);
            this.panelCreateHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateHeader.Location = new System.Drawing.Point(3, 3);
            this.panelCreateHeader.Name = "panelCreateHeader";
            this.panelCreateHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelCreateHeader.Size = new System.Drawing.Size(186, 50);
            this.panelCreateHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(244, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Создание уведомления";
            // 
            // tabPageTemplates
            // 
            this.tabPageTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageTemplates.Controls.Add(this.panelTemplatesBody);
            this.tabPageTemplates.Controls.Add(this.panelTemplatesHeader);
            this.tabPageTemplates.Location = new System.Drawing.Point(4, 5);
            this.tabPageTemplates.Name = "tabPageTemplates";
            this.tabPageTemplates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemplates.Size = new System.Drawing.Size(192, 91);
            this.tabPageTemplates.TabIndex = 2;
            this.tabPageTemplates.Text = "Шаблоны";
            // 
            // panelTemplatesBody
            // 
            this.panelTemplatesBody.AutoScroll = true;
            this.panelTemplatesBody.BackColor = System.Drawing.Color.White;
            this.panelTemplatesBody.Controls.Add(this.groupBoxTemplateEdit);
            this.panelTemplatesBody.Controls.Add(this.dataTemplates);
            this.panelTemplatesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemplatesBody.Location = new System.Drawing.Point(3, 53);
            this.panelTemplatesBody.Name = "panelTemplatesBody";
            this.panelTemplatesBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelTemplatesBody.Size = new System.Drawing.Size(186, 35);
            this.panelTemplatesBody.TabIndex = 1;
            // 
            // groupBoxTemplateEdit
            // 
            this.groupBoxTemplateEdit.Controls.Add(this.label7);
            this.groupBoxTemplateEdit.Controls.Add(this.txtTemplateVariables);
            this.groupBoxTemplateEdit.Controls.Add(this.label8);
            this.groupBoxTemplateEdit.Controls.Add(this.cmbTemplateTypeCreate);
            this.groupBoxTemplateEdit.Controls.Add(this.label9);
            this.groupBoxTemplateEdit.Controls.Add(this.txtTemplateText);
            this.groupBoxTemplateEdit.Controls.Add(this.txtTemplateTitle);
            this.groupBoxTemplateEdit.Controls.Add(this.label10);
            this.groupBoxTemplateEdit.Controls.Add(this.label11);
            this.groupBoxTemplateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTemplateEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTemplateEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxTemplateEdit.Location = new System.Drawing.Point(20, 220);
            this.groupBoxTemplateEdit.Name = "groupBoxTemplateEdit";
            this.groupBoxTemplateEdit.Size = new System.Drawing.Size(125, 0);
            this.groupBoxTemplateEdit.TabIndex = 1;
            this.groupBoxTemplateEdit.TabStop = false;
            this.groupBoxTemplateEdit.Text = "Редактирование шаблона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(30, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Доступные переменные:";
            // 
            // txtTemplateVariables
            // 
            this.txtTemplateVariables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemplateVariables.Location = new System.Drawing.Point(170, 157);
            this.txtTemplateVariables.Name = "txtTemplateVariables";
            this.txtTemplateVariables.Size = new System.Drawing.Size(700, 30);
            this.txtTemplateVariables.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(30, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Тип шаблона:";
            // 
            // cmbTemplateTypeCreate
            // 
            this.cmbTemplateTypeCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplateTypeCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTemplateTypeCreate.FormattingEnabled = true;
            this.cmbTemplateTypeCreate.Location = new System.Drawing.Point(170, 37);
            this.cmbTemplateTypeCreate.Name = "cmbTemplateTypeCreate";
            this.cmbTemplateTypeCreate.Size = new System.Drawing.Size(300, 31);
            this.cmbTemplateTypeCreate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label9.Location = new System.Drawing.Point(30, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Название шаблона:";
            // 
            // txtTemplateText
            // 
            this.txtTemplateText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemplateText.Location = new System.Drawing.Point(170, 117);
            this.txtTemplateText.Name = "txtTemplateText";
            this.txtTemplateText.Size = new System.Drawing.Size(700, 30);
            this.txtTemplateText.TabIndex = 3;
            // 
            // txtTemplateTitle
            // 
            this.txtTemplateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemplateTitle.Location = new System.Drawing.Point(170, 77);
            this.txtTemplateTitle.Name = "txtTemplateTitle";
            this.txtTemplateTitle.Size = new System.Drawing.Size(700, 30);
            this.txtTemplateTitle.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label10.Location = new System.Drawing.Point(30, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Текст шаблона:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label11.Location = new System.Drawing.Point(170, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Используйте переменные в тексте в формате {Переменная}";
            // 
            // dataTemplates
            // 
            this.dataTemplates.AllowUserToAddRows = false;
            this.dataTemplates.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataTemplates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTemplates.BackgroundColor = System.Drawing.Color.White;
            this.dataTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTemplates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTemplates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTemplates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTemplates.ColumnHeadersHeight = 40;
            this.dataTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTemplateName,
            this.colTemplateType,
            this.colTemplateModified,
            this.colTemplateStatus});
            this.dataTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataTemplates.EnableHeadersVisualStyles = false;
            this.dataTemplates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataTemplates.Location = new System.Drawing.Point(20, 20);
            this.dataTemplates.Name = "dataTemplates";
            this.dataTemplates.ReadOnly = true;
            this.dataTemplates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTemplates.RowHeadersVisible = false;
            this.dataTemplates.RowHeadersWidth = 50;
            this.dataTemplates.RowTemplate.Height = 35;
            this.dataTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTemplates.Size = new System.Drawing.Size(125, 200);
            this.dataTemplates.TabIndex = 0;
            this.dataTemplates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTemplates_CellDoubleClick);
            // 
            // colTemplateName
            // 
            this.colTemplateName.DataPropertyName = "Name";
            this.colTemplateName.FillWeight = 200F;
            this.colTemplateName.HeaderText = "Название шаблона";
            this.colTemplateName.MinimumWidth = 6;
            this.colTemplateName.Name = "colTemplateName";
            this.colTemplateName.ReadOnly = true;
            // 
            // colTemplateType
            // 
            this.colTemplateType.DataPropertyName = "Type";
            this.colTemplateType.FillWeight = 120F;
            this.colTemplateType.HeaderText = "Тип";
            this.colTemplateType.MinimumWidth = 6;
            this.colTemplateType.Name = "colTemplateType";
            this.colTemplateType.ReadOnly = true;
            // 
            // colTemplateModified
            // 
            this.colTemplateModified.DataPropertyName = "Modified";
            this.colTemplateModified.FillWeight = 120F;
            this.colTemplateModified.HeaderText = "Изменен";
            this.colTemplateModified.MinimumWidth = 6;
            this.colTemplateModified.Name = "colTemplateModified";
            this.colTemplateModified.ReadOnly = true;
            // 
            // colTemplateStatus
            // 
            this.colTemplateStatus.DataPropertyName = "Status";
            this.colTemplateStatus.FillWeight = 80F;
            this.colTemplateStatus.HeaderText = "Статус";
            this.colTemplateStatus.MinimumWidth = 6;
            this.colTemplateStatus.Name = "colTemplateStatus";
            this.colTemplateStatus.ReadOnly = true;
            // 
            // panelTemplatesHeader
            // 
            this.panelTemplatesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelTemplatesHeader.Controls.Add(this.btnCancelTemplate);
            this.panelTemplatesHeader.Controls.Add(this.btnSaveTemplate);
            this.panelTemplatesHeader.Controls.Add(this.btnDeleteTemplate);
            this.panelTemplatesHeader.Controls.Add(this.btnEditTemplate);
            this.panelTemplatesHeader.Controls.Add(this.btnAddTemplate);
            this.panelTemplatesHeader.Controls.Add(this.lblTemplateFormTitle);
            this.panelTemplatesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTemplatesHeader.Location = new System.Drawing.Point(3, 3);
            this.panelTemplatesHeader.Name = "panelTemplatesHeader";
            this.panelTemplatesHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelTemplatesHeader.Size = new System.Drawing.Size(186, 50);
            this.panelTemplatesHeader.TabIndex = 0;
            // 
            // btnCancelTemplate
            // 
            this.btnCancelTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelTemplate.FlatAppearance.BorderSize = 0;
            this.btnCancelTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelTemplate.ForeColor = System.Drawing.Color.White;
            this.btnCancelTemplate.Location = new System.Drawing.Point(66, 10);
            this.btnCancelTemplate.Name = "btnCancelTemplate";
            this.btnCancelTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnCancelTemplate.TabIndex = 5;
            this.btnCancelTemplate.Text = "Отмена";
            this.btnCancelTemplate.UseVisualStyleBackColor = false;
            this.btnCancelTemplate.Click += new System.EventHandler(this.btnCancelTemplate_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnSaveTemplate.FlatAppearance.BorderSize = 0;
            this.btnSaveTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTemplate.ForeColor = System.Drawing.Color.White;
            this.btnSaveTemplate.Location = new System.Drawing.Point(-40, 10);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnSaveTemplate.TabIndex = 4;
            this.btnSaveTemplate.Text = "Сохранить";
            this.btnSaveTemplate.UseVisualStyleBackColor = false;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnDeleteTemplate.FlatAppearance.BorderSize = 0;
            this.btnDeleteTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTemplate.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(220, 10);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteTemplate.TabIndex = 3;
            this.btnDeleteTemplate.Text = "Удалить";
            this.btnDeleteTemplate.UseVisualStyleBackColor = false;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditTemplate.FlatAppearance.BorderSize = 0;
            this.btnEditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTemplate.ForeColor = System.Drawing.Color.White;
            this.btnEditTemplate.Location = new System.Drawing.Point(120, 10);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnEditTemplate.TabIndex = 2;
            this.btnEditTemplate.Text = "Изменить";
            this.btnEditTemplate.UseVisualStyleBackColor = false;
            this.btnEditTemplate.Click += new System.EventHandler(this.btnEditTemplate_Click);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAddTemplate.FlatAppearance.BorderSize = 0;
            this.btnAddTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTemplate.ForeColor = System.Drawing.Color.White;
            this.btnAddTemplate.Location = new System.Drawing.Point(20, 10);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnAddTemplate.TabIndex = 1;
            this.btnAddTemplate.Text = "Добавить";
            this.btnAddTemplate.UseVisualStyleBackColor = false;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // lblTemplateFormTitle
            // 
            this.lblTemplateFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemplateFormTitle.AutoSize = true;
            this.lblTemplateFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemplateFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTemplateFormTitle.Location = new System.Drawing.Point(-180, 15);
            this.lblTemplateFormTitle.Name = "lblTemplateFormTitle";
            this.lblTemplateFormTitle.Size = new System.Drawing.Size(251, 28);
            this.lblTemplateFormTitle.TabIndex = 0;
            this.lblTemplateFormTitle.Text = "Управление шаблонами";
            // 
            // NotificationsForm
            // 
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "NotificationsForm";
            this.Text = "Уведомления";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.panelListFooter.ResumeLayout(false);
            this.panelListHeader.ResumeLayout(false);
            this.panelListHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifications)).EndInit();
            this.tabPageCreate.ResumeLayout(false);
            this.panelCreateFooter.ResumeLayout(false);
            this.panelCreateBody.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.panelCreateHeader.ResumeLayout(false);
            this.panelCreateHeader.PerformLayout();
            this.tabPageTemplates.ResumeLayout(false);
            this.panelTemplatesBody.ResumeLayout(false);
            this.groupBoxTemplateEdit.ResumeLayout(false);
            this.groupBoxTemplateEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTemplates)).EndInit();
            this.panelTemplatesHeader.ResumeLayout(false);
            this.panelTemplatesHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}