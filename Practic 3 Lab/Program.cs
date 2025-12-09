using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Создание массивов для сохранения истории
        /// </summary>
        static double[] distances = new double[10];
        static string[] transports = new string[10];
        static string[] seasons = new string[10];
        static double [] costs = new double[10];
        static int Count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("=== Калькулятор стоимости поездки ===");

            bool flag = true;

            while (flag)
            {
                //показывает меню
                ShowMainMenu();
                             //выбор меню
                int choice = GetMenuChoice(1, 4);

                switch (choice)
                {
                    case 1:
                        //калькулятор поездки
                        CalculateTrip();
                        break;
                    case 2:
                        //показ истории поездок
                        ShowTripHistory();
                        break;
                    case 3:
                        //анализ всех поедок
                        Analis();
                        break;
                    case 4:
                        //выход
                        flag = false;
                        Console.WriteLine("Гудбай");
                        break;
                }
            }
        }

        /// <summary>
        /// Ввод расстояния
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static double distance(string message)
        {
            Console.WriteLine(message);
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance) || distance < 0 || distance > 20000)
                Console.WriteLine("Неверные входные данные. Попробуйте снова: ");
            return distance;
        }


        /// <summary>
        /// Ввод расхода топлива на 1 км
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static double rate(string message)
        {
            Console.WriteLine(message);
            double rate;
            while (!double.TryParse(Console.ReadLine(), out rate) || rate < 0 || rate > 150)
                Console.WriteLine("Неверные входные данные. Попробуйте снова: ");
            return rate;
        }


        /// <summary>
        /// Ввод расхода цены топлива
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static double price(string message)
        {
            Console.WriteLine(message);
            double price;
            while (!double.TryParse(Console.ReadLine(), out price) || price < 0 || price > 150)
                Console.WriteLine("Неверные входные данные. Попробуйте снова: ");
            return price;
        }


        /// <summary>
        /// Отрисовка меню
        /// </summary>
        static void ShowMainMenu()
        {
            Console.WriteLine("\n=== Калькулятор поездки ===");
            Console.WriteLine("1. Новый расчёт");
            Console.WriteLine("2. История поездок");
            Console.WriteLine("3. Анализ расходов");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");
        }


        /// <summary>
        /// Выбор
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


        /// <summary>
        /// Выбора типа трансорта (число)
        /// </summary>
        /// <returns></returns>
        static int GetTransportType()
        {
            Console.WriteLine("\nВыберите транспорт:");
            Console.WriteLine("1. Легковой автомобиль");
            Console.WriteLine("2. Грузовик");
            Console.WriteLine("3. Мотоцикл");
            Console.Write("Выбор: ");
            return GetMenuChoice(1, 3);
        }


        /// <summary>
        /// Выбор типа транспорта (строка)
        /// </summary>
        /// <param name="transportType"></param>
        /// <returns></returns>
        static string GetTransportName(int transportType)
        {
            switch (transportType)
            {
                case 1:
                    return "Легковой";
                case 2:
                    return "Грузовой";
                case 3:
                    return "Мотоцикл";
                default:
                    return "Такого транспорта нет";
            }
        }


        /// <summary>
        /// Выбор сезона (число)
        /// </summary>
        /// <returns></returns>
        static int GetSeasonType()
        {
            Console.WriteLine("\nВыберите сезон:");
            Console.WriteLine("1. Лето");
            Console.WriteLine("2. Зима");
            Console.Write("Выбор: ");
            return GetMenuChoice(1, 2);
        }


        /// <summary>
        /// Выбор сезона (строка)
        /// </summary>
        /// <param name="seasonType"></param>
        /// <returns></returns>
        static string GetSeasonName(int seasonType)
        {
            switch (seasonType)
            {
                case 1:
                    return "Лето";
                case 2:
                    return "Зима";
                default:
                    return "Такого сезона нет";
            }
        }


        /// <summary>
        /// Калькулятор поездки
        /// </summary>
        static void CalculateTrip()
        {
            Console.WriteLine("\n=== Ввод данных для расчета ===");

            //Ввод данных
            double Distance = distance("Введите расстояние (в км)");
            double Rate = rate("Введите расход топлива (л/100км): ");
            double Price = price("Введите цену топлива (руб/л): ");

            //Ввыбор и сохранение типа транспорта в переменных
            int transportType = GetTransportType();
            string transportName = GetTransportName(transportType);

            //Выбор и сохранение сезонов в переменных
            int seasonType = GetSeasonType();
            string seasonName = GetSeasonName(seasonType);


            //Подсчет расхода на поездку вне зависимости от сезона (с учетом типа транспорта)
            double RateType = CalculateFuelConsumption(Rate, transportType);

            //Подсчет финального расхода ( с учетом сезона)
            double finalRate = ApplySeasonalCoefficient(RateType, seasonType);

            //Подсчет всего расхода и цены
            double totalFuel = Distance * (finalRate / 100);
            double totalCost = totalFuel * Price;

            //Сохранение и вывод поездки
            SaveTripToHistory(Distance, transportName, seasonName, totalCost);
            PrintResult(Distance, Rate, Price, transportName, seasonName, totalCost);
        }

        /// <summary>
        /// Подсчет рахода с учетом только типа транспорта (без сезона)
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="TransportType"></param>
        /// <returns></returns>
        static double CalculateFuelConsumption(double rate, int TransportType)
        {
            double trc;
            switch (TransportType)
            {
                case 1:
                    {
                        trc = 1.0;
                        break;
                    }
                case 2:
                    {
                        trc = 1.2;
                        break;
                    }
                case 3:
                    {
                        trc = 0.85;
                        break;
                    }
                default:
                    {
                        trc = 1;
                        break;
                    }
            }
            return trc * rate;
        }


        /// <summary>
        /// Подсчет расхода с учетом сезона
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="SeasonType"></param>
        /// <returns></returns>
        static double ApplySeasonalCoefficient(double rate, int SeasonType)
        {
            double trc;
            switch (SeasonType)
            {
                case 1:
                    {
                        trc = 1.0;
                        break;
                    }
                case 2:
                    {
                        trc = 1.1;
                        break;
                    }
                default:
                    {
                        trc = 1;
                        break;
                    }
            }
            return trc * rate;
        }


        /// <summary>
        /// Метод вывода результата
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="rate"></param>
        /// <param name="price"></param>
        /// <param name="transportName"></param>
        /// <param name="seasonName"></param>
        /// <param name="TotalCost"></param>
        static void PrintResult(double distance, double rate, double price, string transportName, string seasonName, double TotalCost)
        {
            Console.WriteLine("\n=== Результаты расчета ===");
            Console.WriteLine($"Расстояние: {distance} км");
            Console.WriteLine($"Базовый расход топлива: {rate} л/100км");
            Console.WriteLine($"Цена топлива: {price} руб/л");
            Console.WriteLine($"Транспорт: {transportName}");
            Console.WriteLine($"Сезон: {seasonName}");
            Console.WriteLine($"Итоговая стоимость: {Math.Ceiling(TotalCost):F2} руб");
            double costKm = TotalCost / distance;
            Console.WriteLine($"Стоимость 1 км пути: {Math.Ceiling(costKm)} руб");
        }


        /// <summary>
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="transportName"></param>
        /// <param name="seasonName"></param>
        /// <param name="TotalCost"></param>
        static void SaveTripToHistory(double distance, string transportName, string seasonName, double TotalCost)
        {
            if (Count >= 10)
            {
                for (int i = 0; i< 9 ; i++)
                {
                    //Идет работа с полями (массивами для сохранения), а точнее сдвиг при переполнении
                    distances[i] = distances[i + 1];
                    transports[i] = transports[i + 1];
                    seasons[i] = seasons[i + 1];
                    costs[i] = costs[i + 1];
                }
                Count = 9;
            }
            //переприсваивание ячеек массива
            distances[Count] = distance;
            transports[Count] = transportName;
            seasons[Count] = seasonName;
            costs[Count] = TotalCost;
            Count++;

            Console.WriteLine("Поездка сохранена в историю поездок");
            Console.WriteLine($"Всего поездок: {Count}");
        }


        /// <summary>
        /// Вывод истории поездок
        /// </summary>
        static void ShowTripHistory()
        {
            if (Count == 0)
            {
                Console.WriteLine("Исория поездок пуста");
            }
            else
            {
                Console.WriteLine("\n=== История поездок ===");
                Console.WriteLine($"Всего поездок: {Count}");

                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine($"{i + 1}, {distances[i]} км, {transports[i]}, {seasons[i]}, {Math.Ceiling(costs[i])}");
                }
            }
        }


        /// <summary>
        /// Анализ поездок
        /// </summary>
        static void Analis()
        {
            if (Count == 0)
            {
                Console.WriteLine("\nНет данных для анализа");
                return;
            }
            //Сохранение минимальной и максимальной поездки, а также ее общей стоимости и расстояния
            int MaxCostsIndex = 0;
            int MinCostsIndex = 0;
            double totalDistance = 0;
            double totalCosts = 0;
            for (int i = 0; i < Count; i++)
            {
                if (costs[i] > costs[MaxCostsIndex])
                    MaxCostsIndex = i;
                if (costs[i] < costs[MinCostsIndex])
                    MinCostsIndex = i;

                totalDistance += distances[i];
                totalCosts += costs[i];
            }

            Console.WriteLine($"Самая дорогая поездка: {Math.Ceiling(costs[MaxCostsIndex])} руб ({distances[MaxCostsIndex]} км на {transports[MaxCostsIndex]} {seasons[MaxCostsIndex]})");
            Console.WriteLine($"Самая дорогая поездка: {Math.Ceiling(costs[MinCostsIndex])} руб ({distances[MinCostsIndex]} км на {transports[MinCostsIndex]} {seasons[MinCostsIndex]})");
            if (totalDistance > 0)
            {
                double costPerKm = totalDistance / totalCosts;
                Console.WriteLine($"Средняя стоимость 1 км: {Math.Ceiling(costPerKm)} руб");
            }

            ShowBackMenu();
        }


        /// <summary>
        /// Меню для выхода после финального рассчета
        /// </summary>
        static void ShowBackMenu()
        {
            Console.Write("Выберите действие: ");
            Console.WriteLine("\n1. Вернуться в меню");
            Console.WriteLine("2. Выйти");

            int choice = GetMenuChoice(1, 2);

            if (choice == 2)
            {
                Console.WriteLine("До свидания!");
                Environment.Exit(0);
            }
        }
    }
}