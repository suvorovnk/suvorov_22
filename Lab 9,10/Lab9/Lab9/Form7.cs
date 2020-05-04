using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Books22DataSet.author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.Books22DataSet.author);

            this.reportViewer1.RefreshReport();
        }
    }
}
