using System.Drawing;
using System;
using System.DirectoryServices.ActiveDirectory;

namespace Elipi
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }
        bool isOne = false;
        
        
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            if (isOne)
            {
                isOne = false;
                picture.BackColor = Color.FromArgb(244, 169, 0);
            }
            else 
            {
                isOne = true;
                picture.BackColor = Color.FromArgb(30, 30, 30);
            }
            

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.BackColor = Color.FromArgb(67, 67, 67);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    DateTime today = DateTime.Today;
            DateTime otherDate = DateTime.Today.AddDays(1);
            DateTime now = DateTime.Now;
            TimeSpan remaining = otherDate - now;
            label1.Text = remaining.ToString().Split('.')[0];
        
            // label9.Text = (otherDate.ToString("H:mm"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Thread thread = new Thread(() => MessageBox.Show("FvK")); thread.Start();
            }
        }
    }
}