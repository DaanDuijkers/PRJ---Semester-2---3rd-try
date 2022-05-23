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
    public partial class PositionForm : Form
    {
        private frmMain mainForm;
        private PositionManager positionManager;
        private Position position;

        public PositionForm(frmMain mainForm, PositionManager positionManager)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.positionManager = positionManager;
            this.position = null;
        }

        public PositionForm(frmMain mainForm, PositionManager positionManager, Position position)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.positionManager = positionManager;
            this.position = position;

            txbName.Text = position.Name;

            btnConfirm.Text = "Edit";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbName.Text != string.Empty)
            {
                if (this.position == null)
                {
                    if (this.positionManager.Add(new Position(txbName.Text)) == true)
                    {
                        MessageBox.Show("Position was added");
                        this.mainForm.GetAllPositions();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Position already exists");
                    }
                }
                else
                {
                    if (this.positionManager.Update(new Position(this.position.ID, txbName.Text, this.position.IsActive)) == true)
                    {
                        MessageBox.Show("Person was updated!");
                        this.mainForm.GetAllPositions();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Position already exists");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required data");
            }
        }
    }
}