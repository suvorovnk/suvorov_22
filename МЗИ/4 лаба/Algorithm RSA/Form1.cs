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
        public List<BigInteger> FindBigE(BigInteger m)//метод,позволяющий сделать большое e взаимное простое к m
        {
            List<BigInteger> e_values = new List<BigInteger>();
            for (BigInteger i = 3; i<m; i++)
            {
                if (DoubleSimple(i, m) == true) e_values.Add(i);
            }
            return e_values;
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
        public BigInteger GCD(BigInteger a,BigInteger b)//метод определения НОД с вычитанием
        {
            if (a == 0) return b;
            else
            {
                while (b!=0)
                {
                    if (a > b) a -= b;
                    else b -= a;
                }
                return a;
            }
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

        private void button1_Click(object sender, EventArgs e)//зашифровка текста с большим d
        {
            try
            {


                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                if (BigInteger.Parse(textBox1.Text) == BigInteger.Parse(textBox2.Text)) MessageBox.Show("p и q равны! Введите другие значения!");
                else
                {
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
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }
        private void button2_Click(object sender, EventArgs e)//расшифровка текста
        {

            if ((textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                textBox7.Text = "";
                if (radioButton6.Checked)//метод факторизации Ферма
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
                    textBox7.Text = result;
                    textBox9.Text = p.ToString();
                    textBox8.Text = q.ToString();
                    textBox13.Text = d.ToString();
                    textBox11.Text = E.ToString();
                    textBox12.Text = n.ToString();
                }
                if (radioButton5.Checked)//атака Винера
                {
                    BigInteger d_key = BigInteger.Parse(textBox4.Text);
                    BigInteger n_key = BigInteger.Parse(textBox5.Text);
                    n_key = (BigInteger)(((double)1) / ((double)3) * Math.Pow((int)n_key, 0.25));
                    if (d_key < n_key)
                    {
                        BigInteger E = BigInteger.Parse(textBox10.Text);
                        BigInteger n = BigInteger.Parse(textBox5.Text);
                        List<BigInteger> a = new List<BigInteger>();
                        BigInteger chislitel = new BigInteger();
                        chislitel = E;
                        BigInteger znamenatel = new BigInteger();
                        znamenatel = n;
                        BigInteger a0 = new BigInteger();
                        a0 = (BigInteger)Math.Floor((decimal)chislitel / (decimal)znamenatel);
                        a.Add(a0);
                        znamenatel = chislitel - a0 * znamenatel;
                        chislitel = n;
                        do
                        {
                            a0 = (BigInteger)Math.Floor((decimal)chislitel / (decimal)znamenatel);
                            a.Add(a0);
                            BigInteger temp = new BigInteger();
                            temp = znamenatel;
                            znamenatel = chislitel - a0 * znamenatel;
                            chislitel = temp;
                        }
                        while (znamenatel != 0);
                        List<BigInteger> kn = new List<BigInteger>();
                        List<BigInteger> dn = new List<BigInteger>();
                        kn.Add(1);
                        dn.Add(0);
                        kn.Add(a[0]);
                        dn.Add(1);
                        for (int i = 1; i < a.Count; i++)
                        {
                            kn.Add(a[i] * kn[i] + kn[i - 1]);
                            dn.Add(a[i] * dn[i] + dn[i - 1]);
                        }
                        BigInteger p = new BigInteger();
                        BigInteger q = new BigInteger();
                        BigInteger d = new BigInteger();
                        for (int i = 1; i < kn.Count; i++)
                        {
                            if (kn[i] != 0)
                            {
                                double fn = (double)(E * dn[i] - 1) / (double)kn[i];
                                double Discriminant = Math.Pow((double)n - fn + 1, 2) - 4 * (double)n;
                                double x1 = ((double)n - fn + 1 + Math.Sqrt(Discriminant)) / 2;
                                double x2 = ((double)n - fn + 1 - Math.Sqrt(Discriminant)) / 2;
                                if (((BigInteger)(x1 * x2) == n) && (x1 > 0) && (x2 > 0))
                                {
                                    p = (BigInteger)x1;
                                    q = (BigInteger)x2;
                                    d = dn[i];
                                    break;
                                }
                            }
                        }
                        textBox9.Text = p.ToString();
                        textBox8.Text = q.ToString();
                        textBox13.Text = d.ToString();
                        textBox11.Text = E.ToString();
                        textBox12.Text = n.ToString();
                        string[] text = textBox6.Text.Split(' ');
                        string result = "";
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
                        textBox7.Text = result;

                    }
                    else MessageBox.Show("Не выполняется условие выполнения атаки Винера! Введите другие p и q");
                }
                if (radioButton7.Checked)//метод ро-полларда
                {
                    BigInteger n = BigInteger.Parse(textBox5.Text);
                    Random r = new Random();
                    List<BigInteger> x = new List<BigInteger>();
                    x.Add(r.Next((int)n));
                    BigInteger p = new BigInteger();
                    for (int i = 1; i < n; i++)
                    {
                        x.Add((int)(Math.Pow((int)x[i - 1], 2) + 1) % n);
                    }
                    for (int i = 1; i < n; i++)
                    {
                        int j = i / 2;
                        BigInteger module = new BigInteger();
                        if (x[i] > x[j]) module = x[i] - x[j];
                        else module = x[j] - x[i];
                        p = GCD(n, module);
                        if ((p > 1)&&(p<n)) break;
                    }
                    BigInteger q = n / p;
                    BigInteger m = (p - 1) * (q - 1);
                    BigInteger E = FindE(m);
                    BigInteger d = FindD(E, m);
                    string[] text = textBox6.Text.Split(' ');
                    string result = "";
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
                    textBox7.Text = result;
                    textBox9.Text = p.ToString();
                    textBox8.Text = q.ToString();
                    textBox13.Text = d.ToString();
                    textBox11.Text = E.ToString();
                    textBox12.Text = n.ToString();
                }
            }
            else MessageBox.Show("Заполните поля с секретными ключами и исходным текстом!");
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
            textBox13.Text = "";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            max_pq.ReadOnly = false;
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            max_pq.Text = 100.ToString();
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
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
            progressBar1.Maximum = (int)maximum;
            for (BigInteger i=3;i<=maximum;i++)
            {
                progressBar1.Value = (int)i;
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
            if (radioButton2.Checked)
            {
                if (int.Parse(max_pq.Text) >= 7)//&&(textBox1.Text=="")&&(textBox2.Text ==""))
                {
                    progressBar1.Visible = true;
                    List<BigInteger> p_q_values = new List<BigInteger>();
                    p_q_values = Generatepq(BigInteger.Parse(max_pq.Text));
                    max_pq.ReadOnly = true;
                    Random r = new Random();
                    BigInteger p = p_q_values[r.Next(0, p_q_values.Count() - 1)];
                    BigInteger q = p_q_values[r.Next(0, p_q_values.Count() - 1)];
                    while (p == q)
                    {
                        q = p_q_values[r.Next(0, p_q_values.Count() - 1)];
                    }
                    if (q == p)
                    {
                        MessageBox.Show("p и q равны! Выберите максимальное число больше");
                       
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        textBox1.Text = p.ToString();
                        textBox2.Text = q.ToString();
                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                    }
                }
                else
                {
                    MessageBox.Show("Введите максимальное число больше!");
                    radioButton1.Checked = true;
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//выбор ручного режима ввода p и q
        {
            if (radioButton1.Checked)
            {
                progressBar1.Visible = false;
                max_pq.ReadOnly = false;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox1.Text = "";
                textBox2.Text = "";
                progressBar1.Value = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//загрузка из файла
        {
            if (radioButton3.Checked)
            {
                textBox3.Text = ReadFromFile();
                textBox3.ReadOnly = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//выбор ручного режима ввода текста
        {
            if (radioButton4.Checked)
            {
                textBox3.ReadOnly = false;
                textBox3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)//зашифровка текста с большим e
        {
            try
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
                        List<BigInteger> e_values = new List<BigInteger>();
                        e_values = FindBigE(m);
                        List<BigInteger> d_values = new List<BigInteger>();
                        for (int i = 0; i < e_values.Count; i++)
                        {
                            d_values.Add(FindD(e_values[i], m));
                        }
                        BigInteger d = d_values.Min();
                        BigInteger E = 0;
                        for (int i = 0; i < d_values.Count; i++)
                        {
                            if (d_values[i] == d) E = e_values[i];
                        }
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
            catch(System.FormatException)
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

    }
}
