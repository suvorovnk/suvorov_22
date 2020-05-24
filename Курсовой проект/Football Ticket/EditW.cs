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
    public partial class EditW : Form
    {
        public EditW(string s,string n,string p,string l,string pw,string r)
        {
            InitializeComponent();
            this.s = s;
            this.n = n;
            this.p = p;
            this.l = l;
            this.pw = pw;
            this.r = r;
        }
        public string s;
        public string n;
        public string p;
        public string l;
        public string pw;
        public string r;

        private void EditW_Load(object sender, EventArgs e)
        {
            textBox1.Text = s;
            textBox2.Text = n;
            textBox3.Text = p;
            textBox4.Text = l;
            textBox5.Text = pw;
            comboBox1.SelectedItem = r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.EditWorker(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.SelectedItem.ToString());
            this.Close();
        }
    }
}
