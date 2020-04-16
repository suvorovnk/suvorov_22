using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (maskedTextBox1.Text == "password"))
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации");
                textBox1.Text = "";
                maskedTextBox1.Text = "";
            }
        }
    }
}
