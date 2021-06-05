using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExerciseFour
{
    public partial class Form1 : Form
    {
        StreamReader sr;
        StreamWriter sw;
        int numDoc;
        List<PhoneBook> phoneBooks = new List<PhoneBook>();

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("phonebooks.txt"))
            {
                sr = new StreamReader("phonebooks.txt");
            }
            else 
            {
                MessageBox.Show("Файл не найден");
                return;
            }

            ReadFromFile();
        }

        private void ReadFromFile()
        {
            while (sr.EndOfStream == false)
            {
                PhoneBook phoneBook = new PhoneBook();

                var str = sr.ReadLine();
                var strSplit = str.Split(';');
                phoneBook.Number = strSplit[0];
                phoneBook.Surname = strSplit[1];
                phoneBook.Department = strSplit[2];
                phoneBook.Staff = Convert.ToInt32(strSplit[3]);
                phoneBook.Location = strSplit[4];

                phoneBooks.Add(phoneBook);
            }
            sr.Close();

            dataGridView1.Rows.Clear();
            foreach (var p in phoneBooks)
            {
                dataGridView1.Rows.Add(p.Number, p.Surname, p.Department, p.Staff.ToString(), p.Location);
            }
        }

        public struct PhoneBook
        { 
            public string Number { get; set; }
            public string Surname { get; set; }
            public string Department { get; set; }
            public int Staff { get; set; }
            public string Location { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = comboBox1.Text;
            var data = phoneBooks.Where(c => c.Department == str);

            dataGridView1.Rows.Clear();
            foreach (var p in data)
            {
                dataGridView1.Rows.Add(p.Number, p.Surname, p.Department, p.Staff.ToString(), p.Location);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numDoc++;
            sw = File.CreateText($"Document {numDoc}.txt");
            var result = string.Format("{0,12};{1,20};{2,11}", "Дата поиска", "Отдел", "Телефон");
            sw.WriteLine(result);

            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                result = string.Format("{0,20};{1,13};{2,4}",
                                       DateTime.Now,
                                       dataGridView1.Rows[i].Cells[2].Value,
                                       dataGridView1.Rows[i].Cells[0].Value);
                sw.WriteLine(result);
            }
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<PhoneBook> currPhoneBooks = new List<PhoneBook>();
            for (var i = 0; i < dataGridView1.Rows.Count - 1; i ++)
            {
                currPhoneBooks.Add(new PhoneBook { Number = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                Surname = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                Department = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                Staff = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                Location = dataGridView1.Rows[i].Cells[4].Value.ToString()});
            }
            var sort = currPhoneBooks.OrderBy(s => s.Staff).Select(s => s);
            dataGridView1.Rows.Clear();
            foreach (var p in sort)
            {
                dataGridView1.Rows.Add(p.Number, p.Surname, p.Department, p.Staff.ToString(), p.Location);
            }
        }
    }
}
