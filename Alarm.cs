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
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlarmClock form1 = new AlarmClock();
            form1.Show();
            this.Close();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
