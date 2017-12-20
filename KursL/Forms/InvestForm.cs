using System;
using System.Windows.Forms;

namespace KursL
{
    public partial class InvestForm : Form
    {
        private decimal buffer;

        public InvestForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox_Invest.Text))
            {
                if (decimal.TryParse(textBox_Invest.Text.Replace('.', ','), out buffer))
                {
                    buffer = Math.Round(buffer, 2);
                    ((MainForm)this.Owner).selectedProject.Investments = buffer;
                }

                Close();
            }
        }

        private void InvestForm_Load(object sender, EventArgs e)
        {
            buffer = ((MainForm)this.Owner).selectedProject.Investments;
            textBox_Invest.Text = buffer.ToString();
        }
    }
}
