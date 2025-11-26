using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Класс CheckInput отвечает за проверку вводимых данных (чисел)
    /// </summary>
    internal class CheckInput
    {
        /// <summary>
        /// Метод проверки на int
        /// </summary>
        /// ///<param name="number"></param>
        ///<returns> Возвращается вводимое число </returns>
        public static int iCheck()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Ошибка! Введите число:");
            return number;
        }

        /// <summary>
        /// Метод проверки на double
        /// </summary>
        /// ///<param name="number"></param>
        ///<returns> Возвращается вводимое число </returns>
        public static double dCheck()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Ошибка! Введите число:");
            return number;
        }
    }
}
