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
        static public List<int> A = new List<int>();
        static public List<int> B = new List<int>();
        static public List<string> texts = new List<string>();
        static public int Number_Top = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
                {
                    int d = int.Parse(textBox1.Text);
                    int a = d;
                    int c = 33;
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
                    if ((c + d) != 1)
                    {
                        MessageBox.Show("Коэффициент а невзаимно простой к коэффициенту m. Введите другое значение");
                    }
                    else
                    {
                        int b = int.Parse(textBox2.Text);
                        string text = textBox3.Text;
                        string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                        string itog = "";
                        for (int i = 0; i < text.Length; i++)
                        {
                            int number = alfabet.IndexOf(text[i]);
                            int new_number = a * number + b;
                            if (new_number > 32) new_number = new_number % 33;
                            itog += alfabet[new_number];
                        }
                        textBox4.Text = itog;
                        using (StreamWriter stream = new StreamWriter("output.txt", false))
                            stream.WriteLine(textBox4.Text);
                    }
                }
                else MessageBox.Show("Введите все данные!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Коэффициенты а и  b должны быть целыми!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                x.Clear();
                A.Clear();
                B.Clear();
                texts.Clear();
                for (int d = 1; d < 33; d++)
                {
                    int a = d;
                    int d2 = d;
                    int c = 33;
                    while ((d2 != 0) && (c != 0))
                    {
                        if (d2 > c)
                        {
                            d2 = d2 % c;
                        }
                        else
                        {
                            c = c % d2;
                        }
                    }
                    if ((c + d2) == 1)
                    {
                        for (int b = 0; b < 34; b++)
                        {
                            string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                            string text = textBox4.Text;
                            double[] massiv_chastot = new double[33] { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.072, 0.007, 0.016, 0.062, 0.01, 0.028, 0.035, 0.026, 0.053, 0.09, 0.023, 0.04, 0.045, 0.053, 0.021, 0.002, 0.009, 0.004, 0.012, 0.006, 0.003, 0.014, 0.016, 0.014, 0.003, 0.006, 0.018 };
                            double[] massiv_chastot2 = new double[text.Length];
                            string itog = "";
                            int a_1 = 0;
                            while ((a * a_1) % 33 != 1)
                            {
                                a_1++;
                            }
                            for (int i = 0; i < text.Length; i++)
                            {
                                int number = alfabet.IndexOf(text[i]);
                                int new_number = ((number + 33 - b) * a_1) % 33;
                                itog += alfabet[new_number];
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
                            x.Add(X);
                            A.Add(a);
                            B.Add(b);
                            texts.Add(text2);
                        }
                    }
                }
                double key_a = 0;
                double key_b = 0;
                double max = x.Max();
                int i_max = -1;
                for (int i = 0; i < x.Count; i++)
                {
                    if (max == x[i])
                    {
                        i_max = i;
                    }
                }
                key_a = A[i_max];
                key_b = B[i_max];
                textBox7.Text = key_a.ToString();
                textBox8.Text = key_b.ToString();
                textBox6.Text = texts[i_max];
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox6.Text);
                Number_Top = 1;
            }
            else MessageBox.Show("Введите все данные!");

        }
        private void Form1_Load(object sender, EventArgs e)
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int b = int.Parse(textBox5.Text);
                string text = textBox3.Text;
                string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                string itog = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int number = alfabet.IndexOf(text[i]);
                    int new_number = number + b;
                    if (new_number > 32) new_number = new_number % 33;
                    itog += alfabet[new_number];
                }
                textBox4.Text = itog;
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox4.Text);
            }
            else MessageBox.Show("Введите все данные!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                x.Clear();
                B.Clear();
                texts.Clear();
                for (int b = 0; b < 34; b++)
                {
                    string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                    string text = textBox4.Text;
                    double[] massiv_chastot = new double[33] { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.072, 0.007, 0.016, 0.062, 0.01, 0.028, 0.035, 0.026, 0.053, 0.09, 0.023, 0.04, 0.045, 0.053, 0.021, 0.002, 0.009, 0.004, 0.012, 0.006, 0.003, 0.014, 0.016, 0.014, 0.003, 0.006, 0.018 };
                    double[] massiv_chastot2 = new double[text.Length];
                    string itog = "";
                    for (int i = 0; i < text.Length; i++)
                    {
                        int number = alfabet.IndexOf(text[i]);
                        int new_number = number - b;
                        if (new_number < 0)
                        {
                            new_number += 33;
                        }
                        itog += alfabet[new_number];
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
                    x.Add(X);
                    B.Add(b);
                    texts.Add(text2);
                }
                double key_b = 0;
                double max = x.Max();
                int i_max = -1;
                for (int i = 0; i < x.Count; i++)
                {
                    if (max == x[i])
                    {
                        i_max = i;
                    }
                }
                key_b = B[i_max];
                textBox9.Text = key_b.ToString();
                textBox6.Text = texts[i_max];
                using (StreamWriter stream = new StreamWriter("output.txt", false))
                    stream.WriteLine(textBox6.Text);
                Number_Top = 1;
            }
            else MessageBox.Show("Введите все данные!");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    List<double> x2 = new List<double>();
                    for (int i = 0; i < x.Count; i++)
                    {
                        x2.Add(x[i]);
                    }
                    x2.Sort();
                    Number_Top++;
                    int number_top = x.Count - Number_Top - 1;
                    int i_number = -1;
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i] == x2[number_top])
                        {
                            i_number = i;
                        }
                    }
                    textBox6.Text = texts[i_number];
                    textBox7.Text = A[i_number].ToString();
                    textBox8.Text = B[i_number].ToString();
                }
                else
                {
                    List<double> x2 = new List<double>();
                    for (int i = 0; i < x.Count; i++)
                    {
                        x2.Add(x[i]);
                    }
                    x2.Sort();
                    Number_Top++;
                    int number_top = x.Count - Number_Top - 1;
                    int i_number = -1;
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i] == x2[number_top])
                        {
                            i_number = i;
                        }
                    }
                    textBox6.Text = texts[i_number];
                    textBox9.Text = B[i_number].ToString();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец массива!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                List<double> x2 = new List<double>();
                for (int i = 0; i < x.Count; i++)
                {
                    x2.Add(x[i]);
                }
                x2.Sort();
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                for (int j = 0; j < 10; j++)
                {

                    for (int i = 0; i < x.Count; i++)
                    {
                        int i_number = -1;
                        if (x[i] == x2[x2.Count - 1 - j])
                        {
                            i_number = i;
                            textBox6.Text += texts[i_number] + " при ключах а=" + A[i_number] + ", b=" + B[i_number] + Environment.NewLine;

                        }
                    }
                }
            }
            else
            {
                List<double> x2 = new List<double>();
                for (int i = 0; i < x.Count; i++)
                {
                    x2.Add(x[i]);
                }
                x2.Sort();
                textBox6.Text = "";
                textBox9.Text = "";
                for (int j = 0; j < 10; j++)
                {

                    for (int i = 0; i < x.Count; i++)
                    {
                        int i_number = -1;
                        if (x[i] == x2[x2.Count - 1 - j])
                        {
                            i_number = i;
                            textBox6.Text += texts[i_number] + " при ключе b=" + B[i_number] + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    List<double> x2 = new List<double>();
                    for (int i = 0; i < x.Count; i++)
                    {
                        x2.Add(x[i]);
                    }
                    x2.Sort();
                    Number_Top--;
                    int number_top = x.Count - Number_Top - 1;
                    int i_number = -1;
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i] == x2[number_top])
                        {
                            i_number = i;
                        }
                    }
                    textBox6.Text = texts[i_number];
                    textBox7.Text = A[i_number].ToString();
                    textBox8.Text = B[i_number].ToString();
                }
                else
                {
                    List<double> x2 = new List<double>();
                    for (int i = 0; i < x.Count; i++)
                    {
                        x2.Add(x[i]);
                    }
                    x2.Sort();
                    Number_Top--;
                    int number_top = x.Count - Number_Top - 1;
                    int i_number = -1;
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i] == x2[number_top])
                        {
                            i_number = i;
                        }
                    }
                    textBox6.Text = texts[i_number];
                    textBox9.Text = B[i_number].ToString();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Конец массива!");
            }

        }
    }
}


