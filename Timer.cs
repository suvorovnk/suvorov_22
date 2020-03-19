using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Timer
{
    public partial class Timer : Form
    {
        
        private int minutes, seconds;
        public Timer()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds>9)
                label1.Text = minutes + ":" + seconds;
            if (seconds<=9)
                label1.Text = minutes + ":0" + seconds;
            seconds = seconds - 1;
            if (seconds == -1)
            {
                minutes = minutes - 1;
                seconds = 59;
            }

            if ((seconds == 59) && (minutes == -1))
            {
                timer1.Enabled = false;
                MessageBox.Show("Заданный интервал времени истек");
                button1.Visible = false;
                button2.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Visible = true;
            button2.Visible = false;
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0:00")
            {
                minutes = Convert.ToInt32(numericUpDown1.Value);
                seconds = Convert.ToInt32(numericUpDown2.Value);
            }
            timer1.Enabled = true;
            groupBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button2.Enabled = true;
        }
    }
}
