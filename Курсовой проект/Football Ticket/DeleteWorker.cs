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
    public partial class DeleteWorker : Form
    {
        public DeleteWorker(string s,string n,string p,string r)
        {
            InitializeComponent();
            this.s = s;
            this.n = n;
            this.p = p;
            this.r = r;
        }
        public string s;
        public string n;
        public string p;
        public string r;

        private void DeleteWorker_Load(object sender, EventArgs e)
        {
            label1.Text += s + " " + n + " " + p + " с должностью " + r+"?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.DeleteW();
            this.Close();
        }
    }
}
