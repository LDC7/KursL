using System;
using System.Text;
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
                var sb = new StringBuilder(textBox_Invest.Text);
                int i = textBox_Invest.Text.IndexOf('.');
                if (i >= 0)
                {
                    sb[i] = ',';
                }
                if (decimal.TryParse(sb.ToString(), out buffer))
                {
                    buffer = buffer - (buffer % 0.01m);
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
