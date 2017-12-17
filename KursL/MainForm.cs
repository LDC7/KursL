using System;
using System.IO;
using System.Windows.Forms;

namespace KursL
{
    public partial class MainForm : Form
    {
        public Project selectedProject;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_NewCompany_Click(object sender, EventArgs e)
        {
            CreateProjectForm createCompany = new CreateProjectForm();
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
                    selectedProject = XmlSer.Deserialize<Project>(reader);
                }

                reloadCompanyName();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Company files|*.xmlcom";
                saveFileDialog.Title = "Save Company";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(XmlSer.Serialize(selectedProject));
                    }
                }
            }
        }

        public void reloadCompanyName()
        {
            labelCompany.Text = "Проект: ";
            if (selectedProject != null)
            {
                labelCompany.Text += selectedProject.Name;
            }
        }

        private void button_Invest_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                InvestForm invest = new InvestForm();
                invest.Owner = this;
                invest.Show();
            }
        }

        private void button_Credits_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                CreditForm credit = new CreditForm();
                credit.Owner = this;
                credit.Show();
            }
        }

        private void button_Employees_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                EmployeeForm employees = new EmployeeForm();
                employees.Owner = this;
                employees.Show();
            }
        }

        private void button_Production_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                ProductionForm products = new ProductionForm();
                products.Owner = this;
                products.Show();
            }
        }

        private void button_Period_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                PeriodForm period = new PeriodForm();
                period.Owner = this;
                period.Show();
            }
        }

        private void button_Costs_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                CostsForm costs = new CostsForm();
                costs.Owner = this;
                costs.Show();
            }
        }

        private void button_Analysis_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                AnalysisForm analysis = new AnalysisForm();
                analysis.Owner = this;
                analysis.Show();
            }
        }
    }
}
