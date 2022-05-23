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
    public partial class ShiftForm : Form
    {
        private frmMain frmMain;
        private ShiftManager shiftManager;
        private PositionManager positionManager;
        private EmployeeManager employeeManager;

        private Shift shift;
        private List<Employee> assignedEmployees;
        private List<Employee> showAssignedEmployees;
        private Position position;

        public ShiftForm(frmMain frmMain, ShiftManager shiftManager, PositionManager positionManager, EmployeeManager employeeManager)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.shiftManager = shiftManager;
            this.positionManager = positionManager;
            this.employeeManager = employeeManager;
            this.shift = null;
            this.assignedEmployees = new List<Employee>();
            this.showAssignedEmployees = this.assignedEmployees;

            cmbTime.DataSource = Enum.GetValues(typeof(Time));

            if (this.positionManager.GetAll().Count != 0)
            {
                cmbPosition.DataSource = this.positionManager.GetAll();
                cmbPosition.DisplayMember = "Name";
                cmbPosition.ValueMember = "ID";
            }

            this.position = cmbPosition.SelectedItem as Position;

            this.GetAllEmployees();
            this.GetAllAssignedEmployees();
        }

        public ShiftForm(frmMain frmMain, ShiftManager shiftManager, PositionManager positionManager, EmployeeManager employeeManager, Shift shift)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.shiftManager = shiftManager;
            this.positionManager = positionManager;
            this.employeeManager = employeeManager;
            this.shift = shift;
            this.assignedEmployees = shift.Employees;
            this.showAssignedEmployees = this.assignedEmployees;


            cmbTime.DataSource = Enum.GetValues(typeof(Time));
            cmbPosition.Enabled = false;
            btnConfirm.Text = "Edit";

            this.position = shift.Position;

            this.GetAllEmployees();
            this.GetAllAssignedEmployees();
        }

        private void GetAllEmployees()
        {
            dgvEmployees.Rows.Clear();

            foreach (Employee e in employeeManager.GetAll(new EmployeeFilterAvailability(this.position, this.assignedEmployees, dtpDate.Value, shiftManager.GetAll(new ShiftsFilterNone()))))
            {
                int rowId = dgvEmployees.Rows.Add();
                DataGridViewRow row = dgvEmployees.Rows[rowId];

                row.Cells["id"].Value = e.ID;
                row.Cells["username"].Value = e.Username;
                row.Cells["firstName"].Value = e.FirstName;
                row.Cells["lastName"].Value = e.LastName;
            }
        }

        private void GetAllAssignedEmployees()
        {
            dgvAssignedEmployees.Rows.Clear();

            foreach (Employee e in this.showAssignedEmployees)
            {
                int rowId = dgvAssignedEmployees.Rows.Add();
                DataGridViewRow row = dgvAssignedEmployees.Rows[rowId];

                row.Cells["assignedID"].Value = e.ID;
                row.Cells["assignedUsername"].Value = e.Username;
                row.Cells["assignedFirstName"].Value = e.FirstName;
                row.Cells["assignedLastName"].Value = e.LastName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.assignedEmployees.Count > 0)
                {
                    Position selectedPosition = cmbPosition.SelectedItem as Position;

                    if (shift == null)
                    {
                        if (this.shiftManager.Add(new Shift(this.position,
                            this.assignedEmployees,
                            (Time)cmbTime.SelectedItem,
                            dtpDate.Value)) ==
                            true)
                        {
                            MessageBox.Show("Shift was added");
                            this.frmMain.GetAllShifts();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Shift is invalid");
                        }
                    }
                    else
                    {
                        if (this.shiftManager.Update(new Shift(this.shift.ID,
                            this.shift.Position,
                            this.assignedEmployees,
                            (Time)cmbTime.SelectedItem,
                            dtpDate.Value))
                            == true)
                        {
                            MessageBox.Show("Shift was updated");
                            this.frmMain.GetAllShifts();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Shift is invalid");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the required data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.position = cmbPosition.SelectedItem as Position;

                this.GetAllEmployees();
                this.GetAllAssignedEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.Rows.Count > 0)
                {
                    if (dgvEmployees.CurrentRow.Index >= 0)
                    {
                        int id = Convert.ToInt32(dgvEmployees.Rows[dgvEmployees.CurrentRow.Index].Cells[0].Value);
                        this.assignedEmployees.Add(employeeManager.Get(new EmployeeGetByID(id)));

                        this.GetAllEmployees();
                        this.GetAllAssignedEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Select an unassigned employee");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnassignEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedEmployees.Rows.Count > 0)
                {
                    if (dgvAssignedEmployees.CurrentRow.Index >= 0)
                    {
                        int id = Convert.ToInt32(dgvAssignedEmployees.Rows[dgvAssignedEmployees.CurrentRow.Index].Cells[0].Value);

                        for (int i = 0; i < this.assignedEmployees.Count; i++)
                        {
                            if (this.assignedEmployees[i].ID == id)
                            {
                                this.assignedEmployees.RemoveAt(i);
                            }
                        }

                        this.GetAllEmployees();
                        this.GetAllAssignedEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Select an unassigned employee");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.GetAllEmployees();
                this.GetAllAssignedEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}