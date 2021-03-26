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
    public partial class AddM : Form
    {
        public AddM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            DateTime date = dateTimePicker1.Value.Date;
            DateTime date2=date.AddHours((double)numericUpDown1.Value);
            DateTime date3=date2.AddMinutes((double)numericUpDown2.Value);
            op.AddMatch(comboBox1.SelectedIndex+2,comboBox2.SelectedItem.ToString(),date3);
            this.Close();
        }

        private void AddM_Load(object sender, EventArgs e)
        {
            DateTime date=DateTime.Now;
            DateTime date2 = date.AddDays(1);
            dateTimePicker1.MinDate = date2;
            Options op = new Options();
            List<string> t = op.List_team();
            foreach (string it in t)
            {
                comboBox1.Items.Add(it);
            }
        }
    }
}
