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
        public Mesta(int kom,int sk)
        {
            InitializeComponent();
            this.kom = kom;
            this.sk = sk;
        }
        public int kom;
        public int sk;
        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk,1,1,"обычный",false,1));
            button1.BackColor = Color.Black;
            button1.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 2, "обычный", false, 1));
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 3, "обычный", false, 1));
            button3.BackColor = Color.Black;
            button3.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 4, "обычный", false, 1));
            button4.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button4.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 5, "обычный", false, 1));
            button5.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button5.BackColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 6, "обычный", false, 1));
            button6.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button6.BackColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 7, "обычный", false, 1));
            button7.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button7.BackColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 1, 8, "обычный", false, 1));
            button8.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button8.BackColor = Color.Black;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 1, "обычный", false, 1));
            button9.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button9.BackColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 2, "обычный", false, 1));
            button10.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button10.BackColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 3, "обычный", false, 1));
            button11.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button11.BackColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 4, "обычный", false, 1));
            button12.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button12.BackColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 5, "обычный", false, 1));
            button13.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button13.BackColor = Color.Black;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 6, "обычный", false, 1));
            button14.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button14.BackColor = Color.Black;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 2, 7, "обычный", false, 1));
            button15.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button15.BackColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk,2, 8, "обычный", false, 1));
            button16.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button16.BackColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 1, "обычный", false, 1));
            button17.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button17.BackColor = Color.Black;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 2, "обычный", false, 1));
            button18.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button18.BackColor = Color.Black;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 3, "обычный", false, 1));
            button19.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button19.BackColor = Color.Black;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 4, "обычный", false, 1));
            button20.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button20.BackColor = Color.Black;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 5, "обычный", false, 1));
            button21.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button21.BackColor = Color.Black;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 6, "обычный", false, 1));
            button22.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button22.BackColor = Color.Black;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 7, "обычный", false, 1));
            button23.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button23.BackColor = Color.Black;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 3, 8, "обычный", false, 1));
            button24.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button24.BackColor = Color.Black;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 1, "обычный", false, 1));
            button25.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button25.BackColor = Color.Black;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 2, "обычный", false, 1));
            button26.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button26.BackColor = Color.Black;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 3, "обычный", false, 1));
            button27.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button27.BackColor = Color.Black;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 4, "обычный", false, 1));
            button28.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button28.BackColor = Color.Black;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 5, "обычный", false, 1));
            button29.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button29.BackColor = Color.Black;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 6, "обычный", false, 1));
            button30.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button30.BackColor = Color.Black;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 7, "обычный", false, 1));
            button31.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button31.BackColor = Color.Black;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 4, 8, "обычный", false, 1));
            button32.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button32.BackColor = Color.Black;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 1, "обычный", false, 1));
            button33.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button33.BackColor = Color.Black;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 2, "обычный", false, 1));
            button34.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button34.BackColor = Color.Black;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 3, "обычный", false, 1));
            button35.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button35.BackColor = Color.Black;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 4, "обычный", false, 1));
            button36.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button36.BackColor = Color.Black;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 5, "обычный", false, 1));
            button37.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button37.BackColor = Color.Black;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 6, "обычный", false, 1));
            button38.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button38.BackColor = Color.Black;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 7, "обычный", false, 1));
            button39.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button39.BackColor = Color.Black;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 5, 8, "обычный", false, 1));
            button40.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button40.BackColor = Color.Black;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 1, "VIP", false, 1));
            button41.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button41.BackColor = Color.Black;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 2, "VIP", false, 1));
            button42.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button42.BackColor = Color.Black;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 3, "VIP", false, 1));
            button43.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button43.BackColor = Color.Black;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 4, "VIP", false, 1));
            button44.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button44.BackColor = Color.Black;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 5, "VIP", false, 1));
            button45.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button45.BackColor = Color.Black;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 6, "VIP", false, 1));
            button46.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button46.BackColor = Color.Black;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 7, "VIP", false, 1));
            button47.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button47.BackColor = Color.Black;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            MessageBox.Show(op.BuyTicket(kom,sk, 6, 8, "VIP", false, 1));
            button48.Enabled = false;
            ChooseD cd = new ChooseD();
            cd.Show();
            button48.BackColor = Color.Black;
        }

        private void Mesta_Load(object sender, EventArgs e)
        {
            Options op = new Options();
            
            Form1 f = new Form1();
            if (op.CheckPlace(kom, sk, 1, 1) == true)
            {
                button1.BackColor = Color.Black;
                button1.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 2) == true)
            {
                button2.BackColor = Color.Black;
                button2.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 3) == true)
            {
                button3.BackColor = Color.Black;
                button3.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 4) == true)
            {
                button4.BackColor = Color.Black;
                button4.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 5) == true)
            {
                button5.BackColor = Color.Black;
                button5.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 6) == true)
            {
                button6.BackColor = Color.Black;
                button6.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 7) == true)
            {
                button7.BackColor = Color.Black;
                button7.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 1, 8) == true)
            {
                button8.BackColor = Color.Black;
                button8.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 1) == true)
            {
                button9.BackColor = Color.Black;
                button9.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 2) == true)
            {
                button10.BackColor = Color.Black;
                button10.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 3) == true)
            {
                button11.BackColor = Color.Black;
                button11.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 4) == true)
            {
                button12.BackColor = Color.Black;
                button12.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 5) == true)
            {
                button13.BackColor = Color.Black;
                button13.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 6) == true)
            {
                button14.BackColor = Color.Black;
                button14.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 7) == true)
            {
                button15.BackColor = Color.Black;
                button15.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 2, 8) == true)
            {
                button16.BackColor = Color.Black;
                button16.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 1) == true)
            {
                button17.BackColor = Color.Black;
                button17.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 2) == true)
            {
                button18.BackColor = Color.Black;
                button18.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 3) == true)
            {
                button19.BackColor = Color.Black;
                button19.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 4) == true)
            {
                button20.BackColor = Color.Black;
                button20.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 5) == true)
            {
                button21.BackColor = Color.Black;
                button21.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 6) == true)
            {
                button22.BackColor = Color.Black;
                button22.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 7) == true)
            {
                button23.BackColor = Color.Black;
                button23.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 3, 8) == true)
            {
                button24.BackColor = Color.Black;
                button24.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 1) == true)
            {
                button25.BackColor = Color.Black;
                button25.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 2) == true)
            {
                button26.BackColor = Color.Black;
                button26.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 3) == true)
            {
                button27.BackColor = Color.Black;
                button27.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 4) == true)
            {
                button28.BackColor = Color.Black;
                button28.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 5) == true)
            {
                button29.BackColor = Color.Black;
                button29.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 6) == true)
            {
                button30.BackColor = Color.Black;
                button30.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 7) == true)
            {
                button31.BackColor = Color.Black;
                button31.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 4, 8) == true)
            {
                button32.BackColor = Color.Black;
                button32.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 1) == true)
            {
                button33.BackColor = Color.Black;
                button33.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 2) == true)
            {
                button34.BackColor = Color.Black;
                button34.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 3) == true)
            {
                button35.BackColor = Color.Black;
                button35.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 4) == true)
            {
                button36.BackColor = Color.Black;
                button36.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 5) == true)
            {
                button37.BackColor = Color.Black;
                button37.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 6) == true)
            {
                button38.BackColor = Color.Black;
                button38.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 7) == true)
            {
                button39.BackColor = Color.Black;
                button39.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 5, 8) == true)
            {
                button40.BackColor = Color.Black;
                button40.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 1) == true)
            {
                button41.BackColor = Color.Black;
                button41.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 2) == true)
            {
                button42.BackColor = Color.Black;
                button42.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 3) == true)
            {
                button43.BackColor = Color.Black;
                button43.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 4) == true)
            {
                button44.BackColor = Color.Black;
                button44.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 5) == true)
            {
                button45.BackColor = Color.Black;
                button45.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 6) == true)
            {
                button46.BackColor = Color.Black;
                button46.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 7) == true)
            {
                button47.BackColor = Color.Black;
                button47.Enabled = false;
            }
            if (op.CheckPlace(kom, sk, 6, 8) == true)
            {
                button48.BackColor = Color.Black;
                button48.Enabled = false;
            }
        }
    }
}
