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
                if(decimal.TryParse(textBox_Invest.Text, out buffer))
                {
                    buffer = buffer / (decimal)0.01;
                    ((MainForm)this.Owner).selectedCompany.StartCapital = buffer;
                }
            }
        }

        private void InvestForm_Load(object sender, EventArgs e)
        {
            buffer = ((MainForm)this.Owner).selectedCompany.StartCapital;
            textBox_Invest.Text = buffer.ToString();
        }
    }
}
