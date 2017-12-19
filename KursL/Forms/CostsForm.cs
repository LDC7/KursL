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
            foreach(var c in ((MainForm)this.Owner).selectedProject.Costs)
            {
                dataGridView_Cost.Rows.Add(c.Name, c.Start, c.End, c.MonthlyCost);
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
                    if (decimal.TryParse(textBox_End.Text.Replace(',', '.'), out cost))
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
                buf1 = string.IsNullOrEmpty(c.Cells[1].Value.ToString()) ? null : (DateTime?)DateTime.Parse(c.Cells[1].Value.ToString());
                buf2 = string.IsNullOrEmpty(c.Cells[2].Value.ToString()) ? null : (DateTime?)DateTime.Parse(c.Cells[2].Value.ToString());
                list.Add(new Cost(c.Cells[0].Value.ToString(), buf1, buf2, (decimal)c.Cells[3].Value));
            }

            ((MainForm)this.Owner).selectedProject.Costs = list;
            Close();
        }
    }
}
