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
    public partial class DBOperator : Form
    {
        public DBOperator()
        {
            InitializeComponent();
        }

        private void DBOperator_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            label1.Text = op.HelloMessage();
            monthCalendar1.TodayDate = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorizecs a = new Authorizecs();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowMatches sm = new ShowMatches();
            sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowTeams s = new ShowTeams();
            s.Show();
        }
    }
}
