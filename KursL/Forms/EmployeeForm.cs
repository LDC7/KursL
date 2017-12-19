using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursL
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            foreach(var emp in ((MainForm)this.Owner).selectedProject.Employees)
            {
                dataGridView_Emp.Rows.Add(emp.Name, emp.Num, emp.Salary);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridView_Emp.SelectedRows)
            {
                dataGridView_Emp.Rows.Remove(i);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int num;
            decimal salary;

            if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                if (int.TryParse(textBox_Num.Text, out num))
                {
                    if (decimal.TryParse(textBox_Salary.Text.Replace(',', '.'), out salary))
                    {
                        salary = Math.Round(salary, 2);
                        dataGridView_Emp.Rows.Add(textBox_Name.Text, num, salary);
                    }
                }
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            List<Employee> list = new List<Employee>();

            foreach (DataGridViewRow emp in dataGridView_Emp.Rows)
            {
                list.Add(new Employee(emp.Cells[0].Value.ToString(), (int)emp.Cells[1].Value, (decimal)emp.Cells[2].Value));
            }

            ((MainForm)this.Owner).selectedProject.Employees = list;
            Close();
        }
    }
}
