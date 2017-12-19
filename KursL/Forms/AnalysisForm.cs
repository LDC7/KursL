using System;
using System.IO;
using System.Windows.Forms;

namespace KursL
{
    public partial class AnalysisForm : Form
    {
        Project project;

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
            project = ((MainForm)this.Owner).selectedProject;
            CreateGrid();
        }

        private void CreateGrid()
        {
            //Отчистка

            //Колонки
            DateTime now = new DateTime(project.PeriodStart.Year, project.PeriodStart.Month, 1);
            for (int i = 0; i <= ((project.PeriodEnd.Year - project.PeriodStart.Year) * 12 + project.PeriodEnd.Month - project.PeriodStart.Month); i++)
            {
                dataGridView_Analys.Columns.Add($"period{i}", now.ToString("dd.MM.yyyy"));
                now = now.AddMonths(i);
            }

            //Ряды
            dataGridView_Analys.Rows.Add(8);
            dataGridView_Analys.Rows[0].HeaderCell.Value = "Начало периода";
            dataGridView_Analys.Rows[1].HeaderCell.Value = "Инвестиции";
            dataGridView_Analys.Rows[2].HeaderCell.Value = "Займы";
            dataGridView_Analys.Rows[3].HeaderCell.Value = "Плата сотрудникам";
            dataGridView_Analys.Rows[4].HeaderCell.Value = "Поступления от продаж";
            dataGridView_Analys.Rows[5].HeaderCell.Value = "Издержки";
            dataGridView_Analys.Rows[6].HeaderCell.Value = "Выплаты по кредиту";
            dataGridView_Analys.Rows[7].HeaderCell.Value = "NPV";
            dataGridView_Analys.Rows[8].HeaderCell.Value = "Конец периода";

            //Заполнение
            now = new DateTime(project.PeriodStart.Year, project.PeriodStart.Month, 1);
            decimal startCapital = 0.00m;
            decimal endCapital;
            decimal temp;
            decimal npv;
            for (int i = 0; i <= ((project.PeriodEnd.Year - project.PeriodStart.Year) * 12 + project.PeriodEnd.Month - project.PeriodStart.Month); i++)
            {
                endCapital = 0.00m;
                npv = 0.00m;
                if (i == 0)
                {
                    endCapital += project.Investments;
                }
                //Начало периода
                dataGridView_Analys.Rows[0].Cells[i].Value = startCapital;
                endCapital += startCapital;
                temp = project.Loan(now);

                //Займы
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[2].Cells[i].Value = temp;
                    endCapital += temp;
                }

                //Зарплата
                temp = project.Salaries();
                dataGridView_Analys.Rows[3].Cells[i].Value = temp;
                endCapital -= temp;
                temp = project.Sales();

                //Продажи
                dataGridView_Analys.Rows[4].Cells[i].Value = temp;
                endCapital += temp;
                npv += temp;

                //Издержки
                temp = project.CostPayments(now);
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[5].Cells[i].Value = temp;
                    endCapital -= temp;
                    npv -= temp;
                }

                //Выплаты по кредиту
                temp = project.LoanPayments(now);
                if (temp > 0)
                {
                    dataGridView_Analys.Rows[6].Cells[i].Value = temp;
                    endCapital -= temp;
                }

                //NPV
                dataGridView_Analys.Rows[7].Cells[i].Value = npv;

                //Конец периода
                dataGridView_Analys.Rows[8].Cells[i].Value = endCapital;

                startCapital = endCapital;
                now = now.AddMonths(i);
            }

            //Инвестиции
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

        private void checkBox_Sales_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sales.Checked)
            {
                trackBar_Sales.Enabled = false;
                CreateGrid();
            }
            else
            {
                trackBar_Sales.Enabled = true;
                CreateGrid();
            }
        }

        private void trackBar_Sales_Scroll(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CreateGrid();
        }
    }
}
