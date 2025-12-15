namespace VeterinaryNotificationSystem
{
    partial class SelectAnimalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView dataAnimals;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectAnimalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectAnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectAnimalSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectAnimalBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectAnimalOwner;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAnimalForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.dataAnimals = new System.Windows.Forms.DataGridView();
            this.colSelectAnimalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectAnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectAnimalSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectAnimalBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectAnimalOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimals)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(700, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор животного";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.dataAnimals);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(700, 430);
            this.panelBody.TabIndex = 1;
            // 
            // dataAnimals
            // 
            this.dataAnimals.AllowUserToAddRows = false;
            this.dataAnimals.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataAnimals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAnimals.BackgroundColor = System.Drawing.Color.White;
            this.dataAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAnimals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataAnimals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAnimals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataAnimals.ColumnHeadersHeight = 40;
            this.dataAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectAnimalId,
            this.colSelectAnimalName,
            this.colSelectAnimalSpecies,
            this.colSelectAnimalBreed,
            this.colSelectAnimalOwner});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAnimals.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAnimals.EnableHeadersVisualStyles = false;
            this.dataAnimals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataAnimals.Location = new System.Drawing.Point(20, 20);
            this.dataAnimals.Name = "dataAnimals";
            this.dataAnimals.ReadOnly = true;
            this.dataAnimals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataAnimals.RowHeadersVisible = false;
            this.dataAnimals.RowHeadersWidth = 50;
            this.dataAnimals.RowTemplate.Height = 35;
            this.dataAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAnimals.Size = new System.Drawing.Size(660, 390);
            this.dataAnimals.TabIndex = 0;
            // 
            // colSelectAnimalId
            // 
            this.colSelectAnimalId.DataPropertyName = "Id";
            this.colSelectAnimalId.FillWeight = 40F;
            this.colSelectAnimalId.HeaderText = "ID";
            this.colSelectAnimalId.Name = "colSelectAnimalId";
            this.colSelectAnimalId.ReadOnly = true;
            // 
            // colSelectAnimalName
            // 
            this.colSelectAnimalName.DataPropertyName = "Name";
            this.colSelectAnimalName.FillWeight = 120F;
            this.colSelectAnimalName.HeaderText = "Кличка";
            this.colSelectAnimalName.Name = "colSelectAnimalName";
            this.colSelectAnimalName.ReadOnly = true;
            // 
            // colSelectAnimalSpecies
            // 
            this.colSelectAnimalSpecies.DataPropertyName = "Species";
            this.colSelectAnimalSpecies.FillWeight = 120F;
            this.colSelectAnimalSpecies.HeaderText = "Вид";
            this.colSelectAnimalSpecies.Name = "colSelectAnimalSpecies";
            this.colSelectAnimalSpecies.ReadOnly = true;
            // 
            // colSelectAnimalBreed
            // 
            this.colSelectAnimalBreed.DataPropertyName = "Breed";
            this.colSelectAnimalBreed.FillWeight = 120F;
            this.colSelectAnimalBreed.HeaderText = "Порода";
            this.colSelectAnimalBreed.Name = "colSelectAnimalBreed";
            this.colSelectAnimalBreed.ReadOnly = true;
            // 
            // colSelectAnimalOwner
            // 
            this.colSelectAnimalOwner.DataPropertyName = "Owner";
            this.colSelectAnimalOwner.FillWeight = 150F;
            this.colSelectAnimalOwner.HeaderText = "Владелец";
            this.colSelectAnimalOwner.Name = "colSelectAnimalOwner";
            this.colSelectAnimalOwner.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSelect);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 500);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelFooter.Size = new System.Drawing.Size(700, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(370, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(530, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 40);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectAnimalForm
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(700, 580);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор животного";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimals)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }


    }
}