using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace OS_Managment
{
    public partial class Home : Form
    {
        //[DllImport("user32.dll")]
        //public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public Home()
        {
            InitializeComponent();
        }

        private void btnPCInfo(object sender, EventArgs e)
        {
            Form f = new PC_Information();
            f.Show();
            this.Hide();

        }

        private void btnProcessMangment(object sender, EventArgs e)
        {
            Form f = new ProcesssManagment();
            f.Show();
            this.Hide();
        }

        private void btnDrives(object sender, EventArgs e)
        {
            Form f = new Drives();
            f.Show();
            this.Hide();
        }

        private void btnFiles(object sender, EventArgs e)
        {
            Form f = new Files();
            f.Show();
            this.Hide();
        }




        private void btnShutDown(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");

        }

        private void btnRestart(object sender, EventArgs e)
        {   
            Process.Start("shutdown", "/r /t 0");


        }



        private void pictureBox1_Click_ShowAPI(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Visible = false;
                return;
            }
            flowLayoutPanel1.Visible = true;
        }

        private void pictureBox2_Click_RunWord(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void pictureBox3_Click_RunExcel(object sender, EventArgs e)
        {
            Process.Start("excel.exe");

        }


        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

        }

        private void btnLogout(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/l");

        }

        private void btnForceLogout(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/f /l");

        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        private void Home_HomeClosing(object sender, FormClosedEventArgs e)
        {
         
            this.Dispose();
            Application.Exit();
        }
      
    }
}
