using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class FormAddStudent : Form
    {
        public demoEntities db = new demoEntities();
        public FormAddStudent()
        {
            InitializeComponent();
            var groups_for_list = (from g in db.groups select g.name_group).Distinct();
            foreach (string it in groups_for_list)
            {
                comboBox1.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from g in db.groups
                         where g.name_group == comboBox1.SelectedItem.ToString()
                         select g.code_group).ToList();
            int number_of_student = db.students.Max(n => n.code_stud) + 1;
            string surnam = textBox1.Text;
            string s = "";
            for (int i = 0; i < surnam.Length; i++)
            {
                if ((surnam[i] != '.') && (surnam[i] != ',') && (surnam[i] != ' ') && (surnam[i] != ';'))
                    s += surnam[i];
            }
            surnam = s;
            string nam = textBox2.Text;
            string n2 = "";
            for (int i = 0; i < nam.Length; i++)
            {
                if ((nam[i] != '.') && (nam[i] != ',') && (nam[i] != ' ') && (nam[i] != ';'))
                    n2 += surnam[i];
            }
            nam = n2;
            students new_student = new students { code_stud = number_of_student, surname = surnam, name = nam, code_group = query[0] };
            db.students.Add(new_student);
            db.SaveChanges();
            ((Form1)Owner).studentsheet = ((Form1)Owner).db.students.OrderBy(o => o.code_stud).ToList();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
