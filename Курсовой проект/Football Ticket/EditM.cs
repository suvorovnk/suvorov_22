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
    public partial class EditM : Form
    {
        public EditM(int t_i,string tp,DateTime date1)
        {
            InitializeComponent();
            this.t = t_i;
            this.tp = tp;
            this.date = date1;
        }
        public int t;
        public string tp;
        public DateTime date;
        private void EditM_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            List<string> ts = op.List_team();
            foreach (string it in ts)
            {
                comboBox1.Items.Add(it);
            }
            comboBox1.SelectedIndex = t-2;
            comboBox2.SelectedItem = tp;
            dateTimePicker1.Value = date;
            numericUpDown1.Value = (decimal)date.Hour;
            numericUpDown2.Value = (decimal)date.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            DateTime date = dateTimePicker1.Value.Date;
            DateTime date2 = date.AddHours((double)numericUpDown1.Value);
            DateTime date3 = date2.AddMinutes((double)numericUpDown2.Value);
            op.EditMatch(comboBox1.SelectedIndex+2,comboBox2.SelectedItem.ToString(),date3);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
