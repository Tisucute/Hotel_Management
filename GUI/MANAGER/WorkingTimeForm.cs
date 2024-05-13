using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class WorkingTimeForm : Form
    {
        public WorkingTimeForm()
        {
            InitializeComponent();
        }
        
        EmployeeBLL employeeBLL = new EmployeeBLL();
        private void WorkingTimeAndSalaryForm_Load(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Now;
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillGrid()
        {
            dgvListEmployeeAssign.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvListEmployeeAssign.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)dgvListEmployeeAssign.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvListEmployeeAssign.AllowUserToAddRows = false;
            labelTotal.Text = ("Total: " + dgvListEmployeeAssign.Rows.Count);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox.SelectedIndex == 0)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 7, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();

                }
                else if (comboBox.SelectedIndex == 1)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 11, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();
                }

                else if (comboBox.SelectedIndex == 2)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 15, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();
                }
                else if (comboBox.SelectedIndex == 3)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 19, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();
                }
                else if (comboBox.SelectedIndex == 4)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 23, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();
                }
                else if (comboBox.SelectedIndex == 5)
                {
                    DateTime dateTime = new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, 3, 0, 0);
                    DataTable dt = employeeBLL.getShiftByTime(dateTime);
                    dgvListEmployeeAssign.DataSource = dt;
                    fillGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
