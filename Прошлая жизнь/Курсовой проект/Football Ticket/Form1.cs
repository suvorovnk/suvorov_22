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

        private void Form1_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            if (op.SoonMatches(0)[0] == "Матч недоступен")
            {
                kods[0] = 0;
                label2.Text = "Матч недоступен";
            }
            else
            {
                kods[0] = int.Parse(op.SoonMatches(0)[0]);
                label2.Text = op.SoonMatches(0)[1] + "\n" + op.SoonMatches(0)[2] + "\n" + op.SoonMatches(0)[3];
            }
            if (op.SoonMatches(1)[0] == "Матч недоступен")
            {
                kods[1] = 0;
                label3.Text = "Матч недоступен";
            }
            else
            {
                kods[1] = int.Parse(op.SoonMatches(1)[0]);
                label3.Text = op.SoonMatches(1)[1] + "\n" + op.SoonMatches(1)[2] + "\n" + op.SoonMatches(1)[3];
            }
            if (op.SoonMatches(2)[0] == "Матч недоступен")
            {
                kods[2] = 0;
                label4.Text = "Матч недоступен";
            }
            else
            {
                kods[2] = int.Parse(op.SoonMatches(2)[0]);
                label4.Text = op.SoonMatches(2)[1] + "\n" + op.SoonMatches(2)[2] + "\n" + op.SoonMatches(2)[3];
            }
            if (op.SoonMatches(3)[0] == "Матч недоступен")
            {
                kods[3] = 0;
                label5.Text = "Матч недоступен";
            }
            else
            {
                kods[3] = int.Parse(op.SoonMatches(3)[0]);
                label5.Text = op.SoonMatches(3)[1] + "\n" + op.SoonMatches(3)[2] + "\n" + op.SoonMatches(3)[3];
            }
            if (op.SoonMatches(4)[0] == "Матч недоступен")
            {
                kods[4] = 0;
                label6.Text = "Матч недоступен";
            }
            else
            {
                kods[4] = int.Parse(op.SoonMatches(4)[0]);
                label6.Text = op.SoonMatches(4)[1] + "\n" + op.SoonMatches(4)[2] + "\n" + op.SoonMatches(4)[3];
            }
            if (op.SoonMatches(5)[0] == "Матч недоступен")
            {
                kods[5] = 0;
                label7.Text = "Матч недоступен";
            }
            else
            {
                kods[5] = int.Parse(op.SoonMatches(5)[0]);
                label7.Text = op.SoonMatches(5)[1] + "\n" + op.SoonMatches(5)[2] + "\n" + op.SoonMatches(5)[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (op.SoonMatches(6)[0] == "Матч недоступен")
            {
                kods[6] = 0;
                label2.Text = "Матч недоступен";
            }
            else
            {
                kods[6] = int.Parse(op.SoonMatches(6)[0]);
                label2.Text = op.SoonMatches(6)[1] + "\n" + op.SoonMatches(6)[2] + "\n" + op.SoonMatches(6)[3];
            }
            if (op.SoonMatches(7)[0] == "Матч недоступен")
            {
                kods[7] = 0;
                label3.Text = "Матч недоступен";
            }
            else
            {
                kods[7] = int.Parse(op.SoonMatches(7)[0]);
                label3.Text = op.SoonMatches(7)[1] + "\n" + op.SoonMatches(7)[2] + "\n" + op.SoonMatches(7)[3];
            }
            if (op.SoonMatches(8)[0] == "Матч недоступен")
            {
                kods[8] = 0;
                label4.Text = "Матч недоступен";
            }
            else
            {
                kods[8] = int.Parse(op.SoonMatches(8)[0]);
                label4.Text = op.SoonMatches(8)[1] + "\n" + op.SoonMatches(8)[2] + "\n" + op.SoonMatches(8)[3];
            }
            if (op.SoonMatches(9)[0] == "Матч недоступен")
            {
                kods[9] = 0;
                label5.Text = "Матч недоступен";
            }
            else
            {
                kods[9] = int.Parse(op.SoonMatches(9)[0]);
                label5.Text = op.SoonMatches(9)[1] + "\n" + op.SoonMatches(9)[2] + "\n" + op.SoonMatches(9)[3];
            }
            if (op.SoonMatches(10)[0] == "Матч недоступен")
            {
                kods[10] = 0;
                label6.Text = "Матч недоступен";
            }
            else
            {
                kods[10] = int.Parse(op.SoonMatches(10)[0]);
                label6.Text = op.SoonMatches(10)[1] + "\n" + op.SoonMatches(10)[2] + "\n" + op.SoonMatches(10)[3];
            }
            if (op.SoonMatches(11)[0] == "Матч недоступен")
            {
                kods[11] = 0;
                label7.Text = "Матч недоступен";
            }
            else
            {
                kods[11] = int.Parse(op.SoonMatches(11)[0]);
                label7.Text = op.SoonMatches(11)[1] + "\n" + op.SoonMatches(11)[2] + "\n" + op.SoonMatches(11)[3];
            }
            button2.Enabled = true;
            button2.Visible = true;
            button1.Enabled = false;
            button1.Visible = false;
            label11.Text = "Перейти на предыдущую страницу матчей";
        }
        public int kod_match;
        public int[] kods = new int[12];
        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (op.SoonMatches(0)[0] == "Матч недоступен") label2.Text = "Матч недоступен";
            else label2.Text = op.SoonMatches(0)[1] + "\n" + op.SoonMatches(0)[2] + "\n" + op.SoonMatches(0)[3];
            if (op.SoonMatches(1)[0] == "Матч недоступен") label3.Text = "Матч недоступен";
            else label3.Text = op.SoonMatches(1)[1] + "\n" + op.SoonMatches(1)[2] + "\n" + op.SoonMatches(1)[3];
            if (op.SoonMatches(2)[0] == "Матч недоступен") label4.Text = "Матч недоступен";
            else label4.Text = op.SoonMatches(2)[1] + "\n" + op.SoonMatches(2)[2] + "\n" + op.SoonMatches(2)[3];
            if (op.SoonMatches(3)[0] == "Матч недоступен") label5.Text = "Матч недоступен";
            else label5.Text = op.SoonMatches(3)[1] + "\n" + op.SoonMatches(3)[2] + "\n" + op.SoonMatches(3)[3];
            if (op.SoonMatches(4)[0] == "Матч недоступен") label6.Text = "Матч недоступен";
            else label6.Text = op.SoonMatches(4)[1] + "\n" + op.SoonMatches(4)[2] + "\n" + op.SoonMatches(4)[3];
            if (op.SoonMatches(5)[0] == "Матч недоступен") label7.Text = "Матч недоступен";
            else label7.Text = op.SoonMatches(5)[1] + "\n" + op.SoonMatches(5)[2] + "\n" + op.SoonMatches(5)[3];
            button2.Enabled = false;
            button2.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
            label11.Text = "Перейти на следующую страницу матчей";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label2.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text== "Перейти на следующую страницу матчей")
            {
                kod_match = kods[0];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text== "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[6];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label3.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_match = kods[1];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[7];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label4.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_match = kods[2];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[8];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label5.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_match = kods[3];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[9];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label6.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_match = kods[4];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[10];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options();
            if (label7.Text == "Матч недоступен") MessageBox.Show("На данный матч купить билет нельзя");
            else if (label11.Text == "Перейти на следующую страницу матчей")
            {
                kod_match = kods[5];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            else if (label11.Text == "Перейти на предыдущую страницу матчей")
            {
                kod_match = kods[11];
                Stadium st = new Stadium(kod_match);
                st.Show();
            }
            
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.White;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.BackColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            Authorizecs f = new Authorizecs();
            f.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Stadium s = new Stadium(0);
            s.Show();
            
        }
    }
}
    

