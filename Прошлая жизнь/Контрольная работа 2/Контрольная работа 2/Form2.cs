using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Контрольная_работа_2
{
    public partial class Form2 : Form
    {
        public Form2(Image i,string name,string pozh,string name_ot,string add)
        {
            InitializeComponent();
            this.im = i;
            this.n = name;
            this.poz = pozh;
            this.name = name_ot;
            this.add = add;
        }
        public Image im;
        public string n;
        public string poz;
        public string name;
        public string add;

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = im;
            label1.Text = n;
            textBox1.Text = poz + Environment.NewLine;
            textBox1.Text += "\t"+name + Environment.NewLine;
            textBox1.Text += "\t"+add + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Opacity = 0;
            
        }
    }
}
