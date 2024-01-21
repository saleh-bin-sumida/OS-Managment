using System;
using System.Windows.Forms;
using System.IO;

namespace OS_Managment
{
    public partial class Files : Form
    {
        public Files()
        {
            InitializeComponent();
        }

        private void btnCreateFile(object sender, EventArgs e)
        {
            string sourcefile = textBox1.Text;
            if (File.Exists(sourcefile))
            {
                MessageBox.Show("This File Already Exsit");
                return;
            }

            File.Create(sourcefile);
            MessageBox.Show("The File Create Successfuly");
            
        }

        private void btnCutFile(object sender, EventArgs e)
        {
            string sourcefile = textBox2.Text;
            string desfile = textBox3.Text;

            if (!File.Exists(sourcefile))
            {
                MessageBox.Show("file not found");
            }
            else
            {
                File.Move(sourcefile, desfile);
                MessageBox.Show("the file cut successfuly");

            }

        }

        private void btnCopyFile(object sender, EventArgs e)
        {
            string soucefile = textBox5.Text;
            string desfile = textBox4.Text;
            if (!File.Exists(soucefile))
            {
                MessageBox.Show("file name is not found");
            }
            else
            {
                File.Copy(soucefile, desfile);
                MessageBox.Show("the file copy seccessfuly");
            }
        }

        private void btnDeleteFile(object sender, EventArgs e)
        {
            string soucefile = textBox6.Text;

            if (!File.Exists(soucefile))
            {
                MessageBox.Show("file name is not found");
            }
            else
            {
                File.Delete(soucefile);
                MessageBox.Show("the file deleted seccessfuly");
            }
        }


        private void btnHome(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }

 
        private void textBox1_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

     
    }
}
