using System;
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
            //listView_Product.Columns.Add("Название", 200);
            //listView_Product.Columns.Add("Мин.Продажи", 60);
            //listView_Product.Columns.Add("Макс.Продажи", 60);
            //listView_Product.Columns.Add("Цена", 100);

            if (((MainForm)this.Owner).selectedCompany.Products != null)
            {
                ListViewItem item;

                foreach (var p in ((MainForm)this.Owner).selectedCompany.Products)
                {
                    item = new ListViewItem(new string[] { p.Name, p.MinSales.ToString(), p.MaxSales.ToString(), p.Price.ToString() });
                    listView_Product.Items.Add(item);
                }
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //ListViewItem item = new ListViewItem(new string[] {
            //    textBox_Name.Text, textBox_Min.Text, textBox_Max.Text, textBox_Price.Text });
            listView_Product.Columns.Add("Название", 200);
            listView_Product.Columns.Add("Мин.Продажи", 60);
            listView_Product.Columns.Add("Макс.Продажи", 60);
            listView_Product.Columns.Add("Цена", 100);
            ListViewItem item = new ListViewItem("item", 0);
            item.SubItems.Add("1");
            item.SubItems.Add("3");
            item.SubItems.Add("34.3");

            listView_Product.Items.Add(item);
        }
    }
}
