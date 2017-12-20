using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursL
{
    public partial class CostsForm : Form
    {
        public CostsForm()
        {
            InitializeComponent();
        }

        private void CostsForm_Load(object sender, EventArgs e)
        {
            string buf1, buf2;

            foreach(var c in ((MainForm)this.Owner).selectedProject.Costs)
            {
                buf1 = c.Start == null ? string.Empty : ((DateTime)c.Start).ToString("dd.MM.yyyy");
                buf2 = c.End == null ? string.Empty : ((DateTime)c.End).ToString("dd.MM.yyyy");

                dataGridView_Cost.Rows.Add(c.Name, buf1, buf2, c.MonthlyCost);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridView_Cost.SelectedRows)
            {
                dataGridView_Cost.Rows.Remove(i);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            string start = ".";            
            DateTime endDate;
            string end = ".";
            decimal cost;

            if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                if (string.IsNullOrWhiteSpace(textBox_Start.Text))
                {
                    start = string.Empty;
                }
                else
                {
                    if (DateTime.TryParse(textBox_Start.Text, out startDate))
                    {
                        start = startDate.ToString("dd.MM.yyyy");
                    }
                }

                if (string.IsNullOrWhiteSpace(textBox_End.Text))
                {
                    end = string.Empty;
                }
                else
                {
                    if (DateTime.TryParse(textBox_End.Text, out endDate))
                    {
                        end = endDate.ToString("dd.MM.yyyy");
                    }
                }

                if (start != "." && end != ".")
                {
                    if (decimal.TryParse(textBox_Monthly.Text.Replace('.', ','), out cost))
                    {
                        cost = Math.Round(cost, 2);
                        dataGridView_Cost.Rows.Add(textBox_Name.Text, start, end, cost);
                    }
                }                
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            DateTime? buf1, buf2;
            List<Cost> list = new List<Cost>();

            foreach (DataGridViewRow c in dataGridView_Cost.Rows)
            {
                buf1 = ((string)c.Cells[1].Value ?? string.Empty) == string.Empty ? null : (DateTime?)DateTime.Parse((string)c.Cells[1].Value);
                buf2 = ((string)c.Cells[2].Value ?? string.Empty) == string.Empty ? null : (DateTime?)DateTime.Parse((string)c.Cells[2].Value);
                list.Add(new Cost(c.Cells[0].Value.ToString(), buf1, buf2, (decimal)c.Cells[3].Value));
            }

            ((MainForm)this.Owner).selectedProject.Costs = list;
            Close();
        }
    }
}
