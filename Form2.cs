using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfWork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                pictureBox1.Image = imageList1.Images[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                pictureBox1.Image = imageList1.Images[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                pictureBox1.Image = imageList1.Images[2];
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = pictureBox1.Image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 gform=new Form2();
            gform.BackgroundImage = pictureBox1.Image;
            timer1.Enabled=true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           this.Hide();
           Form3 form3 = new Form3();
           form3.ShowDialog();
           timer1.Stop();
           timer1.Enabled = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }
    }
}
