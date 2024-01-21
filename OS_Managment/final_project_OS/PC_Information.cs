using System;
using System.Windows.Forms;

namespace OS_Managment
{
    public partial class PC_Information : Form
    {
        public PC_Information()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }


        private void PC_information_Load(object sender, EventArgs e)
        {
            label1.Text = System.Environment.MachineName;
            label4.Text = System.Environment.UserName;
            label6.Text = System.Environment.OSVersion.ToString();
            label8.Text = System.Environment.CurrentDirectory;
            label10.Text = System.Environment.Is64BitOperatingSystem.ToString();
        }
    }
}
