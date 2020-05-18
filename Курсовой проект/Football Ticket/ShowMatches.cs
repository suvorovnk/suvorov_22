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
    public partial class ShowMatches : Form
    {
        public ShowMatches()
        {
            InitializeComponent();
        }

        private void ShowMatches_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowMatches(dataGridView1);
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddM am = new AddM();
            am.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowMatches(dataGridView1);
        }
    }
}
