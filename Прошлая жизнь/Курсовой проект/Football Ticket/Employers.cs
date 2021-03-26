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
    public partial class Employers : Form
    {
        public Employers()
        {
            InitializeComponent();
        }

        private void Employers_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowWorkers(dataGridView1);
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.ShowWorkers(dataGridView1);
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddW aw = new AddW();
            aw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                EditW ew = new EditW(op.ChooseWorker(dataGridView1)[0], op.ChooseWorker(dataGridView1)[1], op.ChooseWorker(dataGridView1)[2], op.ChooseWorker(dataGridView1)[3], op.ChooseWorker(dataGridView1)[4], op.ChooseWorker(dataGridView1)[5]);
                ew.Show();
            }
            else MessageBox.Show("Выберите один столбец строки, которую хотите редактировать");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                DeleteWorker dw = new DeleteWorker(op.ChooseWorker2(dataGridView1)[0], op.ChooseWorker2(dataGridView1)[1], op.ChooseWorker2(dataGridView1)[2], op.ChooseWorker2(dataGridView1)[3]);
                dw.Show();
            }
            else MessageBox.Show("Выберите один столбец строки, которую хотите редактировать");
        }

        private void Employers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }
    }
}
