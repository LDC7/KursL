using System;
using System.IO;
using System.Windows.Forms;

namespace KursL
{
    public partial class MainForm : Form
    {
        public Company selectedCompany;

        public MainForm()
        {
            InitializeComponent();
            selectedCompany = new Company();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_NewCompany_Click(object sender, EventArgs e)
        {
            CreateCompanyForm createCompany = new CreateCompanyForm();
            createCompany.Owner = this;
            createCompany.Show();

            reloadCompanyName();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Company files|*.xmlcom";
            openFileDialog.Title = "Select Company";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    selectedCompany = XmlSer.Deserialize<Company>(reader);
                }

                reloadCompanyName();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (selectedCompany != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Company files|*.xmlcom";
                saveFileDialog.Title = "Save Company";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(XmlSer.Serialize(selectedCompany));
                    }
                }
            }
        }

        public void reloadCompanyName()
        {
            labelCompany.Text = "Компания: ";
            if (selectedCompany != null)
            {
                labelCompany.Text += selectedCompany.Name;
            }
        }

        private void button_Invest_Click(object sender, EventArgs e)
        {
            InvestForm invest = new InvestForm();
            invest.Owner = this;
            invest.Show();
        }

        private void button_Credits_Click(object sender, EventArgs e)
        {

        }

        private void button_Employees_Click(object sender, EventArgs e)
        {

        }

        private void button_Production_Click(object sender, EventArgs e)
        {
            ProductionForm products = new ProductionForm();
            products.Owner = this;
            products.Show();
        }
    }
}
