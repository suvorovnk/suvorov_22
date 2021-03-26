using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._2
{
    public partial class Google2 : Form
    {
        public Google2()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBox1.Text);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://yandex.ru/search/?text=" + toolStripTextBox1.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
