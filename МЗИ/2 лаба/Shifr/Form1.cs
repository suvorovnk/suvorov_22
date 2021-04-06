using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public List<double> x = new List<double>();
        static public List<string> Keys_1 = new List<string>();
        static public List<string> Keys_2 = new List<string>();
        static public List<string> texts = new List<string>();
        private void button1_Click(object sender, EventArgs e)//зашифровка шифром простой замены
        {
            label6.Text = "Расшифрованный текст";
            textBox6.Text = "";
            if ((textBox1.Text != "") && (textBox3.Text != ""))
            {
                string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                string key = textBox1.Text;
                string text = textBox3.Text;
                string itog = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int number = alfabet.IndexOf(text[i]);
                    itog += key[number];
                }
                textBox4.Text = itog;
            }
            else MessageBox.Show("Введите все данные!");
        }
        public List<string> Encoding_1(string text, string key)//метод расшифровки шифра простой замены
        {
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            double[] massiv_chastot = new double[33] { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.072, 0.007, 0.016, 0.062, 0.01, 0.028, 0.035, 0.026, 0.053, 0.09, 0.023, 0.04, 0.045, 0.053, 0.021, 0.002, 0.009, 0.004, 0.012, 0.006, 0.003, 0.014, 0.016, 0.014, 0.003, 0.006, 0.018 };
            double[] massiv_chastot2 = new double[text.Length];
            string itog = "";
            for (int i = 0; i < text.Length; i++)//расшифровка
            {
                int number = key.IndexOf(text[i]);
                itog += alfabet[number];
            }
            string text2 = itog;
            for (int i = 0; i < text2.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text2[i] == text2[j])
                    {
                        massiv_chastot2[i] += ((double)1) / ((double)text2.Length);
                    }
                }
            }
            double ci, fi;
            double X = 0;
            for (int i = 0; i < text2.Length; i++)
            {
                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (text2[i] == alfabet[j])
                    {
                        ci = massiv_chastot[j];
                        fi = massiv_chastot2[i];
                        X += ci * fi;
                    }
                }
            }
            List<string> info = new List<string>();
            info.Add(X.ToString());
            info.Add(key);
            info.Add(text2);
            return info;
        }

        public List<string> Encoding_2(string text, string key)//метод расшифровки шифра плейфера
        {
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            double[] massiv_chastot = new double[33] { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.072, 0.007, 0.016, 0.062, 0.01, 0.028, 0.035, 0.026, 0.053, 0.09, 0.023, 0.04, 0.045, 0.053, 0.021, 0.002, 0.009, 0.004, 0.012, 0.006, 0.003, 0.014, 0.016, 0.014, 0.003, 0.006, 0.018 };
            string itog = "";
            char[,] matrix = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (6 * i + j < 33)
                    {
                        matrix[i, j] = key[6 * i + j];
                    }
                    else
                    {
                        matrix[i, j] = '-';
                    }
                }
            }
            if (text.Length % 2 != 0)
            {
                text += 'Я';
            }
            
            List<string> text_bigramms = new List<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (text[i] != text[i + 1])
                    {
                        string bigramm = text[i].ToString();
                        bigramm += text[i + 1];
                        text_bigramms.Add(bigramm);
                    }
                    else
                    {
                        string bigramm = text[i].ToString();
                        bigramm += 'Я';
                        text_bigramms.Add(bigramm);
                    }
                }
            }
            List<int> rows = new List<int>();
            List<int> columns = new List<int>();
            for (int i = 0; i < text_bigramms.Count; i++)
            {
                for (int m = 0; m < 6; m++)
                {
                    for (int p = 0; p < 6; p++)
                    {
                        if (text_bigramms[i][0] == matrix[m, p])
                        {
                            rows.Add(m);
                            columns.Add(p);
                        }
                        if (text_bigramms[i][1] == matrix[m, p])
                        {
                            rows.Add(m);
                            columns.Add(p);
                        }
                    }
                }
            }
            char new_char = ' ';
            char new_char_2 = ' ';
            for (int i = 0; i < rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (rows[i] == rows[i + 1])
                    {
                        if (columns[i] + 1 <= 5)
                        {
                            new_char = matrix[rows[i], columns[i] + 1];
                        }
                        else
                        {
                            new_char = matrix[rows[i], 0];
                        }
                        if (columns[i + 1] + 1 <= 5)
                        {
                            new_char_2 = matrix[rows[i + 1], columns[i + 1] + 1];
                        }
                        else
                        {
                            new_char_2 = matrix[rows[i + 1], 0];
                        }
                        if (new_char == '-')
                        {
                            new_char = matrix[rows[i], 0];
                        }
                        if (new_char_2 == '-')
                        {
                            new_char_2 = matrix[rows[i + 1], 0];
                        }
                        itog += new_char;
                        itog += new_char_2;
                    }
                    if (columns[i] == columns[i + 1])
                    {
                        if (rows[i] + 1 < 5)
                        {
                            new_char = matrix[rows[i] + 1, columns[i]];
                        }
                        else
                        {
                            new_char = matrix[0, columns[i]];
                        }
                        if (rows[i + 1] + 1 < 5)
                        {
                            new_char_2 = matrix[rows[i + 1] + 1, columns[i + 1]];
                        }
                        else
                        {
                            new_char_2 = matrix[0, columns[i + 1]];
                        }
                        if (new_char == '-')
                        {
                            new_char = matrix[0, columns[i]];
                        }
                        if (new_char_2 == '-')
                        {
                            new_char_2 = matrix[0, columns[i + 1]];
                        }
                        itog += new_char;
                        itog += new_char_2;
                    }
                    if ((rows[i] != rows[i + 1]) && (columns[i] != columns[i + 1]))
                    {
                        new_char = matrix[rows[i], columns[i + 1]];
                        new_char_2 = matrix[rows[i + 1], columns[i]];
                        if (new_char == '-')
                        {
                            new_char = matrix[0, columns[i + 1]];
                        }
                        if (new_char_2 == '-')
                        {
                            new_char_2 = matrix[0, columns[i]];
                        }
                        itog += new_char;
                        itog += new_char_2;
                    }
                }
            }
            string text2 = itog;
            double[] massiv_chastot2 = new double[text2.Length];
            for (int i = 0; i < text2.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text2[i] == text2[j])
                    {
                        massiv_chastot2[i] += ((double)1) / ((double)text2.Length);
                    }
                }
            }
            double ci, fi;
            double X = 0;
            for (int i = 0; i < text2.Length; i++)
            {
                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (text2[i] == alfabet[j])
                    {
                        ci = massiv_chastot[j];
                        fi = massiv_chastot2[i];
                        X += ci * fi;
                    }
                }
            }
            List<string> info = new List<string>();
            info.Add(X.ToString());
            info.Add(key);
            info.Add(text2);
            return info;
        }
        private void button2_Click(object sender, EventArgs e)//расшифровка шифра простой замены
        {
            label6.Text = "Расшифрованный текст";
            textBox6.Text = "";
            if (textBox4.Text != "")
            {
                string text = textBox4.Text;
                x.Clear();
                Keys_1.Clear();
                texts.Clear();
                int counts = 10000;
                do
                {
                    int limit = 0;
                    string key = GenerateKey();
                    if (Keys_1.Contains(key) != true)
                    {
                        counts--;
                        x.Add(double.Parse(Encoding_1(text, key)[0]));
                        Keys_1.Add(Encoding_1(text, key)[1]);
                        texts.Add(Encoding_1(text, key)[2]);
                        string key_2 = "";
                        double x_1 = -1;
                        double x_2 = -2;
                        do
                        {
                            x_1 = double.Parse(Encoding_1(text, key)[0]);
                            Random r = new Random();
                            int i_1 = r.Next(0, 32);
                            int j_1 = r.Next(0, 32);
                            if (i_1 == j_1)
                            {
                                j_1++;
                                j_1 = j_1 % 33;
                            }
                            List<char> s = new List<char>();
                            for (int i = 0; i < key.Length; i++)
                            {
                                s.Add(key[i]);
                            }
                            char temp = s[i_1];
                            s[i_1] = s[j_1];
                            s[j_1] = temp;
                            for (int i = 0; i < s.Count; i++)
                            {
                                key_2 += s[i];
                            }
                            if (Keys_1.Contains(key_2) != true)
                            {
                                limit++;
                                x_2 = double.Parse(Encoding_1(text, key_2)[0]);
                                if (x_2 > x_1)
                                {
                                    limit = 0;
                                    key = key_2;
                                    x.Add(double.Parse(Encoding_1(text, key)[0]));
                                    Keys_1.Add(Encoding_1(text, key)[1]);
                                    texts.Add(Encoding_1(text, key)[2]);
                                }
                            }
                        }
                        while (limit < 6);
                    }
                }
                while (counts > 0);
                string best_key = "";
                double max = x.Max();
                int i_max = -1;
                for (int i = 0; i < x.Count; i++)
                {
                    if (max == x[i])
                    {
                        i_max = i;
                    }
                }
                best_key = Keys_1[i_max];
                textBox8.Text = best_key;
                textBox6.Text = texts[i_max];
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox6.Text);
            }
            else MessageBox.Show("Введите все данные!");
        }
        private void Form1_Load(object sender, EventArgs e)//загрузка формы, заполнение данных и обработка текста из файла
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
            textBox3.Text = text4;
            textBox1.Text = GenerateKey();
            key2 = GenerateKey();
            for (int i=0;i<6;i++)
            {
                textBox5.Text += key2[i];
            }
        }
        public static string key2 = "";
        public static string GenerateKey()//метод для генерации ключа
        {
            List<char> alfavit = new List<char>();
            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Random r = new Random();
            for (int i = 0; i < alfabet.Length; i++)
            {
                alfavit.Add(alfabet[i]);
            }
            alfavit = alfavit.OrderBy(x => r.Next()).ToList();
            string s = "";
            for (int i = 0; i < alfavit.Count; i++)
            {
                s += alfavit[i];
            }
            return s;
        }
        private void button3_Click(object sender, EventArgs e)//зашифровка шифром плейфера
        {
            label6.Text = "Расшифрованный текст";
            textBox6.Text = "";
            if (textBox5.Text != "")
            {
                char[,] matrix = new char[6, 6];
                for (int i=0;i<6;i++)
                {
                    for (int j=0;j<6;j++)
                    {
                        if (6 * i + j < 33)
                        {
                            matrix[i, j] = key2[6 * i + j];
                        }
                        else
                        {
                            matrix[i, j] = '-';
                        }
                    }
                }
                string text = textBox3.Text;
                if (text.Length%2!=0)
                {
                    text += 'Я';
                }
                string itog = "";
                List<string> text_bigramms = new List<string>();
                for (int i=0;i<text.Length-1;i++)
                {
                    if (i % 2 == 0)
                    {
                        if (text[i] != text[i + 1])
                        {
                            string bigramm = text[i].ToString();
                            bigramm+= text[i + 1];
                            text_bigramms.Add(bigramm);
                        }
                        else
                        {
                            string bigramm = text[i].ToString();
                            bigramm += 'Я';
                            text_bigramms.Add(bigramm);
                        }
                    }
                }
                List<int> rows = new List<int>();
                List<int> columns = new List<int>();
                for (int i=0;i<text_bigramms.Count;i++)
                {
                    for (int m=0;m<6;m++)
                    {
                        for (int p=0;p<6;p++)
                        {
                            if (text_bigramms[i][0]==matrix[m,p])
                            {
                                rows.Add(m);
                                columns.Add(p);
                            }
                            if (text_bigramms[i][1]==matrix[m,p])
                            {
                                rows.Add(m);
                                columns.Add(p);
                            }
                        }
                    }
                }
                char new_char=' ';
                char new_char_2 = ' ';
                for (int i=0;i<rows.Count-1;i++)
                {
                    if (i%2==0)
                    {
                        if (rows[i]==rows[i+1])
                        {
                            if (columns[i] + 1 <= 5)
                            {
                                new_char = matrix[rows[i], columns[i] + 1];
                            }
                            else
                            {
                                new_char = matrix[rows[i], 0];
                            }
                            if (columns[i+1] + 1 <= 5)
                            {
                                new_char_2 = matrix[rows[i + 1], columns[i + 1] + 1];
                            }
                            else
                            {
                                new_char_2 = matrix[rows[i + 1], 0];
                            }
                            if (new_char=='-')
                            {
                                new_char = matrix[rows[i], 0];
                            }
                            if (new_char_2 == '-')
                            {
                                new_char_2 = matrix[rows[i+1], 0];
                            }
                            itog += new_char;
                            itog += new_char_2;
                        }
                        if (columns[i] == columns[i + 1])
                        {
                            if(rows[i]+1<5)
                            { 
                                new_char= matrix[rows[i] + 1, columns[i]];
                            }
                            else 
                            { 
                                new_char = matrix[0, columns[i]];
                            }
                            if (rows[i+1] + 1 < 5)
                            {
                                new_char_2 = matrix[rows[i+1] + 1, columns[i+1]];
                            }
                            else
                            {
                                new_char_2 = matrix[0, columns[i+1]];
                            }
                            if (new_char == '-')
                            {
                                new_char = matrix[0, columns[i]];
                            }
                            if (new_char_2 == '-')
                            {
                                new_char_2 = matrix[0, columns[i+1]];
                            }
                            itog += new_char;
                            itog += new_char_2;
                        }
                        if ((rows[i] != rows[i + 1])&& (columns[i] != columns[i + 1]))
                        {
                            new_char = matrix[rows[i], columns[i + 1]];
                            new_char_2= matrix[rows[i+1], columns[i]];
                            if (new_char == '-')
                            {
                                new_char = matrix[0, columns[i+1]];
                            }
                            if (new_char_2 == '-')
                            {
                                new_char_2 = matrix[0, columns[i]];
                            }
                            itog += new_char;
                            itog += new_char_2;
                        }
                    }
                }
                for (int i=0;i<6;i++)
                {
                    for (int j=0;j<6;j++)
                    {
                        textBox2.Text += matrix[i, j] + " ";
                    }
                    textBox2.Text += Environment.NewLine;
                }
                textBox4.Text = itog;
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox4.Text);
            }
            else MessageBox.Show("Введите все данные!");
        }

        private void button4_Click(object sender, EventArgs e)//расшифровка метода плейфера
        {
            label6.Text = "Расшифрованный текст";
            textBox6.Text = "";
            if (textBox4.Text != "")
            {
                x.Clear();
                Keys_2.Clear();
                texts.Clear();
                string text = textBox4.Text;
                int counts = 20000;
                do
                {
                    int limit = 0;
                    string key = GenerateKey();
                    if (Keys_2.Contains(key) != true)
                    {
                        counts--;
                        x.Add(double.Parse(Encoding_2(text, key)[0]));
                        Keys_2.Add(Encoding_2(text, key)[1]);
                        texts.Add(Encoding_2(text, key)[2]);
                        string key_2 = "";
                        double x_1 = -1;
                        double x_2 = -2;
                        do
                        {
                            x_1 = double.Parse(Encoding_2(text, key)[0]);
                            Random r = new Random();
                            int i_1 = r.Next(0, 32);
                            int j_1 = r.Next(0, 32);
                            if (i_1 == j_1)
                            {
                                j_1++;
                                j_1 = j_1 % 33;
                            }
                            List<char> s = new List<char>();
                            for (int i = 0; i < key.Length; i++)
                            {
                                s.Add(key[i]);
                            }
                            char temp = s[i_1];
                            s[i_1] = s[j_1];
                            s[j_1] = temp;
                            for (int i = 0; i < s.Count; i++)
                            {
                                key_2 += s[i];
                            }
                            if (Keys_2.Contains(key_2) != true)
                            {
                                limit++;
                                x_2 = double.Parse(Encoding_2(text, key_2)[0]);
                                if (x_2 > x_1)
                                {
                                    limit = 0;
                                    key = key_2;
                                    x.Add(double.Parse(Encoding_2(text, key)[0]));
                                    Keys_2.Add(Encoding_2(text, key)[1]);
                                    texts.Add(Encoding_2(text, key)[2]);
                                }
                            }
                        }
                        while (limit < 6);
                    }
                }
                while (counts > 0);
                string best_key = "";
                double max = x.Max();
                int i_max = -1;
                for (int i = 0; i < x.Count; i++)
                {
                    if (max == x[i])
                    {
                        i_max = i;
                    }
                }
                char[,] matrix = new char[6,6];
                best_key = Keys_2[i_max];
                for (int i = 0; i < 6; i++)
                {
                    textBox9.Text += best_key[i];
                }
                textBox6.Text = texts[i_max];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (6 * i + j < 33)
                        {
                            matrix[i, j] = best_key[6 * i + j];
                        }
                        else
                        {
                            matrix[i, j] = '-';
                        }
                    }
                }
                textBox7.Text = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        textBox7.Text += matrix[i, j] + " ";
                    }
                    textBox7.Text += Environment.NewLine;
                }
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox6.Text);
            }
            else MessageBox.Show("Введите все данные!");
        }
        private void button7_Click(object sender, EventArgs e)//очистка полей
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
       
        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            label6.Text = "Все варианты расшифрованного текста";
            for (int i = 0; i < texts.Count; i++)
            {
                textBox6.Text += texts[i] + " при x="+x[i]+Environment.NewLine;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            string input = textBox3.Text;
            string output = textBox6.Text;
            double d = 0;
            for (int i=0;i<input.Length;i++)
            {
                if (input[i]==output[i])
                {
                    d += (double)1 / (double)input.Length;
                }
            }
            d = d * 100;
            double c = 0;
            if (texts.Contains(textBox3.Text) == true)
            {
                d = 100;
                c = (double)texts.IndexOf(textBox4.Text) / (double)texts.Count;
                c = c * 100;
            }
            MessageBox.Show("Обработано ключей: "+x.Count+". Точность алгоритма: "+d+"%."+" Точность нахождения текста полностью: "+c+"%");
        }
    }
}


