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
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                EditM em = new EditM(int.Parse(op.ChooseMatch(dataGridView1)[0]), op.ChooseMatch(dataGridView1)[1], DateTime.Parse(op.ChooseMatch(dataGridView1)[2]));
                em.Show();
            }
            else MessageBox.Show("Выберите один столбец строки, которую хотите редактировать");
        }

        private void ShowMatches_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBOperator d = new DBOperator();
            d.Show();
        }
    }
}
