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
using NPOI.XSSF.UserModel;

namespace Lab8
{
    public partial class Performance : Form
    {
        public demoEntities db = new demoEntities();
        public List<progress> progress_sheet;
        public Performance()
        {
            InitializeComponent();
            progress_sheet = (from prog in db.progress select prog).ToList();
            var query = (from prog in progress_sheet
                         join stud in db.students on prog.code_stud equals stud.code_stud
                         join sub in db.subjects on prog.code_subject equals sub.code_subject
                         join lec in db.lectors on prog.code_lector equals lec.code_lector
                         orderby prog.code_stud
                         select new { stud.surname, stud.name, sub.name_subject,prog.estimate, lec.name_lector }).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Фамилия студента";
            dataGridView1.Columns[1].HeaderText = "Имя студента";
            dataGridView1.Columns[2].HeaderText = "Название предмета";
            dataGridView1.Columns[3].HeaderText = "Оценка";
            dataGridView1.Columns[4].HeaderText = "ФИО преподавателя";
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = (from prog in progress_sheet
                         join stud in db.students on prog.code_stud equals stud.code_stud
                         join sub in db.subjects on prog.code_subject equals sub.code_subject
                         join lec in db.lectors on prog.code_lector equals lec.code_lector
                         orderby prog.code_stud
                         select new { stud.surname, stud.name, sub.name_subject, prog.estimate, lec.name_lector }).ToList();
            dataGridView1.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from prog in progress_sheet
                         join stud in db.students on prog.code_stud equals stud.code_stud
                         join sub in db.subjects on prog.code_subject equals sub.code_subject
                         join lec in db.lectors on prog.code_lector equals lec.code_lector
                         orderby prog.code_stud
                         select new { stud.surname, stud.name, sub.name_subject, prog.estimate, lec.name_lector }).ToList();
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.name.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 2:
                        dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 3:
                        dataGridView1.DataSource = query.Where(p => p.estimate.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 4:
                        dataGridView1.DataSource = query.Where(p => p.name_lector.ToString() == textBox1.Text.ToString()).ToList(); break;
                }
            }
            else
            {
                dataGridView1.DataSource = query;
            }
            dataGridView1.Update();
            if (dataGridView1.RowCount == 0) label1.Visible = true; else label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                EstimateAddcs addSt = new EstimateAddcs();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[1].Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<progress> query = (from prog in db.progress select prog).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (Application.OpenForms.Count == 2)
                {
                    progress item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                    EstimateEdit edit = new EstimateEdit(item);
                    edit.Owner = this;
                    edit.Show();
                }
                else Application.OpenForms[1].Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";
            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет об успеваемости";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                var query = (from prog in progress_sheet
                             join stud in db.students on prog.code_stud equals stud.code_stud
                             join sub in db.subjects on prog.code_subject equals sub.code_subject
                             join lec in db.lectors on prog.code_lector equals lec.code_lector
                             orderby prog.code_stud
                             select new { stud.surname, stud.name, sub.name_subject, prog.estimate, lec.name_lector }).ToList();
                var template2 = new MemoryStream(Properties.Resources.template, true);
                var workbook = new XSSFWorkbook(template2);
                var sheet1 = workbook.GetSheet("Лист1");
                int row = 7;
                foreach (var item in query.OrderBy(o => o.surname))
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(1).SetCellValue(item.surname);
                    rowInsert.CreateCell(2).SetCellValue(item.name);
                    rowInsert.CreateCell(3).SetCellValue(item.name_subject);
                    double p = (double)item.estimate;
                    rowInsert.CreateCell(4).SetCellValue(p);
                    rowInsert.CreateCell(5).SetCellValue(item.name_lector);
                    row++;
                }
                workbook.Write(file);
            }
        }
    }
}
