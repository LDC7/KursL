using System;
using System.IO;
using System.Windows.Forms;

namespace KursL
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            CreateGrid(((MainForm)this.Owner).selectedProject);
        }

        private void CreateGrid(Project project)
        {
            DateTime now = new DateTime(project.PeriodStart.Year, project.PeriodStart.Month, 1);
            for (int i = 0; i <= ((project.PeriodEnd.Year - project.PeriodStart.Year) * 12 + project.PeriodEnd.Month - project.PeriodStart.Month); i++)
            {
                dataGridView_Analys.Columns.Add($"period{i}", now.ToString("dd.MM.yyyy"));
                now = now.AddMonths(i);
            }

            dataGridView_Analys.Rows.Add(7);
            dataGridView_Analys.Rows[0].HeaderCell.Value = "Начало периода";
            dataGridView_Analys.Rows[1].HeaderCell.Value = "Инвестиции";
            dataGridView_Analys.Rows[2].HeaderCell.Value = "Займы";
            dataGridView_Analys.Rows[3].HeaderCell.Value = "Плата сотрудникам";
            dataGridView_Analys.Rows[4].HeaderCell.Value = "Поступления от продаж";
            dataGridView_Analys.Rows[5].HeaderCell.Value = "Издержки";
            dataGridView_Analys.Rows[6].HeaderCell.Value = "Выплаты по кредиту";
            dataGridView_Analys.Rows[7].HeaderCell.Value = "Конец периода";

            now = new DateTime(project.PeriodStart.Year, project.PeriodStart.Month, 1);
            decimal startCapital = 0.00m;
            decimal endCapital;
            decimal temp;
            for (int i = 0; i <= ((project.PeriodEnd.Year - project.PeriodStart.Year) * 12 + project.PeriodEnd.Month - project.PeriodStart.Month); i++)
            {
                endCapital = 0.00m;
                if (i == 0)
                {
                    endCapital += project.Investments;
                }
                dataGridView_Analys.Rows[0].Cells[i].Value = startCapital;
                endCapital += startCapital;
                temp = project.Loan(now);
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[2].Cells[i].Value = temp;
                    endCapital += temp;
                }
                temp = project.Salaries();
                dataGridView_Analys.Rows[3].Cells[i].Value = temp;
                endCapital -= temp;
                temp = project.Sales();
                dataGridView_Analys.Rows[4].Cells[i].Value = temp;
                endCapital += temp;
                temp = project.CostPayments(now);
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[5].Cells[i].Value = temp;
                    endCapital -= temp;
                }
                temp = project.LoanPayments(now);
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[6].Cells[i].Value = temp;
                    endCapital -= temp;
                }
                dataGridView_Analys.Rows[7].Cells[i].Value = endCapital;

                startCapital = endCapital;
                now = now.AddMonths(i);
            }

            dataGridView_Analys.Rows[1].Cells[0].Value = project.Investments;
        }

        private void button_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv|*.csv";
            saveFileDialog.Title = "Save csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write($"{dataGridView_Analys.TopLeftHeaderCell.Value ?? string.Empty};");
                    foreach (DataGridViewColumn h in dataGridView_Analys.Columns)
                    {
                        writer.Write($"{h.HeaderCell.Value ?? string.Empty};");
                    }
                    writer.Write(Environment.NewLine);

                    foreach (DataGridViewRow l in dataGridView_Analys.Rows)
                    {
                        writer.Write($"{l.HeaderCell.Value ?? string.Empty};");
                        foreach (DataGridViewCell c in l.Cells)
                        {
                            writer.Write($"{c.Value ?? string.Empty};");
                        }
                        writer.Write(Environment.NewLine);
                    }
                }
            }
        }
    }
}
