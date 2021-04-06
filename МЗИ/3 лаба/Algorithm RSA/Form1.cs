using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ZedGraph;

namespace Algorithm_RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static bool MillerRabin(BigInteger value, int k)//тест Миллера-Рабина на простоту
        {
            if (value == 2 || value == 3)//если число 2 или 3, то простое
                return true;
            if (value < 2 || value % 2 == 0)//если число меньше двух или четное, то составное
                return false;
            BigInteger t = value - 1; //представим value − 1 в виде(2 ^ s)·t, где t нечётно
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (int i = 0; i < k; i++)//цикл фиксированного количества раз, задаваемого при вызове метода
            {
                //выберем случайное целое число a в отрезке[2, value − 2]
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] _a = new byte[value.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= value - 2);
                BigInteger x = BigInteger.ModPow(a, t, value);//x ← a^t mod value, вычислим с помощью возведения в степень по модулю
                if (x == 1 || x == value - 1)//если x == 1 или x == value − 1, то перейти на следующую итерацию цикла
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, value);//x ← x^2 mod value
                    if (x == 1)//если x == 1, то составное
                        return false;
                    if (x == value - 1)//если x == value − 1, то перейти на следующую итерацию внешнего цикла
                        break;
                }
                if (x != value - 1)
                    return false;
            }
            return true;
        }
        static public char[] alphabet = new char[] {'-','-','А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И','Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С','Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','0','1', '2', '3', '4', '5', '6', '7',
                                                '8', '9'};//массив из алфавита
        public BigInteger FindE(BigInteger m)//метод,позволяющий сделать e взаимно простым к m
        {
            BigInteger i;
            for (i = 3; i < m; i++)
            {
                if (DoubleSimple(i, m) == true) break;
            }
            return i;
        }
        public bool DoubleSimple(BigInteger d, BigInteger c)//метод, определяющий взаимную простоту двух чисел алгоритмом Евклида
        {
            while ((d != 0) && (c != 0))
            {
                if (d > c)
                {
                    d = d % c;
                }
                else
                {
                    c = c % d;
                }
            }
            if ((c + d) != 1) return false;
            else return true;
        }
        private BigInteger FindD(BigInteger e, BigInteger m)//метод, находящий параметр d
        {
            BigInteger d = 2;
            while (d < m)
            {
                if ((d * e) % m == 1) break;
                else d++;
            }

            return d;
        }

        private void button1_Click(object sender, EventArgs e)//зашифровка текста
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                BigInteger p = BigInteger.Parse(textBox1.Text);
                BigInteger q = BigInteger.Parse(textBox2.Text);
                if ((MillerRabin(p, 10) == true) && (MillerRabin(q, 10) == true))
                {
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    max_pq.ReadOnly = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    string text = TextProcessing(textBox3.Text);
                    textBox3.Text = text;
                    char[] MyChar = { ',', ' ', '/', '?', '!', '.', ':', ';', '@', '#', '№', '$', '%', '^', '*', '(', ')', '-', '_', '=', '+' };
                    string[] text2 = text.Split(MyChar);
                    string text3 = "";
                    for (int i = 0; i < text2.Length; i++)
                    {
                        text3 += text2[i];
                    }
                    text = text3.ToUpper();
                    textBox3.Text = text;
                    BigInteger n = p * q;
                    BigInteger m = (p - 1) * (q - 1);
                    BigInteger E = FindE(m);
                    BigInteger d = FindD(E, m);
                    string output_text = "";
                    BigInteger text_bi;
                    for (int i = 0; i < text.Length; i++)
                    {
                        int ind = Array.IndexOf(alphabet, text[i]);
                        text_bi = new BigInteger(ind);
                        BigInteger t2 = text_bi;
                        for (BigInteger j = 1; j < E; j++)
                        {
                            t2 = t2 * text_bi;
                        }
                        BigInteger t3 = t2 % n;
                        if (i != text.Length - 1)
                        {
                            output_text += t3 + " ";
                        }
                        else output_text += t3;
                    }
                    textBox4.Text = d.ToString();
                    textBox5.Text = n.ToString();
                    textBox6.Text = output_text;
                    textBox10.Text = E.ToString();
                }
                else MessageBox.Show("Числа не простые! Введите простые числа!");
            }
            else MessageBox.Show("Заполните поля с простыми числами и исходным текстом!");
        }
        private void button2_Click(object sender, EventArgs e)//расшифровка текста
        {
            
            if ((textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                textBox7.Text = "";
                if (radioButton6.Checked)
                {
                    BigInteger n = BigInteger.Parse(textBox5.Text);
                    string[] text = textBox6.Text.Split(' ');
                    string result = "";
                    BigInteger x = (BigInteger)Math.Sqrt((double)n);
                    int k = 1;
                    bool stop = false;
                    BigInteger y, y_2;
                    do
                    {
                        x = (BigInteger)Math.Sqrt((double)n);
                        x += k;
                        y_2 = (BigInteger)Math.Pow((double)x, 2) - n;
                        for (BigInteger i = 1; i <= (BigInteger)Math.Sqrt((double)y_2) + 1; i++)
                        {
                            if (y_2 == (BigInteger)Math.Pow((double)i, 2))
                            {
                                stop = true;
                                break;
                            }
                        }
                        if (stop == false) k++;
                    }
                    while (stop == false);
                    y = (BigInteger)Math.Sqrt((double)y_2);
                    BigInteger p = x - y;
                    BigInteger q = x + y;
                    BigInteger m = (p - 1) * (q - 1);
                    BigInteger E = FindE(m);
                    BigInteger d = FindD(E, m);
                    foreach (string word in text)
                    {
                        BigInteger text_bi;
                        text_bi = BigInteger.Parse(word);
                        BigInteger t2 = text_bi;
                        for (BigInteger i = 1; i < d; i++)
                        {
                            t2 = t2 * text_bi;
                        }
                        BigInteger t3 = t2 % n;
                        int index = (int)t3;
                        result += alphabet[index];
                    }
                    textBox7.Text += result;
                    textBox9.Text = p.ToString();
                    textBox8.Text = q.ToString();
                    textBox10.Text += p.ToString() + Environment.NewLine;
                    textBox11.Text += q.ToString() + Environment.NewLine;
                }
                if (radioButton5.Checked)
                {

                }
            }
            else
                MessageBox.Show("Заполните поля с секретными ключами и исходным текстом!");
        }
        
        
        private void button3_Click(object sender, EventArgs e)//очистка всех полей и массивов
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            max_pq.ReadOnly = false;
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)//метод загрузки формы
        {
            radioButton4.Checked = true;
            max_pq.Text = 100.ToString();
            radioButton1.Checked = true;
        }
        public List<BigInteger> Generatepq(BigInteger maximum)
        {
            List<BigInteger> p_q_values = new List<BigInteger>();
            for (BigInteger i=3;i<maximum;i++)
            {
                if (MillerRabin(i, 10) == true)
                    p_q_values.Add(i);
            }
            return p_q_values;
        }
        public string ReadFromFile()//метод чтения из файла
        {
            string[] text = File.ReadAllLines("input.txt");
            string t = "";
            for (int i = 0; i < text.Length; i++)
            {
                t += text[i];
            }
            char[] MyChar = { ',', ' ', '/', '?', '!', '.', ':', ';', '@', '#', '№', '$', '%', '^', '*', '(', ')', '-', '_', '=', '+', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] text2 = t.Split(MyChar);
            string text3 = "";
            for (int i = 0; i < text2.Length; i++)
            {
                text3 += text2[i];
            }
            string text4 = text3.ToUpper();
            return text4;
        }
        public string TextProcessing(string t)//метод обработки введенного вручную текста
        {
            char[] MyChar = { ',', ' ', '/', '?', '!', '.', ':', ';', '@', '#', '№', '$', '%', '^', '*', '(', ')', '-', '_', '=', '+', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] text2 = t.Split(MyChar);
            string text3 = "";
            for (int i = 0; i < text2.Length; i++)
            {
                text3 += text2[i];
            }
            string text4 = text3.ToUpper();
            return text4;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)//генерация p и q
        {
            List<BigInteger> p_q_values = new List<BigInteger>();
            p_q_values = Generatepq(BigInteger.Parse(max_pq.Text));
            max_pq.ReadOnly = true;
            Random r = new Random();
            BigInteger p = p_q_values[r.Next(p_q_values.Count())];
            BigInteger q = p_q_values[r.Next(p_q_values.Count())];
            if (p==q) q= p_q_values[Math.Abs(p_q_values.Count()-r.Next(p_q_values.Count()))];
            textBox1.Text = p.ToString();
            textBox2.Text = q.ToString();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//выбор ручного режима ввода p и q
        {
            max_pq.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//загрузка из файла
        {
            textBox3.Text = ReadFromFile();
            textBox3.ReadOnly = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//выбор ручного режима ввода текста
        {
            textBox3.ReadOnly = false;
            textBox3.Text = "";
        }
    }
}
