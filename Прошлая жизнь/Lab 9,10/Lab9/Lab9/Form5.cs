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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void purchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.books22DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "books22DataSet.purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.books22DataSet.purchase);

        }
    }
}
