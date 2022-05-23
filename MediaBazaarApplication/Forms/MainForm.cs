using MediaBazaarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApplication
{
    public partial class frmMain : Form
    {
        private EmployeeManager employeeManager;
        private PositionManager positionManager;
        private ShiftManager shiftManager;

        private EmployeeForm employeeForm;
        private PositionForm positionForm;
        private ShiftForm shiftForm;

        public frmMain()
        {
            InitializeComponent();

            this.employeeManager = new EmployeeManager(new EmployeeSQL());
            this.positionManager = new PositionManager(new PositionSQL());
            this.shiftManager = new ShiftManager(new ShiftSQL());

            this.GetAllEmployees();
            this.GetAllPositions();
            this.GetAllShifts();
        }

        #region Employees
        public void GetAllEmployees ()
        {
            dgvEmployees.Rows.Clear();

            foreach (Employee e in employeeManager.GetAll(new EmployeeFilterNone()))
            {
                if (e.IsActive == true)
                {
                    int rowId = dgvEmployees.Rows.Add();
                    DataGridViewRow row = dgvEmployees.Rows[rowId];

                    row.Cells["employeeID"].Value = e.ID;
                    row.Cells["bsn"].Value = e.BSN;
                    row.Cells["username"].Value = e.Username;
                    row.Cells["firstName"].Value = e.FirstName;
                    row.Cells["lastName"].Value = e.LastName;
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.employeeForm = new EmployeeForm(this, employeeManager, positionManager);
            this.employeeForm.Show();
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvEmployees.Rows[dgvEmployees.CurrentRow.Index].Cells[0].Value);
                this.employeeForm = new EmployeeForm(this, employeeManager, positionManager, employeeManager.Get(new EmployeeGetByID(id)));
                this.employeeForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit");
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvEmployees.Rows[dgvEmployees.CurrentRow.Index].Cells[0].Value);
                this.employeeManager.Remove(id);
                MessageBox.Show("Employee was removed");
                GetAllEmployees();
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        #endregion

        #region Positions
        public void GetAllPositions()
        {
            dgvPositions.Rows.Clear();

            foreach (Position p in positionManager.GetAll())
            {
                int rowId = dgvPositions.Rows.Add();
                DataGridViewRow row = dgvPositions.Rows[rowId];

                row.Cells["positionID"].Value = p.ID;
                row.Cells["positionName"].Value = p.Name;
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            this.positionForm = new PositionForm(this, positionManager);
            this.positionForm.Show();
        }

        private void btnViewPosition_Click(object sender, EventArgs e)
        {
            if (dgvPositions.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvPositions.Rows[dgvPositions.CurrentRow.Index].Cells[0].Value);
                this.positionForm = new PositionForm(this, positionManager, positionManager.Get(id));
                this.positionForm.Show();
            }
            else
            {
                MessageBox.Show("Select a position");
            }
        }

        private void btnRemovePosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPositions.CurrentRow.Index != -1)
                {
                    int id = Convert.ToInt32(dgvPositions.Rows[dgvPositions.CurrentRow.Index].Cells[0].Value);
                    this.positionManager.Remove(id);
                    MessageBox.Show("Position was removed");
                    GetAllPositions();
                }
                else
                {
                    MessageBox.Show("Please select a position");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Shift
        public void GetAllShifts()
        {
            dgvShifts.Rows.Clear();

            foreach (Shift s in shiftManager.GetAll(new ShiftsFilterNone()))
            {
                int rowId = dgvShifts.Rows.Add();
                DataGridViewRow row = dgvShifts.Rows[rowId];

                row.Cells["shiftID"].Value = s.ID;
                row.Cells["date"].Value = s.Date;
                row.Cells["time"].Value = s.Time;
                row.Cells["shiftPosition"].Value = s.Position.Name;
                row.Cells["shiftEmployees"].Value = s.Employees.Count();
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            this.shiftForm = new ShiftForm(this, shiftManager, this.positionManager, this.employeeManager);
            this.shiftForm.Show();
        }

        private void btnViewShift_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvShifts.Rows[dgvShifts.CurrentRow.Index].Cells[0].Value);
            this.shiftForm = new ShiftForm(this, shiftManager, this.positionManager, this.employeeManager, this.shiftManager.Get(new ShiftFilterByID(id)));
            this.shiftForm.Show();
        }

        private void btnRemoveShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShifts.CurrentRow.Index != -1)
                {
                    int id = Convert.ToInt32(dgvShifts.Rows[dgvShifts.CurrentRow.Index].Cells[0].Value);
                    this.shiftManager.Remove(id);
                    MessageBox.Show("Shift was removed");
                    GetAllShifts();
                }
                else
                {
                    MessageBox.Show("Please select a shift");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}