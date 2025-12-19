using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5_левина_оп
{
    /// <summary>
    /// Вызывается для проверки чисел
    /// </summary>
    internal class InputNumber
    {
        /// <summary>
        /// Проверка на ввод числа
        /// </summary>
        /// <returns></returns>
        static public int Chislo()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("ОШИБКА");
            return number;
        }
        /// <summary>
        /// Проверка на ввод дробного числа
        /// </summary>
        /// <returns></returns>
        static public double Drobi()
        {
            double number2;
            while (!double.TryParse(Console.ReadLine(), out number2))
                Console.WriteLine("ОШИБКА");
            return number2;
        }
    }
}
