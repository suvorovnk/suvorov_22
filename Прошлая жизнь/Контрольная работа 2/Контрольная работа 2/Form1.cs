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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string name;
        public string pozh;
        public string name_ot;
        public string ad_ot;
        private void button1_Click(object sender, EventArgs e)
        {
            Image im = pictureBox1.Image;
            if (radioButton1.Checked) im = pictureBox1.Image;
            if (radioButton2.Checked) im = pictureBox2.Image;
            if (radioButton3.Checked) im = pictureBox3.Image;
            Functions f = new Functions();
            
            name = textBox3.Text;
            pozh = textBox5.Text;
            name_ot = textBox1.Text;
            ad_ot = textBox2.Text;
            Form2 f2 = new Form2(im, name, pozh, name_ot, ad_ot);
            if ((textBox3.Text != "") && (f.CheckAddress(textBox4.Text) == true)&&(f.CheckAddress(textBox2.Text)==true))
            {
                f2.Show();
                this.Opacity = 1;
            }
            else MessageBox.Show("Неправильно введены данные");
        }
    }
}
