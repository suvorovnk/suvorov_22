using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._3
{
    public partial class AlarmClock : Form
    {
        public AlarmClock()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private DateTime bud;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int hour = (int)numericUpDown1.Value;
            int min = (int)numericUpDown2.Value;
            bud=new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,hour,min,0);
            notifyIcon1.Visible = true;
            notifyIcon1.Text = bud.ToShortTimeString();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            if ((bud.Hour==DateTime.Now.Hour)&&(bud.Minute==DateTime.Now.Minute)&&(bud.Second==DateTime.Now.Second))
            {
                Alarm form2 = new Alarm();
                form2.Show();
            }
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа будильник создана Суворовым Никитой Константиновичем");
        }

        private void завершитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
