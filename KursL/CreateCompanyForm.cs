using System;
using System.Windows.Forms;

namespace KursL
{
    public partial class CreateCompanyForm : Form
    {
        public CreateCompanyForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_CompanyName.Text))
            {
                ((MainForm)this.Owner).selectedCompany.RecreateCompany(textBox_CompanyName.Text);
                ((MainForm)this.Owner).reloadCompanyName();

                Close();
            }
        }
    }
}
