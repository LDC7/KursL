using System;
using System.Windows.Forms;

namespace KursL
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
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

            if (!string.IsNullOrWhiteSpace(textBox_ProjectName.Text))
            {
                if (DateTime.TryParse(textBox_PeriodStart.Text, out dataTimeStart))
                {
                    if (DateTime.TryParse(textBox_PeriodEnd.Text, out dataTimeEnd))
                    {
                        if (dataTimeStart.CompareTo(dataTimeEnd) < 0)
                        {
                            if (((MainForm)this.Owner).selectedProject == null)
                            {
                                ((MainForm)this.Owner).selectedProject = new Project();
                            }
                            ((MainForm)this.Owner).selectedProject.RecreateCompany(textBox_ProjectName.Text);
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
}
