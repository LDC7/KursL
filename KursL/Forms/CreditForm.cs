using System;
using System.Collections.Generic;
using System.Text;
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
                dataGridView_Prod.Rows.Add(c.TakeDate, c.RepayDate, c.Percent, c.Loan);
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
            StringBuilder sb;

            if (DateTime.TryParse(textBox_Start.Text, out startDate))
            {
                if (DateTime.TryParse(textBox_End.Text, out endDate))
                {
                    if (startDate.CompareTo(endDate) < 0)
                    {
                        sb = new StringBuilder(textBox_Percent.Text);
                        int i = textBox_Percent.Text.IndexOf('.');
                        if (i >= 0)
                        {
                            sb[i] = ',';
                        }
                        if (decimal.TryParse(sb.ToString(), out percent))
                        {
                            sb = new StringBuilder(textBox_Loan.Text);
                            i = textBox_Loan.Text.IndexOf('.');
                            if (i >= 0)
                            {
                                sb[i] = ',';
                            }
                            if (decimal.TryParse(sb.ToString(), out loan))
                            {
                                percent = percent - (percent % 0.1m);
                                loan = loan - (loan % 0.01m);
                                dataGridView_Prod.Rows.Add(startDate.Date, endDate.Date, percent, loan);
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
                list.Add(new Credit((DateTime)c.Cells[0].Value, (DateTime)c.Cells[1].Value, (decimal)c.Cells[2].Value, (decimal)c.Cells[3].Value));
            }

            ((MainForm)this.Owner).selectedProject.Credits = list;
            Close();
        }
    }
}
