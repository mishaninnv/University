using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne
{
    public partial class Form1 : Form
    {
        bool isCalculated = false;
        double discount = 1;
        double result;
        List<Product> products = new List<Product>() { new Product{ Name = "Клей", Price = 15},
                                                       new Product{ Name = "Тряпка", Price = 50},
                                                       new Product{ Name = "Швабра", Price = 150},
                                                       new Product{ Name = "Вилка", Price = 25},
                                                       new Product{ Name = "Нож", Price = 60},
                                                       new Product{ Name = "Ведро", Price = 330},
                                                       new Product{ Name = "Порошок", Price = 70},
                                                       new Product{ Name = "Мыло", Price = 15},
                                                       new Product{ Name = "Шампунь", Price = 81},
                                                       new Product{ Name = "Вешалка", Price = 78},};

        public Form1()
        {
            InitializeComponent();

            foreach (var product in products)
            {
                ProductsList.Items.Add($"{product.Name} - {product.Price}");
            }
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            var product = ProductsList.SelectedIndex;
            if (product == -1)
            {
                MessageBox.Show("Не выбран товар.");
                return;
            }

            if (Copies.Value == 0)
            {
                MessageBox.Show("Не выбрано необходимое количество товара.");
            }

            if (Cash.Checked) discount = 1;
            if (Visa.Checked) discount = 0.95;
            if (MasterCard.Checked) discount = 0.97;

            result = products[product].Price * (double)Copies.Value * discount;
            Sum.Text = $"Сумма: {result}";
            isCalculated = true;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (!isCalculated)
            {
                MessageBox.Show("Рассчитайте стоимость товара!");
                return;
            }

            if ((double)Deposited.Value - result < 0)
            {
                MessageBox.Show("Денежных средств недостаточно.");
                return;
            }

            Change.Text = $"Сдача: {(double)Deposited.Value - result}";
        }

        struct Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}
