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
    public partial class EstimateEdit : Form
    {
        public demoEntities db = new demoEntities();
        progress item;
        public EstimateEdit(progress prog)
        {
            item = prog;
            InitializeComponent();
            numericUpDown1.Value = (int)prog.estimate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Performance)Owner).db.progress.SingleOrDefault(w=>(w.code_stud == item.code_stud) &&(w.code_subject==item.code_subject)&&(w.code_lector==item.code_lector)&&(w.date_exam==item.date_exam));
            int? est=(int?)numericUpDown1.Value;
            result.estimate = est;
            ((Performance)Owner).db.SaveChanges();
            ((Performance)Owner).progress_sheet = ((Performance)Owner).db.progress.OrderBy(o => o.code_stud).ToList();
            this.Close();
        }
    }
}
