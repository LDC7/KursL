using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KursL
{
    public partial class ProductionForm : Form
    {
        public ProductionForm()
        {
            InitializeComponent();
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            foreach (var p in ((MainForm)this.Owner).selectedProject.Products)
            {
                dataGridView_Prod.Rows.Add(p.Name, p.MinSales, p.MaxSales, p.Price);
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
            int min;
            int max;
            decimal price;
            StringBuilder sb;

            if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                if (int.TryParse(textBox_Min.Text, out min))
                {
                    if (int.TryParse(textBox_Max.Text, out max))
                    {
                        sb = new StringBuilder(textBox_Price.Text);
                        int i = textBox_Price.Text.IndexOf('.');
                        if (i >= 0)
                        {
                            sb[i] = ',';
                        }
                        if (decimal.TryParse(sb.ToString(), out price))
                        {
                            price = price - (price % 0.01m);
                            dataGridView_Prod.Rows.Add(textBox_Name.Text, min, max, price);
                        }
                    }
                }
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();

            foreach (DataGridViewRow p in dataGridView_Prod.Rows)
            {
                list.Add(new Product(p.Cells[0].Value.ToString(), (int)p.Cells[1].Value, (int)p.Cells[2].Value, (decimal)p.Cells[3].Value));
            }

            ((MainForm)this.Owner).selectedProject.Products = list;
            Close();
        }
    }
}
