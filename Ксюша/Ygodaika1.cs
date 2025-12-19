using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5_левина_оп
{
    /// <summary>
    /// Вызывается для 
    /// </summary>
    internal class Ygodaika1
    {
        /// <summary>
        /// Формула по которой расчитывается угадываемое число
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Formula(double a, double b)
        {
            const double PI = Math.PI;
            double c = Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * Math.PI)) + Math.Sqrt(Math.Cos(a + b));
            double answer = Math.Round(c);
            return answer;
        }
        /// <summary>
        /// Подсчет кол-ва попыток для угадывания
        /// </summary>
        /// <param name="answer"></param>
        static void Kakoychislo(double answer)
        {
            int g = InputNumber.Chislo();
            if (g != answer)
            {
                int counter = 1;
                while (counter < 3)
                {
                    if (g != answer)
                        Console.WriteLine(" НЕВЕРНО осталось попыток {0}", 3 - counter);
                    else
                    {
                        Console.WriteLine("Верно");
                        break;
                    }
                    counter++;
                    g = InputNumber.Chislo();
                }
                if (counter == 3)
                    Console.WriteLine("НЕВЕРНО осталось попыток {0}. Правильный ответ: {1}.", 3 - counter, answer);
            }
            else
                Console.WriteLine("Верно!!!!!!!");
        }
        /// <summary>
        /// Ввод чисел, которые в последующем подставляются в формулу
        /// </summary>
        static public void Ugaday()
        {
            Console.WriteLine("Введите числа  a и b");
            double a = InputNumber.Drobi();
            double b = InputNumber.Drobi();
            double answer = Formula(a, b);
            Console.WriteLine("Попробуйтне отгадать ответ на функцию \nУ вас есть 3 попытки");
            Kakoychislo(answer);
            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
