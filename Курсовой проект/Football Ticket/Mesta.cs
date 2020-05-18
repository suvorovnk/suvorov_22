using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Ticket
{
    public partial class Mesta : Form
    {
        public Mesta()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector,1,1,"обычный",false,1));
            this.Close();
            button1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 1, 2, "обычный", false, 1));
            this.Close();
            button2.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 1, 3, "обычный", false, 1));
            this.Close();
            button3.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 1, 4, "обычный", false, 1));
            this.Close();
            button4.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 1, 5, "обычный", false, 1));
            this.Close();
            button5.BackColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 1, 6, "обычный", false, 1));
            this.Close();
            button6.BackColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 1, 7, "обычный", false, 1));
            this.Close();
            button7.BackColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 1, 8, "обычный", false, 1));
            this.Close();
            button8.BackColor = Color.Black;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 1, "обычный", false, 1));
            this.Close();
            button9.BackColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 2, "обычный", false, 1));
            this.Close();
            button10.BackColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 3, "обычный", false, 1));
            this.Close();
            button11.BackColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 4, "обычный", false, 1));
            this.Close();
            button12.BackColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 5, "обычный", false, 1));
            this.Close();
            button13.BackColor = Color.Black;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 6, "обычный", false, 1));
            this.Close();
            button14.BackColor = Color.Black;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 2, 7, "обычный", false, 1));
            this.Close();
            button15.BackColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector,2, 8, "обычный", false, 1));
            this.Close();
            button16.BackColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 3, 1, "обычный", false, 1));
            this.Close();
            button17.BackColor = Color.Black;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 3, 2, "обычный", false, 1));
            this.Close();
            button18.BackColor = Color.Black;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 3, 3, "обычный", false, 1));
            this.Close();
            button19.BackColor = Color.Black;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 3, 4, "обычный", false, 1));
            this.Close();
            button20.BackColor = Color.Black;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 3, 5, "обычный", false, 1));
            this.Close();
            button21.BackColor = Color.Black;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 3, 6, "обычный", false, 1));
            this.Close();
            button22.BackColor = Color.Black;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 3, 7, "обычный", false, 1));
            this.Close();
            button23.BackColor = Color.Black;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 3, 8, "обычный", false, 1));
            this.Close();
            button24.BackColor = Color.Black;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 1, "обычный", false, 1));
            this.Close();
            button25.BackColor = Color.Black;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 2, "обычный", false, 1));
            this.Close();
            button26.BackColor = Color.Black;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 4, 3, "обычный", false, 1));
            this.Close();
            button27.BackColor = Color.Black;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 4, "обычный", false, 1));
            this.Close();
            button28.BackColor = Color.Black;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 5, "обычный", false, 1));
            this.Close();
            button29.BackColor = Color.Black;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 4, 6, "обычный", false, 1));
            this.Close();
            button30.BackColor = Color.Black;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 7, "обычный", false, 1));
            this.Close();
            button31.BackColor = Color.Black;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 4, 8, "обычный", false, 1));
            this.Close();
            button32.BackColor = Color.Black;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 1, "обычный", false, 1));
            this.Close();
            button33.BackColor = Color.Black;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 2, "обычный", false, 1));
            this.Close();
            button34.BackColor = Color.Black;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 3, "обычный", false, 1));
            this.Close();
            button35.BackColor = Color.Black;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 4, "обычный", false, 1));
            this.Close();
            button36.BackColor = Color.Black;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 5, 5, "обычный", false, 1));
            this.Close();
            button37.BackColor = Color.Black;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 6, "обычный", false, 1));
            this.Close();
            button38.BackColor = Color.Black;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 5, 7, "обычный", false, 1));
            this.Close();
            button39.BackColor = Color.Black;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 5, 8, "обычный", false, 1));
            this.Close();
            button40.BackColor = Color.Black;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 6, 1, "VIP", false, 1));
            this.Close();
            button41.BackColor = Color.Black;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 6, 2, "VIP", false, 1));
            this.Close();
            button42.BackColor = Color.Black;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 6, 3, "VIP", false, 1));
            this.Close();
            button43.BackColor = Color.Black;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 6, 4, "VIP", false, 1));
            this.Close();
            button44.BackColor = Color.Black;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 6, 5, "VIP", false, 1));
            this.Close();
            button45.BackColor = Color.Black;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 6, 6, "VIP", false, 1));
            this.Close();
            button46.BackColor = Color.Black;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket( s.ChSector, 6, 7, "VIP", false, 1));
            this.Close();
            button47.BackColor = Color.Black;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(s.ChSector, 6, 8, "VIP", false, 1));
            this.Close();
            button48.BackColor = Color.Black;
        }

        private void Mesta_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            Stadium s = new Stadium();
            Form1 f = new Form1();
            op.Kod_matcha(f.kod_of_match);
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 1) == true) button1.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 2) == true) button2.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 3) == true) button3.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 4) == true) button4.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 5) == true) button5.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 6) == true) button6.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 7) == true) button7.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 1, 8) == true) button8.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 1) == true) button9.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 2) == true) button10.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 3) == true) button11.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 4) == true) button12.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 5) == true) button13.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 6) == true) button14.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 7) == true) button15.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 2, 8) == true) button16.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 1) == true) button17.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 2) == true) button18.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 3) == true) button19.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 4) == true) button20.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 5) == true) button21.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 6) == true) button22.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 7) == true) button23.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 3, 8) == true) button24.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 1) == true) button25.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 2) == true) button26.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 3) == true) button27.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 4) == true) button28.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 5) == true) button29.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 6) == true) button30.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 7) == true) button31.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 4, 8) == true) button32.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 1) == true) button33.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 2) == true) button34.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 3) == true) button35.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 4) == true) button36.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 5) == true) button37.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 6) == true) button38.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 7) == true) button39.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 5, 8) == true) button40.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 1) == true) button41.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 2) == true) button42.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 3) == true) button43.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 4) == true) button44.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 5) == true) button45.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 6) == true) button46.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 7) == true) button47.BackColor = Color.Black;
            if (op.CheckPlace(op.id_match, s.ChSector, 6, 8) == true) button48.BackColor = Color.Black;
        }
    }
}
