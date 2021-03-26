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
    public partial class Authorizecs : Form
    {
        public Authorizecs()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = checkBox1.Checked;
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            string role=op.CheckUser(textBox1.Text,textBox2.Text);
            if (role=="кассир")
            {
                this.Hide();
                Ticketer t = new Ticketer();
                t.Show();
            }
            else if (role=="оператор базы данных")
            {
                this.Hide();
                DBOperator dbop = new DBOperator();
                dbop.Show();
            }
            else if (role=="администратор")
            {
                this.Hide();
;               Admin a = new Admin();
                a.Show();
            }
            else if (role=="ошибка")
            {
                MessageBox.Show("Неверный логин или пароль");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Authorizecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
