namespace VeterinaryNotificationSystem
{
    partial class NotificationDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotificationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMessageContent;
        private System.Windows.Forms.GroupBox groupBoxRecipient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRecipientPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRecipientEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAnimalInfo;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblScheduledTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblSentTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblDeliveryStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblErrorInfo;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.Button btnCancelNotification;
        private System.Windows.Forms.Button btnMarkAsRead;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.lblErrorInfo = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblDeliveryStatus = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblSentTime = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblScheduledTime = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxRecipient = new System.Windows.Forms.GroupBox();
            this.lblAnimalInfo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblRecipientEmail = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRecipientPhone = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.txtMessageContent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotificationId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnMarkAsRead = new System.Windows.Forms.Button();
            this.btnCancelNotification = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxRecipient.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Детали уведомления";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.groupBoxDelivery);
            this.panelBody.Controls.Add(this.groupBoxRecipient);
            this.panelBody.Controls.Add(this.groupBoxMessage);
            this.panelBody.Controls.Add(this.groupBoxGeneral);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(800, 530);
            this.panelBody.TabIndex = 1;
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDelivery.Controls.Add(this.lblErrorInfo);
            this.groupBoxDelivery.Controls.Add(this.label27);
            this.groupBoxDelivery.Controls.Add(this.lblDeliveryStatus);
            this.groupBoxDelivery.Controls.Add(this.label25);
            this.groupBoxDelivery.Controls.Add(this.lblSentTime);
            this.groupBoxDelivery.Controls.Add(this.label23);
            this.groupBoxDelivery.Controls.Add(this.lblScheduledTime);
            this.groupBoxDelivery.Controls.Add(this.label21);
            this.groupBoxDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxDelivery.Location = new System.Drawing.Point(20, 680);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(760, 160);
            this.groupBoxDelivery.TabIndex = 3;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Доставка";
            // 
            // lblErrorInfo
            // 
            this.lblErrorInfo.AutoSize = true;
            this.lblErrorInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblErrorInfo.Location = new System.Drawing.Point(180, 115);
            this.lblErrorInfo.Name = "lblErrorInfo";
            this.lblErrorInfo.Size = new System.Drawing.Size(15, 19);
            this.lblErrorInfo.TabIndex = 7;
            this.lblErrorInfo.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label27.Location = new System.Drawing.Point(30, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 19);
            this.label27.TabIndex = 6;
            this.label27.Text = "Информация об ошибке:";
            // 
            // lblDeliveryStatus
            // 
            this.lblDeliveryStatus.AutoSize = true;
            this.lblDeliveryStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeliveryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblDeliveryStatus.Location = new System.Drawing.Point(180, 85);
            this.lblDeliveryStatus.Name = "lblDeliveryStatus";
            this.lblDeliveryStatus.Size = new System.Drawing.Size(15, 19);
            this.lblDeliveryStatus.TabIndex = 5;
            this.lblDeliveryStatus.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label25.Location = new System.Drawing.Point(30, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 19);
            this.label25.TabIndex = 4;
            this.label25.Text = "Статус доставки:";
            // 
            // lblSentTime
            // 
            this.lblSentTime.AutoSize = true;
            this.lblSentTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSentTime.Location = new System.Drawing.Point(180, 55);
            this.lblSentTime.Name = "lblSentTime";
            this.lblSentTime.Size = new System.Drawing.Size(15, 19);
            this.lblSentTime.TabIndex = 3;
            this.lblSentTime.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label23.Location = new System.Drawing.Point(30, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 19);
            this.label23.TabIndex = 2;
            this.label23.Text = "Фактическое время:";
            // 
            // lblScheduledTime
            // 
            this.lblScheduledTime.AutoSize = true;
            this.lblScheduledTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScheduledTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblScheduledTime.Location = new System.Drawing.Point(180, 25);
            this.lblScheduledTime.Name = "lblScheduledTime";
            this.lblScheduledTime.Size = new System.Drawing.Size(15, 19);
            this.lblScheduledTime.TabIndex = 1;
            this.lblScheduledTime.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label21.Location = new System.Drawing.Point(30, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Запланированное время:";
            // 
            // groupBoxRecipient
            // 
            this.groupBoxRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecipient.Controls.Add(this.lblAnimalInfo);
            this.groupBoxRecipient.Controls.Add(this.label19);
            this.groupBoxRecipient.Controls.Add(this.lblRecipientEmail);
            this.groupBoxRecipient.Controls.Add(this.label17);
            this.groupBoxRecipient.Controls.Add(this.lblRecipientPhone);
            this.groupBoxRecipient.Controls.Add(this.label15);
            this.groupBoxRecipient.Controls.Add(this.lblRecipientName);
            this.groupBoxRecipient.Controls.Add(this.label13);
            this.groupBoxRecipient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRecipient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxRecipient.Location = new System.Drawing.Point(20, 510);
            this.groupBoxRecipient.Name = "groupBoxRecipient";
            this.groupBoxRecipient.Size = new System.Drawing.Size(760, 160);
            this.groupBoxRecipient.TabIndex = 2;
            this.groupBoxRecipient.TabStop = false;
            this.groupBoxRecipient.Text = "Получатель";
            // 
            // lblAnimalInfo
            // 
            this.lblAnimalInfo.AutoSize = true;
            this.lblAnimalInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnimalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblAnimalInfo.Location = new System.Drawing.Point(180, 115);
            this.lblAnimalInfo.Name = "lblAnimalInfo";
            this.lblAnimalInfo.Size = new System.Drawing.Size(15, 19);
            this.lblAnimalInfo.TabIndex = 7;
            this.lblAnimalInfo.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label19.Location = new System.Drawing.Point(30, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 19);
            this.label19.TabIndex = 6;
            this.label19.Text = "Информация о животных:";
            // 
            // lblRecipientEmail
            // 
            this.lblRecipientEmail.AutoSize = true;
            this.lblRecipientEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecipientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRecipientEmail.Location = new System.Drawing.Point(180, 85);
            this.lblRecipientEmail.Name = "lblRecipientEmail";
            this.lblRecipientEmail.Size = new System.Drawing.Size(15, 19);
            this.lblRecipientEmail.TabIndex = 5;
            this.lblRecipientEmail.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label17.Location = new System.Drawing.Point(30, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 19);
            this.label17.TabIndex = 4;
            this.label17.Text = "Email:";
            // 
            // lblRecipientPhone
            // 
            this.lblRecipientPhone.AutoSize = true;
            this.lblRecipientPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecipientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRecipientPhone.Location = new System.Drawing.Point(180, 55);
            this.lblRecipientPhone.Name = "lblRecipientPhone";
            this.lblRecipientPhone.Size = new System.Drawing.Size(15, 19);
            this.lblRecipientPhone.TabIndex = 3;
            this.lblRecipientPhone.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label15.Location = new System.Drawing.Point(30, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Телефон:";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.AutoSize = true;
            this.lblRecipientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecipientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRecipientName.Location = new System.Drawing.Point(180, 25);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(15, 19);
            this.lblRecipientName.TabIndex = 1;
            this.lblRecipientName.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label13.Location = new System.Drawing.Point(30, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "ФИО:";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMessage.Controls.Add(this.txtMessageContent);
            this.groupBoxMessage.Controls.Add(this.label11);
            this.groupBoxMessage.Controls.Add(this.lblMessageTitle);
            this.groupBoxMessage.Controls.Add(this.label9);
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxMessage.Location = new System.Drawing.Point(20, 170);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(760, 330);
            this.groupBoxMessage.TabIndex = 1;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Сообщение";
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.BackColor = System.Drawing.Color.White;
            this.txtMessageContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessageContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessageContent.Location = new System.Drawing.Point(30, 115);
            this.txtMessageContent.Multiline = true;
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.ReadOnly = true;
            this.txtMessageContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageContent.Size = new System.Drawing.Size(700, 200);
            this.txtMessageContent.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label11.Location = new System.Drawing.Point(30, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Сообщение:";
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblMessageTitle.Location = new System.Drawing.Point(180, 55);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(15, 19);
            this.lblMessageTitle.TabIndex = 1;
            this.lblMessageTitle.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label9.Location = new System.Drawing.Point(30, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Заголовок:";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.lblChannel);
            this.groupBoxGeneral.Controls.Add(this.label7);
            this.groupBoxGeneral.Controls.Add(this.lblCreationDate);
            this.groupBoxGeneral.Controls.Add(this.label5);
            this.groupBoxGeneral.Controls.Add(this.lblStatus);
            this.groupBoxGeneral.Controls.Add(this.label3);
            this.groupBoxGeneral.Controls.Add(this.lblNotificationId);
            this.groupBoxGeneral.Controls.Add(this.label1);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBoxGeneral.Location = new System.Drawing.Point(20, 20);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(760, 140);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Общая информация";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblChannel.Location = new System.Drawing.Point(180, 115);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(15, 19);
            this.lblChannel.TabIndex = 7;
            this.lblChannel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(30, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Канал:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCreationDate.Location = new System.Drawing.Point(180, 85);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(15, 19);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(30, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата создания:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblStatus.Location = new System.Drawing.Point(180, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус:";
            // 
            // lblNotificationId
            // 
            this.lblNotificationId.AutoSize = true;
            this.lblNotificationId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotificationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblNotificationId.Location = new System.Drawing.Point(180, 25);
            this.lblNotificationId.Name = "lblNotificationId";
            this.lblNotificationId.Size = new System.Drawing.Size(15, 19);
            this.lblNotificationId.TabIndex = 1;
            this.lblNotificationId.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID уведомления:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.btnMarkAsRead);
            this.panelFooter.Controls.Add(this.btnCancelNotification);
            this.panelFooter.Controls.Add(this.btnResend);
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 600);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFooter.Size = new System.Drawing.Size(800, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAsRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMarkAsRead.FlatAppearance.BorderSize = 0;
            this.btnMarkAsRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarkAsRead.ForeColor = System.Drawing.Color.White;
            this.btnMarkAsRead.Location = new System.Drawing.Point(260, 20);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(140, 40);
            this.btnMarkAsRead.TabIndex = 3;
            this.btnMarkAsRead.Text = "ПРОЧИТАНО";
            this.btnMarkAsRead.UseVisualStyleBackColor = false;
            // 
            // btnCancelNotification
            // 
            this.btnCancelNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnCancelNotification.FlatAppearance.BorderSize = 0;
            this.btnCancelNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelNotification.ForeColor = System.Drawing.Color.White;
            this.btnCancelNotification.Location = new System.Drawing.Point(410, 20);
            this.btnCancelNotification.Name = "btnCancelNotification";
            this.btnCancelNotification.Size = new System.Drawing.Size(140, 40);
            this.btnCancelNotification.TabIndex = 2;
            this.btnCancelNotification.Text = "ОТМЕНИТЬ";
            this.btnCancelNotification.UseVisualStyleBackColor = false;
            // 
            // btnResend
            // 
            this.btnResend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnResend.FlatAppearance.BorderSize = 0;
            this.btnResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResend.ForeColor = System.Drawing.Color.White;
            this.btnResend.Location = new System.Drawing.Point(560, 20);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(140, 40);
            this.btnResend.TabIndex = 1;
            this.btnResend.Text = "ПОВТОРИТЬ";
            this.btnResend.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(710, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ЗАКРЫТЬ";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // NotificationDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детали уведомления";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxRecipient.ResumeLayout(false);
            this.groupBoxRecipient.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}