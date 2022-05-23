
namespace MediaBazaarApplication
{
    partial class ShiftForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAssignedEmployees = new System.Windows.Forms.DataGridView();
            this.assignedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnassignEmployee = new System.Windows.Forms.Button();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.firstName,
            this.lastName});
            this.dgvEmployees.Location = new System.Drawing.Point(13, 32);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 29;
            this.dgvEmployees.Size = new System.Drawing.Size(546, 493);
            this.dgvEmployees.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 125;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "firstName";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "lastName";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Employees";
            // 
            // dgvAssignedEmployees
            // 
            this.dgvAssignedEmployees.AllowUserToAddRows = false;
            this.dgvAssignedEmployees.AllowUserToDeleteRows = false;
            this.dgvAssignedEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignedID,
            this.assignedUsername,
            this.assignedFirstName,
            this.assignedLastName});
            this.dgvAssignedEmployees.Location = new System.Drawing.Point(924, 32);
            this.dgvAssignedEmployees.Name = "dgvAssignedEmployees";
            this.dgvAssignedEmployees.ReadOnly = true;
            this.dgvAssignedEmployees.RowHeadersWidth = 51;
            this.dgvAssignedEmployees.RowTemplate.Height = 29;
            this.dgvAssignedEmployees.Size = new System.Drawing.Size(546, 493);
            this.dgvAssignedEmployees.TabIndex = 2;
            // 
            // assignedID
            // 
            this.assignedID.HeaderText = "assignedID";
            this.assignedID.MinimumWidth = 6;
            this.assignedID.Name = "assignedID";
            this.assignedID.ReadOnly = true;
            this.assignedID.Width = 125;
            // 
            // assignedUsername
            // 
            this.assignedUsername.HeaderText = "assignedUsername";
            this.assignedUsername.MinimumWidth = 6;
            this.assignedUsername.Name = "assignedUsername";
            this.assignedUsername.ReadOnly = true;
            this.assignedUsername.Width = 125;
            // 
            // assignedFirstName
            // 
            this.assignedFirstName.HeaderText = "assignedFirstName";
            this.assignedFirstName.MinimumWidth = 6;
            this.assignedFirstName.Name = "assignedFirstName";
            this.assignedFirstName.ReadOnly = true;
            this.assignedFirstName.Width = 125;
            // 
            // assignedLastName
            // 
            this.assignedLastName.HeaderText = "assignedLastName";
            this.assignedLastName.MinimumWidth = 6;
            this.assignedLastName.Name = "assignedLastName";
            this.assignedLastName.ReadOnly = true;
            this.assignedLastName.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(924, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees in shift";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnassignEmployee);
            this.groupBox1.Controls.Add(this.btnAssignEmployee);
            this.groupBox1.Controls.Add(this.cmbPosition);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(566, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(351, 203);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // btnUnassignEmployee
            // 
            this.btnUnassignEmployee.Location = new System.Drawing.Point(231, 158);
            this.btnUnassignEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnassignEmployee.Name = "btnUnassignEmployee";
            this.btnUnassignEmployee.Size = new System.Drawing.Size(112, 35);
            this.btnUnassignEmployee.TabIndex = 82;
            this.btnUnassignEmployee.Text = "Unassign";
            this.btnUnassignEmployee.UseVisualStyleBackColor = true;
            this.btnUnassignEmployee.Click += new System.EventHandler(this.btnUnassignEmployee_Click);
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Location = new System.Drawing.Point(8, 158);
            this.btnAssignEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(112, 35);
            this.btnAssignEmployee.TabIndex = 83;
            this.btnAssignEmployee.Text = "Assign";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cmbPosition.Location = new System.Drawing.Point(153, 87);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(188, 28);
            this.cmbPosition.TabIndex = 83;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(153, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 27);
            this.dtpDate.TabIndex = 67;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date";
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cmbTime.Location = new System.Drawing.Point(153, 53);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(188, 28);
            this.cmbTime.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Time";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(805, 488);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 35);
            this.btnConfirm.TabIndex = 80;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(685, 488);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 537);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAssignedEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "ShiftForm";
            this.Text = "ShiftForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAssignedEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedLastName;
        private System.Windows.Forms.Button btnUnassignEmployee;
        private System.Windows.Forms.Button btnAssignEmployee;
    }
}