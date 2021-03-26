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
    public partial class EditT : Form
    {
        public EditT(string name,string city)
        {
            InitializeComponent();
            this.n = name;
            this.c = city;
        }
        public string n;
        public string c;

        private void EditT_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            textBox1.Text = n;
            textBox2.Text = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.EditTeam(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
