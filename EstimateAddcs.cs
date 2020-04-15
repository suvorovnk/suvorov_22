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
    public partial class EstimateAddcs : Form
    {
        public demoEntities db = new demoEntities();
        public List<progress> progress_sheet;
        public EstimateAddcs()
        {
            InitializeComponent();
            var cod_s = (from g in db.students orderby g.code_stud select g.code_stud).Distinct();
            foreach (int it in cod_s)
            {
                comboBox1.Items.Add(it);
            }
            var cod_p = (from g in db.subjects orderby g.code_subject select g.code_subject).Distinct();
            foreach (int it in cod_p)
            {
                comboBox2.Items.Add(it);
            }
            var cod_l = (from g in db.lectors orderby g.code_lector select g.code_lector).Distinct();
            foreach (int it in cod_l)
            {
                comboBox3.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cs = int.Parse(comboBox1.SelectedItem.ToString());
            int c_sub = int.Parse(comboBox2.SelectedItem.ToString());
            DateTime date_of = DateTime.Parse(textBox1.Text);
            int c_l= int.Parse(comboBox3.SelectedItem.ToString());
            int? est = (int?)numericUpDown1.Value;
            progress new_progress = new progress{ code_stud = cs, code_subject=c_sub,code_lector=c_l,date_exam=date_of,estimate=est};
            ((Performance)Owner).db.progress.Add(new_progress);
            ((Performance)Owner).db.SaveChanges();
            ((Performance)Owner).progress_sheet = ((Performance)Owner).db.progress.OrderBy(o => o.code_stud).ToList();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
