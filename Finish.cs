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
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }
        User us=new User();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us.Change(textBox1.Text);
            MessageBox.Show("Пароль успешно изменён");
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = checkBox1.Checked;
            textBox1.PasswordChar = '*';
        }
    }
}
