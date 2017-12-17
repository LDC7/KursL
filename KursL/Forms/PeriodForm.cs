using System;
using System.Windows.Forms;

namespace KursL
{
    public partial class PeriodForm : Form
    {
        public PeriodForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            DateTime dataTimeStart;
            DateTime dataTimeEnd;

            if (DateTime.TryParse(textBox_PeriodStart.Text, out dataTimeStart))
            {
                if (DateTime.TryParse(textBox_PeriodEnd.Text, out dataTimeEnd))
                {
                    if (dataTimeStart.CompareTo(dataTimeEnd) < 0)
                    {
                        ((MainForm)this.Owner).selectedProject.PeriodStart = dataTimeStart;
                        ((MainForm)this.Owner).selectedProject.PeriodEnd = dataTimeEnd;
                        ((MainForm)this.Owner).reloadCompanyName();

                        Close();
                    }
                }
            }

        }
    }
}
