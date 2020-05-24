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
    public partial class Ticketer : Form
    {
        public Ticketer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ticketer_Load(object sender, EventArgs e)
        {
            List<int> m = new List<int>();
            Options op = new Options();
            m = op.MatchesT();
            foreach (int i in m)
            {
                comboBox1.Items.Add(i);
            }
            for (int i=1;i<=35;i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int i = 1; i <= 6; i++)
            {
                comboBox3.Items.Add(i);
            }
            for (int i = 1; i <= 8; i++)
            {
                comboBox4.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (op.CheckPlace(int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox2.SelectedItem.ToString()), int.Parse(comboBox3.SelectedItem.ToString()), int.Parse(comboBox4.SelectedItem.ToString())) == true)
            {
                op.DeletePlace(int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox2.SelectedItem.ToString()), int.Parse(comboBox3.SelectedItem.ToString()), int.Parse(comboBox4.SelectedItem.ToString()));
                MessageBox.Show("Билет сдан!");
            }
            else MessageBox.Show("Билет на это место не куплен");
        }

        private void Ticketer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authorizecs a = new Authorizecs();
            a.Show();
        }
    }
}
