using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace OS_Managment
{
    public partial class show_all_process : Form
    {
        public show_all_process()
        {
            InitializeComponent();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            int index = listBox1.SelectedIndex;
            try
            {
                processes[index].Kill();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select a process to be killed, please!");
            }
        }

        private void show_all_process_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                listBox1.Items.Add(p.ProcessName);
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new ProcesssManagment();
            f.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }

        private void btnSort(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses().OrderBy(p => p.ProcessName).ToArray();
            foreach (Process p in processes)
            {
                listBox1.Items.Add(p.ProcessName);
            }

        }
    }
}
