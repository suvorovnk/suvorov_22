using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfWork
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана Суворовым Никитой Константиновичем");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            Form2 form2 = new Form2();
            Form3 form3=new Form3();
            form1.Close();
            form2.Close();
            form3.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 aform =new Form1();
            aform.Show();
        }
    }
}
