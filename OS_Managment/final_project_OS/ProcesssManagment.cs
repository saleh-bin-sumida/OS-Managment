using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace OS_Managment
{
    public partial class ProcesssManagment : Form
    {
        public ProcesssManagment()
        {
            InitializeComponent();
        }

        private void btnGetCurrentProcess(object sender, EventArgs e)
        {
            MessageBox.Show(Process.GetCurrentProcess().ToString());
        }

        private void btnshow_all_process(object sender, EventArgs e)
        {
            Form f = new show_all_process();
            f.Show();
            this.Hide();
        }


        private void btnHome(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }

        private void btncreate_process(object sender, EventArgs e)
        {
            Form f = new CreateProcess();
            f.Show();
            this.Hide();
        }
    }
}
