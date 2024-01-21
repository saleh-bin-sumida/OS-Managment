using System;
using System.Windows.Forms;
using System.IO;

namespace OS_Managment
{
    public partial class Drives : Form
    {
        public Drives()
        {
            InitializeComponent();
        }

        private void Drives_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();


            foreach (DriveInfo item in allDrives)
            {
                string x = "";

                if (item.IsReady)
                {
                    x += " Drive name :  " + item.Name + "\n";
                    listBox1.Items.Add(x);
                    x = "";

                    x += " Drive Type  name :  " + item.DriveType + "\n";
                    listBox1.Items.Add(x);
                    x = "";

                    x += " Drive Format Is :  " + item.DriveFormat + "\n";
                    listBox1.Items.Add(x);
                    x = "";

                    x += " Root Directory Is :  " + item.RootDirectory + "\n";
                    listBox1.Items.Add(x);
                    x = "";

                    x += " Total Free Space Is :  " + item.TotalFreeSpace / 1024 / 1024 / 1024 + " GB " + "\n";
                    listBox1.Items.Add(x);
                    x = "";


                    x += " Total Size Is :  " + item.TotalSize + "\n";
                    listBox1.Items.Add(x);
                    x = "";



                }
                    listBox1.Items.Add("--------------------------------");


            }
        }

        private void btnHome(object sender, EventArgs e)
        {
            Form d = new Home();
            d.Show();
            this.Hide();
        }
    }
}
