using System;
using System.Windows.Forms;

namespace Lab_6
{
    /// <summary>
    /// Класс CheckInput отвечает за проверку вводимых данных (чисел)
    /// </summary>
    static class CheckInput
    {
        /// <summary>
        /// Метод проверки на int
        /// </summary>
        /// <param name="textBox">Текстовое поле для ввода</param>
        /// <returns> Возвращается вводимое число </returns>
        public static int iCheck(TextBox textBox)
        {
            int number;
            if (!int.TryParse(textBox.Text, out number))
            {
                MessageBox.Show("Ошибка! Введите целое число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return int.MinValue;
            }
            return number;
        }
    }
}