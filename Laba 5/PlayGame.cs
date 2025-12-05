using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Класс PlayGame реализует 1 пункт меню (игра в угадайку)
    /// </summary>
    public static class PlayGame
    {
        /// <summary>
        /// Метод Calculate производит подсчет функции
        /// </summary>
        /// <param name="E"></param>
        /// <param name="a"></param>
        /// <param name="f"></param>
        /// <param name="answer"></param>
        ///<returns> Ответ на математическую функцию </returns>
        public static double Calculate()
        {
            // константа E (математическое число)
            const double E = Math.E;
            //ввод пользовательского числа для подсчета функции
            double a = CheckInput.dCheck();
            //подсчет функции
            double f = (Math.Sin(a) + Math.Tan(2 * a)) / (Math.Sqrt(Math.Log(Math.Pow(E, 2), 3)));
            //округление ответа
            double answer = Math.Round(f);
            return answer;
        }

        /// <summary>
        /// Метод Ugadaika ведет счетчик правильных попыток пользователя, сравнивая его ответ с правильным
        /// </summary>
        ///<param name="guy_answer"></param>
        ///<param name="counter"></param> 
        public static void Ugadaika(double answer)
        {
            //ввод ответа пользователя
            int guy_answer = CheckInput.iCheck();
            if (guy_answer != answer)
            {
                //объявдение счетчика
                int counter = 1;
                while (counter < 3)
                {
                    if (guy_answer != answer)
                        Console.WriteLine("Неверно! Осталось попыток {0}", 3 - counter);
                    else
                    {
                        Console.WriteLine("Верно!");
                        break;
                    }
                    counter++;
                    guy_answer = CheckInput.iCheck();
                }
                if (counter == 3)
                    Console.WriteLine("Неверно! Осталось попыток {0}. Правильный ответ: {1}", 3 - counter, answer);
            }
            else
                Console.WriteLine("Верно!");  
        }

        /// <summary>
        /// Метод Game отвечает за связующую логику угодайки, в нем происходит ввод ответа пользователя и проверка на его правильность
        /// </summary>
        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("Введите число а");
            double correct_answer = Calculate();
            Console.WriteLine("Попробуйте отгадать ответ функции f = (sin(a)+tg(2a)/(sqrt(log3e2)");
            Console.WriteLine("У вас есть 3 попытки!");
            Ugadaika(correct_answer);

            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
