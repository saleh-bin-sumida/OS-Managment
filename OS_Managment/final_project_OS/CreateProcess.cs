using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace OS_Managment
{
    public partial class CreateProcess : Form
    {
        public CreateProcess()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new ProcesssManagment();
            f.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form d = new Home();
            d.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start(textBox1.Text);
            }
            catch (Exception e1)
            {
                string message = e1.Message;
                if (message == "The system cannot find the file specified")
                {
                    MessageBox.Show("Wrong process Name!");
                }
            }
        }
    }
}
