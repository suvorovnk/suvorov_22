using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Start : Form
    {
        User us=new User();
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (us.Check(textBox1.Text, textBox2.Text)!="Error")
            {
                this.Hide();
                Finish f = new Finish();
                f.Text = us.Check(textBox1.Text, textBox2.Text);
                f.Show();
            }
            else MessageBox.Show("Логин и пароль введены неверно");
        }
    }
}
