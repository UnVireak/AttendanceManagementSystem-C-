using AttendanceManagementSystem.Feature;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Entities;
namespace AttendanceManagementSystem
{
    public partial class ClockManagement : Form
    {
        TimeSheet timeSheet;
        public ClockManagement(TimeSheet timeSheet)
        {
            this.timeSheet = timeSheet;
            InitializeComponent();
        }
        private void currentTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClockManagement_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }
        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 0));
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
                ShowMessage("Time-out Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void ShowMessage(string message, bool Issucceed)
        {
            //Implement DRY Principle
            if (Issucceed)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Display Warning Icon
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();

        }
    }
}
