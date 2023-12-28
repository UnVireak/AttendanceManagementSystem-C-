using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Feature;
namespace AttendanceManagementSystem
{
    public partial class MainForm : Form
    {
        public TimeSheet AppTimeSheet = new TimeSheet();
        public MainForm()
        {
            InitializeComponent();

            //Load the data from timmesheet.json
            AppTimeSheet = TimeSheetDataStorage.LoadTimeSheetFromStorage();

        }

        private void timeRecordButton_Click(object sender, EventArgs e)
        {
            ClockManagement cfrm = new ClockManagement(AppTimeSheet);
            cfrm.ShowDialog();
        }

        private void mangeEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(AppTimeSheet);
            form.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToStorage(AppTimeSheet);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }
    }
}
