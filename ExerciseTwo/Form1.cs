using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseTwo
{
    public partial class Form1 : Form
    {
        private bool isCalculated;
        private Journal currentJournal;

        private List<Journal> journals = new List<Journal>() { new Journal { Name = "Сканворды", Periodicity = 7, Price = 15},
                                                               new Journal { Name = "Животный мир", Periodicity = 14, Price = 45},
                                                               new Journal { Name = "Загадки истории", Periodicity = 10, Price = 28},
                                                               new Journal { Name = "Кулинарная книга", Periodicity = 30, Price = 150},
                                                               new Journal { Name = "Караван", Periodicity = 15, Price = 87},
                                                               new Journal { Name = "Итории звезд", Periodicity = 12, Price = 63},
                                                               new Journal { Name = "Домашний очаг", Periodicity = 45, Price = 542}};
        public Form1()
        {
            InitializeComponent();

            foreach (var j in journals)
            {
                JournalList.Items.Add($"{j.Name}, периодичность: {j.Periodicity} дней, цена: {j.Price}");
            }
        }



        struct Journal
        {
            public string Name { get; set; }
            public int Periodicity { get; set; }
            public double Price { get; set; }

            public double GetCostOfCopies(int countCopies) => Price * countCopies;
            public int GetCountOfCopies(DateTime start, DateTime finish) => (finish - start).Days / Periodicity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text) ||
                PeriodicityPlane.Value == 0 ||
                PricePlane.Value == 0)
            {
                MessageBox.Show("Заполнены не все данные.");
                return;
            }

            if (StartTime.Value >= FinishTime.Value)
            {
                MessageBox.Show("Неверно заполнен период подписки.");
                return;
            }

            currentJournal = new Journal() { Name = NameText.Text, 
                                          Periodicity = (int)PeriodicityPlane.Value, 
                                          Price = (int)PricePlane.Value};

            var copies = 1 + currentJournal.GetCountOfCopies(StartTime.Value, FinishTime.Value);
            var cost = currentJournal.GetCostOfCopies(copies);

            CostOfCopiesLable.Text = $"Стоимость подписки: {cost}";
            CountCopiesLabel.Text = $"Количество экземпляров: {copies}";
            isCalculated = true;
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
            {
                MessageBox.Show("Рассчитайте стоимость подписки.");
                return;
            }

            JournalList.Items.Add($"{currentJournal.Name}, периодичность: {currentJournal.Periodicity} дней, цена: {currentJournal.Price}");
        }
    }
}
