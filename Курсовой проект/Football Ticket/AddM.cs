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
            
            op.AddMatch(comboBox1.SelectedIndex+1,comboBox2.SelectedItem.ToString(),DateTime.Now);
            this.Close();
        }

        private void AddM_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            List<string> t = op.List_team();
            foreach (string it in t)
            {
                comboBox1.Items.Add(it);
            }
            numericUpDown3.Value = DateTime.Now.Day;
            
        }
    }
}
