using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseThree
{
    public partial class Form1 : Form
    {
        bool isCalculated;
        int count, numDoc;
        Journal[] journals;
        string[] rows;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("journals.txt"))
            {
                rows = File.ReadAllLines("journals.txt");
                count = rows.Length;
                journals = new Journal[count];
            }
            else 
            {
                MessageBox.Show("Файл не найден");
            }

            for (var i = 0; i < count; i++)
            {
                string[] str = rows[i].Split(',');
                journals[i].Name = str[0];
                journals[i].Periodicity = Convert.ToInt32(str[1]);
                journals[i].Price = Convert.ToDouble(str[2]);
            }
        }

        private void Print()
        {
            dataGridView1.Rows.Clear();
            foreach (var j in journals)
            {
                dataGridView1.Rows.Add(j.Name, j.Periodicity.ToString(), j.Price.ToString(), j.CostOfCopies.ToString(), j.CountOfCopies.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
            {
                MessageBox.Show("Перед сортировкой необходимо установить подписку");
                return;
            }

            Journal journal;
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - 1; j++)
                {
                    if (journals[j].CostOfCopies > journals[j + 1].CostOfCopies)
                    {
                        journal = journals[j];
                        journals[j] = journals[j + 1];
                        journals[j + 1] = journal;
                    }
                }
            }
            Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
            {
                MessageBox.Show("Перед сортировкой необходимо установить подписку");
                return;
            }

            Journal journal;
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - 1; j++)
                {
                    if (journals[j].CostOfCopies < journals[j + 1].CostOfCopies)
                    {
                        journal = journals[j];
                        journals[j] = journals[j + 1];
                        journals[j + 1] = journal;
                    }
                }
            }
            Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (StartTime.Value >= FinishTime.Value)
            {
                MessageBox.Show("Неверно заполнен период подписки.");
                return;
            }

            for (var i = 0; i < journals.Length; i++)
            {
                journals[i].GetCountOfCopies(StartTime.Value, FinishTime.Value);
                journals[i].GetCostOfCopies();
            }

            Print();
            isCalculated = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PeriodicityPlace.Value == 0)
            {
                MessageBox.Show("Введите периодичность.");
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var j in journals)
            {
                if (j.Periodicity == PeriodicityPlace.Value)
                {
                    dataGridView1.Rows.Add(j.Name, j.Periodicity.ToString(), j.Price.ToString(), j.CostOfCopies.ToString(), j.CountOfCopies.ToString());
                }                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numDoc++;
            sw = File.CreateText($"Document {numDoc}.txt");
            var result = string.Format("{0,20};{1,13};{2,4};{3,18};{4,22}","Название", "Периодичность", "Цена", "Стоимость подписки", "Количество экземпляров");
            sw.WriteLine(result);

            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                result = string.Format("{0,20};{1,13};{2,4};{3,18};{4,22}",
                                       dataGridView1.Rows[i].Cells[0].Value,
                                       dataGridView1.Rows[i].Cells[1].Value,
                                       dataGridView1.Rows[i].Cells[2].Value,
                                       dataGridView1.Rows[i].Cells[3].Value,
                                       dataGridView1.Rows[i].Cells[4].Value);
                sw.WriteLine(result);
            }
            sw.Close();
        }

        struct Journal
        {
            public string Name { get; set; }
            public int Periodicity { get; set; }
            public double Price { get; set; }
            public double CostOfCopies { get; set; }
            public int CountOfCopies { get; set; }

            public int GetCountOfCopies(DateTime start, DateTime finish) => CountOfCopies = (finish - start).Days / Periodicity + 1;
            public double GetCostOfCopies() => CostOfCopies = Price * CountOfCopies;
        }
    }
}
