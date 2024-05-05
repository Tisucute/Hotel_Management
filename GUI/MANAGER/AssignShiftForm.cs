using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class AssignShiftForm : Form
    {
        public AssignShiftForm()
        {
            InitializeComponent();
        }

        private void AssignShiftForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.qLKSDataSet.EMPLOYEES);
            dateTimePicker.Value = DateTime.Now;
            dgvListEmployee.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListEmployee.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListEmployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvListEmployee.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvListEmployee.Columns[i].Width;

                // Remove AutoSizing:
                dgvListEmployee.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvListEmployee.Columns[i].Width = colw;
            }
        }
        EmployeeBLL employeeBLL = new EmployeeBLL();
        List<SHIFTS> assignedShift = new List<SHIFTS>();
        private void ButtonAssign_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value;
            DataTable dt = employeeBLL.getEmployeesWorking();
            List<EMPLOYEE> employees = new List<EMPLOYEE>();
            foreach (DataRow x in dt.Rows)
            {
                EMPLOYEE employee = new EMPLOYEE();
                employee.id = Convert.ToInt32(x["id"].ToString());
                employee.fullname = x["fullname"].ToString();
                employee.gender = x["gender"].ToString();
                employee.birthdate = (DateTime)x["birthdate"];
                employee.CCCD = x["CCCD"].ToString();
                employee.address = x["address"].ToString();
                employee.phone = x["phone"].ToString();
                employee.role = Convert.ToInt32(x["role_id"].ToString());
                employee.status = x["status"].ToString();
                employee.pic = new MemoryStream((byte[])x["picture"]);
                employees.Add(employee);
            }
            ShiftScheduler shiftScheduler = new ShiftScheduler(employees, dateTime);
            assignedShift = shiftScheduler.AssignShift();
            comboBox.SelectedIndex = 0;
            comboBox_SelectedIndexChanged(sender, new EventArgs());
        }

        public void removeColumn()
        {
            try
            {
                dgvListEmployeeAssign.Columns.Remove("birthdate");
                dgvListEmployeeAssign.Columns.Remove("phone");
                dgvListEmployeeAssign.Columns.Remove("address");
                dgvListEmployeeAssign.Columns.Remove("pic");
            }
            catch { }
            dgvListEmployeeAssign.Columns[0].HeaderText = "ID";
            dgvListEmployeeAssign.Columns[1].HeaderText = "Full Name";
            dgvListEmployeeAssign.Columns[2].HeaderText = "Gender";
            dgvListEmployeeAssign.Columns[3].HeaderText = "CCCD";
            dgvListEmployeeAssign.Columns[4].HeaderText = "Role";
            dgvListEmployeeAssign.Columns[5].HeaderText = "Status";
            dgvListEmployeeAssign.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListEmployeeAssign.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListEmployeeAssign.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvListEmployeeAssign.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvListEmployeeAssign.Columns[i].Width;

                // Remove AutoSizing:
                dgvListEmployeeAssign.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvListEmployeeAssign.Columns[i].Width = colw;
            }
        }
        public BindingList<EMPLOYEE> list;
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox.SelectedIndex == 0)
                {
                    SHIFTS employee = assignedShift[0];
                    list = new BindingList<EMPLOYEE>();
                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();

                }
                else if (comboBox.SelectedIndex == 1)
                {
                    SHIFTS employee = assignedShift[1];
                    list = new BindingList<EMPLOYEE>();
                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();
                }

                else if (comboBox.SelectedIndex == 2)
                {
                    SHIFTS employee = assignedShift[2];
                    list = new BindingList<EMPLOYEE>();

                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();

                }
                else if (comboBox.SelectedIndex == 3)
                {
                    SHIFTS employee = assignedShift[3];
                    list = new BindingList<EMPLOYEE>();

                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();

                }
                else if (comboBox.SelectedIndex == 4)
                {
                    SHIFTS employee = assignedShift[4];
                    list = new BindingList<EMPLOYEE>();

                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();

                }
                else if (comboBox.SelectedIndex == 5)
                {
                    SHIFTS employee = assignedShift[5];
                    list = new BindingList<EMPLOYEE>();

                    foreach (var y in employee.assignEmployees)
                    {
                        list.Add(y);
                    }
                    dgvListEmployeeAssign.DataSource = list;
                    removeColumn();

                }
            }
            catch { }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                SHIFTS assgin = assignedShift[0];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (comboBox.SelectedIndex == 1)
            {
                SHIFTS assgin = assignedShift[1];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (comboBox.SelectedIndex == 2)
            {
                SHIFTS assgin = assignedShift[2];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (comboBox.SelectedIndex == 3)
            {
                SHIFTS assgin = assignedShift[3];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (comboBox.SelectedIndex == 4)
            {
                SHIFTS assgin = assignedShift[4];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if (comboBox.SelectedIndex == 5)
            {
                SHIFTS assgin = assignedShift[5];
                try
                {
                    foreach (DataGridViewRow row in dgvListEmployeeAssign.Rows)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                        employeeBLL.insertShift(employeeID, assgin.startTime);
                    }
                    MessageBox.Show("Assign Shift Successfully", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

    private void ButtonRemove_Click(object sender, EventArgs e)
    {
        if (dgvListEmployeeAssign.SelectedRows.Count > 0)
        {
            dgvListEmployeeAssign.Rows.RemoveAt(dgvListEmployeeAssign.CurrentRow.Index);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (dgvListEmployee.SelectedRows.Count > 0)
        {
            DataTable dt = employeeBLL.getEmployeeByID(Convert.ToInt32(dgvListEmployee.CurrentRow.Cells[0].Value.ToString()));
            foreach (DataRow x in dt.Rows)
            {
                EMPLOYEE employee = new EMPLOYEE();
                employee.id = Convert.ToInt32(x["id"].ToString());
                employee.fullname = x["fullname"].ToString();
                employee.gender = x["gender"].ToString();
                employee.birthdate = (DateTime)x["birthdate"];
                employee.CCCD = x["CCCD"].ToString();
                employee.address = x["address"].ToString();
                employee.phone = x["phone"].ToString();
                employee.role = Convert.ToInt32(x["role_id"].ToString());
                employee.status = x["status"].ToString();
                employee.pic = new MemoryStream((byte[])x["picture"]);
                if (list.Any(s => s.id == employee.id))
                {
                    MessageBox.Show("This Employee Has Been Added To The Shift", "Assign Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { list.Add(employee); }
            }
            dgvListEmployeeAssign.DataSource = list;
        }
    }
}
}

