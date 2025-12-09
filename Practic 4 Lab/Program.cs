using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// Основной класс программы, в котором реализуется задача нахождения Стоимости поездки
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Калькулятор стоимости поездки ===");

            TripCalculator calculator = new TripCalculator();
            bool flag = true;

            while (flag)
            {
                //показывает меню
                ShowMainMenu();
                //выбор меню
                int choice = GetMenuChoice(1, 5);

                switch (choice)
                {
                    case 1:
                        //калькулятор поездки
                        calculator.AddTrip();
                        break;
                    case 2:
                        //показ истории поездок
                        calculator.ShowTripHistory();
                        break;
                    case 3:
                        //анализ всех поедок
                        calculator.AnalyzeTips();
                        break;
                    case 4:
                        //Сравнение эффекивности транспорта
                        calculator.CompareVehicles();
                        break;
                    case 5:
                        //выход
                        flag = false;
                        Console.WriteLine("Гудбай");
                        break;
                }
            }
        }


        /// <summary>
        /// Метод для отображения меню
        /// </summary>
        static void ShowMainMenu()
        {
            Console.WriteLine("\n=== Калькулятор поездки ===");
            Console.WriteLine("1. Новый расчёт");
            Console.WriteLine("2. История поездок");
            Console.WriteLine("3. Анализ расходов");
            Console.WriteLine("4. Сравнение транспорта");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");
        }


        /// <summary>
        /// Метод для выбора пункта меню
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static int GetMenuChoice(int min, int max)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= min && choice <= max)
                {
                    return choice;
                }
                Console.Write($"Ошибка! Введите число от {min} до {max}: ");
            }
        }
    }
}
