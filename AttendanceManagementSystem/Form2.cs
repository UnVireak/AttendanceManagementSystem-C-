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
using AttendanceManagementSystem.Feature;
namespace AttendanceManagementSystem
{
    public partial class EmployeeForm : Form
    {
        TimeSheet timeSheet;
        public EmployeeForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateButton.Enabled = false;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            identityTextBox.Clear();
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int foundIndex = timeSheet.GetAllEmployee().FindIndex(em => em.CardNo == cardnoTextBox.Text.Trim());
                if (foundIndex == -1)
                {
                    var emp = new Employee(
                    fullnameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(),
                    cardnoTextBox.Text.Trim()
                    );
                    timeSheet.AddEmployee(emp);
                    LoadToGrid(); // Update the gridview
                    saveButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Card ID :{cardnoTextBox.Text} is already inputed. Please input new Card ID.");
                }

            }
            catch (AbandonedMutexException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;

            }
        }
        private void LoadToGrid()
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee();
            dataGridView1.Refresh(); // show the lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee(isSimpleVersion);
            dataGridView1.Refresh(); // show the lastest data
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateEmployee(identityTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);
                LoadToGrid();
            }
            catch (AbandonedMutexException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                identityTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addnewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Guid id = new Guid(identityTextBox.Text);
            timeSheet.RemoveRow(id);
            LoadToGrid();
            addnewButton.Enabled = true;
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
        }

        
    }
}
