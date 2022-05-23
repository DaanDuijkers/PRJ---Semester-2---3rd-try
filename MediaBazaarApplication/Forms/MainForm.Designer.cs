
namespace MediaBazaarApplication
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabShifts = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnViewShift = new System.Windows.Forms.Button();
            this.btnRemoveShift = new System.Windows.Forms.Button();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.shiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPositions = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnViewPosition = new System.Windows.Forms.Button();
            this.btnRemovePosition = new System.Windows.Forms.Button();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.positionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabShifts.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.tabEmployees.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabPositions.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabShifts);
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Controls.Add(this.tabPositions);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1171, 519);
            this.tabControl.TabIndex = 0;
            // 
            // tabShifts
            // 
            this.tabShifts.BackColor = System.Drawing.SystemColors.Control;
            this.tabShifts.Controls.Add(this.flowLayoutPanel3);
            this.tabShifts.Controls.Add(this.dgvShifts);
            this.tabShifts.Location = new System.Drawing.Point(4, 29);
            this.tabShifts.Name = "tabShifts";
            this.tabShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabShifts.Size = new System.Drawing.Size(1163, 486);
            this.tabShifts.TabIndex = 0;
            this.tabShifts.Text = "Shifts";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.btnAddShift);
            this.flowLayoutPanel3.Controls.Add(this.btnViewShift);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveShift);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(852, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(305, 125);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(3, 3);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(94, 46);
            this.btnAddShift.TabIndex = 0;
            this.btnAddShift.Text = "Add";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnViewShift
            // 
            this.btnViewShift.Location = new System.Drawing.Point(103, 3);
            this.btnViewShift.Name = "btnViewShift";
            this.btnViewShift.Size = new System.Drawing.Size(94, 46);
            this.btnViewShift.TabIndex = 1;
            this.btnViewShift.Text = "View";
            this.btnViewShift.UseVisualStyleBackColor = true;
            this.btnViewShift.Click += new System.EventHandler(this.btnViewShift_Click);
            // 
            // btnRemoveShift
            // 
            this.btnRemoveShift.Location = new System.Drawing.Point(203, 3);
            this.btnRemoveShift.Name = "btnRemoveShift";
            this.btnRemoveShift.Size = new System.Drawing.Size(94, 46);
            this.btnRemoveShift.TabIndex = 2;
            this.btnRemoveShift.Text = "Remove";
            this.btnRemoveShift.UseVisualStyleBackColor = true;
            this.btnRemoveShift.Click += new System.EventHandler(this.btnRemoveShift_Click);
            // 
            // dgvShifts
            // 
            this.dgvShifts.AllowUserToAddRows = false;
            this.dgvShifts.AllowUserToDeleteRows = false;
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftID,
            this.date,
            this.time,
            this.shiftPosition,
            this.shiftEmployees});
            this.dgvShifts.Location = new System.Drawing.Point(6, 3);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.ReadOnly = true;
            this.dgvShifts.RowHeadersWidth = 51;
            this.dgvShifts.RowTemplate.Height = 29;
            this.dgvShifts.Size = new System.Drawing.Size(840, 477);
            this.dgvShifts.TabIndex = 0;
            // 
            // shiftID
            // 
            this.shiftID.HeaderText = "shiftID";
            this.shiftID.MinimumWidth = 6;
            this.shiftID.Name = "shiftID";
            this.shiftID.ReadOnly = true;
            this.shiftID.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // shiftPosition
            // 
            this.shiftPosition.HeaderText = "shiftPosition";
            this.shiftPosition.MinimumWidth = 6;
            this.shiftPosition.Name = "shiftPosition";
            this.shiftPosition.ReadOnly = true;
            this.shiftPosition.Width = 125;
            // 
            // shiftEmployees
            // 
            this.shiftEmployees.HeaderText = "shiftEmployees";
            this.shiftEmployees.MinimumWidth = 6;
            this.shiftEmployees.Name = "shiftEmployees";
            this.shiftEmployees.ReadOnly = true;
            this.shiftEmployees.Width = 125;
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.tabEmployees.Controls.Add(this.flowLayoutPanel1);
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 29);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(1163, 486);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Employees";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnAddEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnViewEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveEmployee);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(851, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 125);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(94, 46);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.Location = new System.Drawing.Point(103, 3);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(94, 46);
            this.btnViewEmployee.TabIndex = 1;
            this.btnViewEmployee.Text = "View";
            this.btnViewEmployee.UseVisualStyleBackColor = true;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(203, 3);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(94, 46);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.bsn,
            this.username,
            this.firstName,
            this.lastName});
            this.dgvEmployees.Location = new System.Drawing.Point(6, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 29;
            this.dgvEmployees.Size = new System.Drawing.Size(839, 477);
            this.dgvEmployees.TabIndex = 1;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "employeeID";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Width = 125;
            // 
            // bsn
            // 
            this.bsn.HeaderText = "bsn";
            this.bsn.MinimumWidth = 6;
            this.bsn.Name = "bsn";
            this.bsn.ReadOnly = true;
            this.bsn.Width = 125;
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
            // tabPositions
            // 
            this.tabPositions.BackColor = System.Drawing.SystemColors.Control;
            this.tabPositions.Controls.Add(this.flowLayoutPanel2);
            this.tabPositions.Controls.Add(this.dgvPositions);
            this.tabPositions.Location = new System.Drawing.Point(4, 29);
            this.tabPositions.Name = "tabPositions";
            this.tabPositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPositions.Size = new System.Drawing.Size(1163, 486);
            this.tabPositions.TabIndex = 2;
            this.tabPositions.Text = "Positions";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.btnAddPosition);
            this.flowLayoutPanel2.Controls.Add(this.btnViewPosition);
            this.flowLayoutPanel2.Controls.Add(this.btnRemovePosition);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(851, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(306, 125);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(3, 3);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(94, 46);
            this.btnAddPosition.TabIndex = 0;
            this.btnAddPosition.Text = "Add";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // btnViewPosition
            // 
            this.btnViewPosition.Location = new System.Drawing.Point(103, 3);
            this.btnViewPosition.Name = "btnViewPosition";
            this.btnViewPosition.Size = new System.Drawing.Size(94, 46);
            this.btnViewPosition.TabIndex = 1;
            this.btnViewPosition.Text = "View";
            this.btnViewPosition.UseVisualStyleBackColor = true;
            this.btnViewPosition.Click += new System.EventHandler(this.btnViewPosition_Click);
            // 
            // btnRemovePosition
            // 
            this.btnRemovePosition.Location = new System.Drawing.Point(203, 3);
            this.btnRemovePosition.Name = "btnRemovePosition";
            this.btnRemovePosition.Size = new System.Drawing.Size(94, 46);
            this.btnRemovePosition.TabIndex = 2;
            this.btnRemovePosition.Text = "Remove";
            this.btnRemovePosition.UseVisualStyleBackColor = true;
            this.btnRemovePosition.Click += new System.EventHandler(this.btnRemovePosition_Click);
            // 
            // dgvPositions
            // 
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.AllowUserToDeleteRows = false;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionID,
            this.positionName});
            this.dgvPositions.Location = new System.Drawing.Point(6, 6);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.RowHeadersWidth = 51;
            this.dgvPositions.RowTemplate.Height = 29;
            this.dgvPositions.Size = new System.Drawing.Size(839, 474);
            this.dgvPositions.TabIndex = 1;
            // 
            // positionID
            // 
            this.positionID.HeaderText = "positionID";
            this.positionID.MinimumWidth = 6;
            this.positionID.Name = "positionID";
            this.positionID.ReadOnly = true;
            this.positionID.Width = 125;
            // 
            // positionName
            // 
            this.positionName.HeaderText = "positionName";
            this.positionName.MinimumWidth = 6;
            this.positionName.Name = "positionName";
            this.positionName.ReadOnly = true;
            this.positionName.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 543);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "MediaBazaar";
            this.tabControl.ResumeLayout(false);
            this.tabShifts.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabPositions.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabShifts;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TabPage tabPositions;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnViewEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnViewPosition;
        private System.Windows.Forms.Button btnRemovePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnViewShift;
        private System.Windows.Forms.Button btnRemoveShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftEmployees;
    }
}

