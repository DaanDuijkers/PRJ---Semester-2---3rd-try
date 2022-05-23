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
	public partial class EmployeeForm : Form
	{
		private frmMain frmMain;
		private EmployeeManager employeeManager;
		private Employee employee;
		private Encrypt encrypt;

		public EmployeeForm(frmMain frmMain, EmployeeManager personManager, PositionManager positionsManager)
		{
			InitializeComponent();

			this.frmMain = frmMain;
			this.employeeManager = personManager;
			this.employee = null;
			this.encrypt = new Encrypt();

			cmbGender.DataSource = Enum.GetValues(typeof(Gender));

			if (positionsManager.GetAll().Count > 0)
			{
				cmbPosition.DataSource = positionsManager.GetAll();
				cmbPosition.DisplayMember = "Name";
				cmbPosition.ValueMember = "ID";
			}

			this.txbPassword.Enabled = false;
			this.txbConfirmPassword.Enabled = false;
		}

		public EmployeeForm(frmMain frmMain, EmployeeManager personManager, PositionManager positionsManager, Employee employee)
		{
			InitializeComponent();

			this.frmMain = frmMain;
			this.employeeManager = personManager;
			this.employee = employee;
			this.encrypt = new Encrypt();

			cmbGender.DataSource = Enum.GetValues(typeof(Gender));
			if (positionsManager.GetAll().Count != 0)
			{
				cmbPosition.DataSource = positionsManager.GetAll();
				cmbPosition.DisplayMember = "Name";
			}

			txbFirstName.Text = this.employee.FirstName;
			txbLastName.Text = this.employee.LastName;
			dtpBirthdate.Value = this.employee.BirthDate;
			txbEmail.Text = this.employee.Email;
			txbPostal.Text = this.employee.Postal;
			cmbGender.Text = this.employee.Gender.ToString();
			txbBSN.Text = this.employee.BSN.ToString();
			dtpHireDate.Value = this.employee.HireDate;
			lblUsername.Text = this.employee.Username;
			txbPassword.Text = this.encrypt.DecryptPassword(this.employee.Password);
			txbContactName.Text = this.employee.ContactName;
			txbContactPhone.Text = this.employee.ContactPhone;
			txbPhone.Text = this.employee.Phone;
			txbPay.Text = this.employee.Salary.ToString();
			cmbPosition.SelectedItem = this.employee.Position;

			if (this.employee.WorkingHours == 20)
            {
				cbParttimer.Checked = true;
            }

			btnConfirm.Text = "Edit";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				int workingHours = 40;
				if (cbParttimer.Checked == true)
				{
					workingHours = 20;
				}
				Position selectedPosition = cmbPosition.SelectedItem as Position;

				if (employee == null)
				{
					if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && txbEmail.Text != string.Empty && txbPostal.Text != string.Empty && txbBSN.Text != string.Empty)
					{
						char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
						string password = "";
						Random random = new Random();
						for (int i = 0; i < 10; i++)
						{
							password += characters[random.Next(0, characters.Length)].ToString();
						}

						if (this.employeeManager.Add(new EmployeeGetAdd(new Employee(Convert.ToInt32(txbBSN.Text),
							workingHours,
							selectedPosition,
							Convert.ToDouble(txbPay.Text),
							true,
							dtpBirthdate.Value,
							dtpHireDate.Value,
							(Gender)cmbGender.SelectedItem,
							txbFirstName.Text,
							txbLastName.Text,
							txbPhone.Text,
							txbEmail.Text,
							txbPostal.Text,
							txbContactName.Text,
							txbContactPhone.Text
							))) == true)
						{
							MessageBox.Show("Employee was added!");
							frmMain.GetAllEmployees();
							this.Close();
						}
						else
						{
							MessageBox.Show("Employee already exists");
						}
					}
					else
					{
						MessageBox.Show("Please fill in all required data");
					}
				}
				else
				{
					if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && txbEmail.Text != string.Empty && txbPostal.Text != string.Empty && txbBSN.Text != string.Empty && txbPassword.Text != string.Empty && txbConfirmPassword.Text == txbPassword.Text)
					{
						if (this.employeeManager.Update(new EmployeeGetEdit(this.employee, new Employee(this.employee.ID,
							Convert.ToInt32(txbBSN.Text),
							workingHours,
							selectedPosition,
							Convert.ToDouble(txbPay.Text),
							true,
							dtpBirthdate.Value,
							dtpHireDate.Value,
							(Gender)cmbGender.SelectedItem,
							txbFirstName.Text,
							txbLastName.Text,
							txbPassword.Text,
							txbPhone.Text,
							txbEmail.Text,
							txbPostal.Text,
							txbContactName.Text,
							txbContactPhone.Text
							))) == true)
						{
							MessageBox.Show("Employee was updated!");
							frmMain.GetAllEmployees();
							this.Close();
						}
						else
						{
							MessageBox.Show("Employee already exists");
						}
					}
					else
                    {
						MessageBox.Show("Please fill in all required data");
                    }
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
    }
}