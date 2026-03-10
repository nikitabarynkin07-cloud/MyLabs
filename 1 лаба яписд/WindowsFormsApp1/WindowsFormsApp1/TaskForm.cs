using Lab1;
using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void ButtonFindMax_Click(object sender, EventArgs e)
        {
            // Проверка на пустое значение
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                MessageBox.Show(
                    "Пожалуйста, введите число!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Проверка на корректность числа
            int number;
            if (!int.TryParse(textBoxNumber.Text, out number))
            {
                MessageBox.Show(
                    "Введено некорректное число! Используйте только цифры.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Проверка на положительность
            if (number < 0)
            {
                MessageBox.Show(
                    "Число должно быть положительным!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Вызов рекурсивного метода
            int maxDigit = Recursion.FindMaxDigit(number);

            // Вывод результата
            labelResult.Text = $"Максимальная цифра числа {number} = {maxDigit}";
        }
    }
}