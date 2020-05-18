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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Авторизация2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 f1=new Form1();
            Authorizecs f = new Authorizecs();
            f.Show();
        }

        private void купитьабонементToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
          

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            label2.Text = op.SoonMatches(0);
            label3.Text = op.SoonMatches(1);
            label4.Text = op.SoonMatches(2);
            label5.Text = op.SoonMatches(3);
            label6.Text = op.SoonMatches(4);
            label7.Text = op.SoonMatches(5);
            label8.Text = op.SoonMatches(6);
            label9.Text = op.SoonMatches(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            label2.Text = op.SoonMatches(8);
            label3.Text = op.SoonMatches(9);
            label4.Text = op.SoonMatches(10);
            label5.Text = op.SoonMatches(11);
            label6.Text = op.SoonMatches(12);
            label7.Text = op.SoonMatches(13);
            label8.Text = op.SoonMatches(14);
            label9.Text = op.SoonMatches(15);
            button2.Enabled = true;
            button2.Visible = true;
            button1.Enabled = false;
            button1.Visible = false;
            label11.Text = "Перейти на предыдущую страницу матчей";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            label2.Text = op.SoonMatches(0);
            label3.Text = op.SoonMatches(1);
            label4.Text = op.SoonMatches(2);
            label5.Text = op.SoonMatches(3);
            label6.Text = op.SoonMatches(4);
            label7.Text = op.SoonMatches(5);
            label8.Text = op.SoonMatches(6);
            label9.Text = op.SoonMatches(7);
            button2.Enabled = false;
            button2.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
            label11.Text = "Перейти на следующую страницу матчей";
        }
        public  int kod_of_match;
        private void label2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label2.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 0;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 8;
            }
            Stadium st = new Stadium();
            st.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label3.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 1;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 9;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label4.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 2;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 10;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label5.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 3;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 11;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label6.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 4;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 12;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label7.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 5;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 13;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label8.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 6;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 14;
            }
            Stadium st = new Stadium();
            st.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (label9.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_of_match = 7;
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_of_match = 15;
            }
            Stadium st = new Stadium();
            st.Show();
        }
    }
}
