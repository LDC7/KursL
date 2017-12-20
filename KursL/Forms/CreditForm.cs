using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursL
{
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {
            foreach (var c in ((MainForm)this.Owner).selectedProject.Credits)
            {
                dataGridView_Prod.Rows.Add(c.TakeDate.ToString("dd.MM.yyyy"), c.RepayDate.ToString("dd.MM.yyyy"), c.Percent, c.Loan);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridView_Prod.SelectedRows)
            {
                dataGridView_Prod.Rows.Remove(i);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            decimal percent;
            decimal loan;

            if (DateTime.TryParse(textBox_Start.Text, out startDate))
            {
                if (DateTime.TryParse(textBox_End.Text, out endDate))
                {
                    if (startDate.CompareTo(endDate) < 0)
                    {
                        if (decimal.TryParse(textBox_Percent.Text.Replace('.', ','), out percent))
                        {
                            if (decimal.TryParse(textBox_Loan.Text.Replace('.', ','), out loan))
                            {
                                percent = Math.Round(percent, 1);
                                loan = Math.Round(loan, 2);
                                dataGridView_Prod.Rows.Add(startDate.ToString("dd.MM.yyyy"), endDate.ToString("dd.MM.yyyy"), percent, loan);
                            }
                        }
                    }
                }
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            List<Credit> list = new List<Credit>();

            foreach (DataGridViewRow c in dataGridView_Prod.Rows)
            {
                list.Add(new Credit(DateTime.Parse((string)c.Cells[0].Value), DateTime.Parse((string)c.Cells[1].Value), (decimal)c.Cells[2].Value, (decimal)c.Cells[3].Value));
            }

            ((MainForm)this.Owner).selectedProject.Credits = list;
            Close();
        }
    }
}
