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
    public partial class ShowTeams : Form
    {
        public ShowTeams()
        {
            InitializeComponent();
        }

        private void ShowTeams_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowTeams(dataGridView1);
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddT adt = new AddT();
            adt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowTeams(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ChooseTeam(dataGridView1);
            EditT et = new EditT();
            et.Show();
        }

        private void ShowTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBOperator dbo = new DBOperator();
            dbo.Show();
        }
    }
}
