using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Ticket
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            label1.Text = op.HelloMessage();
            monthCalendar1.TodayDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            label2.Text += op.AbonementCount().ToString();
            radioButton1.Checked = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (radioButton1.Checked) label3.Text = "Количество купленных билетов = "+ op.TicketCount();
            if (radioButton2.Checked)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value) MessageBox.Show("Первая дата должна быть не больше второй");
                else label3.Text = "Количество купленных билетов = "+op.TicketCount(dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employers empls = new Employers();
            empls.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authorizecs a = new Authorizecs();
            a.Show();
        }
    }
}
