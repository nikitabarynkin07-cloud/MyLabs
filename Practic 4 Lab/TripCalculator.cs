using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// Класс для реализации всех пунктов меню
    /// </summary>
    internal class TripCalculator
    {
        // Поля по методичке
        private TripData[] trips;
        private int currentIndex;
        private int tripCount;

        /// <summary>
        /// Конструктор для заполнения массива trips
        /// </summary>
        /// <param name="maxCont"></param>
        public TripCalculator(int maxCont = 10)
        {
            trips = new TripData[maxCont];
            currentIndex = 0;
            tripCount = 0;
        }


        /// <summary>
        /// Метод для добавления поездки в историю
        /// </summary>
        public void AddTrip()
        {
            double Distance = distance("Введите расстояние (км): ");

            double fuelRate = rate("Введите расход топлива (л/100км): ");

            double fuelPrice = price("Введите цену топлива (руб/л): ");

            string vehicleType = GetVehicleType();

            string season = GetSeason();

            int month = GetMonth(season);
            TripData newTrip = new TripData(Distance, vehicleType, season, fuelPrice, fuelRate, month);


            if (tripCount < trips.Length)
            {
                trips[currentIndex] = newTrip;
                currentIndex++;
                tripCount++;
            }

            else
            {
                trips[currentIndex] = newTrip;
                currentIndex = (currentIndex + 1) % trips.Length;
            }

            Console.WriteLine("\nПоездка добавлена успешно!");
            Console.WriteLine($"Стоимость: {newTrip.TotalCost:F2} руб.");

            double costKm = 0;
            if (Distance > 0) costKm = newTrip.TotalCost / Distance;
            Console.WriteLine($"Стоимость 1 км: {costKm:F2} руб");

        }

        /// <summary>
        /// Метод для выбора месяца в зависимости от сезона
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        private int GetMonth(string season)
        {
            while (true)
            {
                if (season == "Зима")
                {
                    Console.WriteLine("\nВыберите месяц поездки: (номер у месяца - его номер в году)");
                    Console.WriteLine(" 12. Декабрь  1. Январь    2. Февраль");
                    Console.Write("Ваш выбор: ");

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int month) && (month == 12 || month == 1 || month == 2))
                    {
                        return month;
                    }
                    Console.WriteLine("Ошибка! Введите число (12, 1 или 2).");
                }

                else if (season == "Лето")
                {
                    Console.WriteLine("\nВыберите месяц поездки: (номер у месяца - его номер в году)");
                    Console.WriteLine(" 6. Июнь      7. Июль      8. Август");
                    Console.Write("Ваш выбор: ");

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int month) && (month == 6 || month == 7 || month == 8))
                    {
                        return month;
                    }
                    Console.WriteLine("Ошибка! Введите число (6, 7 или 8).");
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
        }


        /// <summary>
        /// Метод для выбора типа транспорта
        /// </summary>
        /// <returns></returns>
        private string GetVehicleType()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите тип транспорта:");
                Console.WriteLine("1. Легковой автомобиль");
                Console.WriteLine("2. Грузовик");
                Console.WriteLine("3. Мотоцикл");
                Console.Write("Выбор: ");

                string input = Console.ReadLine();
                if (input == "1") return "Легковой";
                if (input == "2") return "Грузовой";
                if (input == "3") return "Мотоцикл";

                Console.WriteLine("Ошибка! Введите число от 1 до 3.");
            }
        }


        /// <summary>
        /// Метод для выбора сезона
        /// </summary>
        /// <returns></returns>
        private string GetSeason()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите сезон:");
                Console.WriteLine("1. Лето");
                Console.WriteLine("2. Зима");
                Console.Write("Выбор: ");

                string input = Console.ReadLine();
                if (input == "1") return "Лето";
                if (input == "2") return "Зима";

                Console.WriteLine("Ошибка! Введите число от 1 до 3.");
            }
        }


        /// <summary>
        /// Метод для ввода расстояния
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
        /// Метод для отображения истории поездок
        /// </summary>
        public void ShowTripHistory()
        {
            if (tripCount == 0)
            {
                Console.WriteLine("История поездок пуста.");
                return;
            }

            Console.WriteLine("\n=== История поездок ===");
            Console.WriteLine($"Всего поездок: {tripCount}");
            Console.WriteLine(new string('-', 141));
            Console.WriteLine(" №  | Расстояние | Транспорт | Сезон | Цена топлива за литр | Стоимость всей поездки | Стоимость / км   | Месяц   | Дата добавления поездки |");
            Console.WriteLine(new string('-', 141));

            int showIndex = 1;
            for (int i = 0; i < trips.Length; i++)
            {

                if (trips[i] != null)
                {
                    trips[i].PrintInfo(showIndex);
                    showIndex++;
                }
            }

        }


        /// <summary>
        /// Метод для подсчета средней стоимости на 1 км для каждого типа транспорта
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        private double GetAvarageCostPerKm(string vehicleType)
        {
            double totalCost = 0;
            double totalDistance = 0;
            int count = 0;

            for (int i = 0;i<trips.Length;i++)
            {
                if (trips[i] != null && trips[i].VehicleType == vehicleType)
                {
                    totalCost += trips[i].TotalCost;
                    totalDistance += trips[i].Distance;
                    count++;
                }
            }
            if (count == 0 || totalDistance == 0) return 0;
            return totalCost/totalDistance;
        }


        /// <summary>
        /// Метод для подсчета средней стоимости поездки в зависимости от месяца
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        private double GetAverageCostByMonth(int month)
        {
            double totalCost = 0;
            int count = 0;

            for (int i = 0; i < trips.Length; i++)
            {
                if (trips[i] != null && trips[i].Month == month)
                {
                    totalCost += trips[i].TotalCost;
                    count++;
                }
            }

            if (count == 0) return 0;

            return totalCost / count;
        }


        /// <summary>
        /// Метьод для вывода имени месяца в зависимости от его номера
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        private string GetMonthName(int monthNumber)
        {
            string[] months = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь","Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

            if (monthNumber >= 1 && monthNumber <= 12)
                return months[monthNumber - 1];
            return "неизвестно";
        }


        /// <summary>
        /// Метод для анализа поездок
        /// </summary>
        public void AnalyzeTips()
        {
            if (tripCount == 0)
            {
                Console.WriteLine("\nНет данных для анализа");
                return;
            }


            Console.WriteLine("\n=== Анализ расходов ===");
            Console.WriteLine($"Всего поездок: {tripCount}");

            double totalCost = 0;
            for (int i = 0; i < trips.Length;i++)
            {
                if (trips[i] != null)
                {
                    totalCost += trips[i].TotalCost;
                }
            }

            double avCost = totalCost / tripCount;
            Console.WriteLine($"Средняя стоимость: {avCost:F0} руб.");

            string mostEco = "";
            double bestCost = double .MaxValue;

            double carCost = GetAvarageCostPerKm("Легковой");
            if (carCost > 0 && carCost < bestCost)
            {
                bestCost = carCost;
                mostEco = "легковой";
            }

            double truckCost = GetAvarageCostPerKm("Грузовик");
            if (truckCost > 0 && truckCost < bestCost)
            {
                bestCost = truckCost;
                mostEco = "грузовик";
            }

            
            double bikeCost = GetAvarageCostPerKm("Мотоцикл");
            if (bikeCost > 0 && bikeCost < bestCost)
            {
                bestCost = bikeCost;
                mostEco = "мотоцикл";
            }

            if (!string.IsNullOrEmpty(mostEco))
            {
                Console.WriteLine($"Самый экономичный транспорт: {mostEco} ({bestCost:F1} руб/км)");
            }

            int mostExp = 0;
            double highestCost = 0;

            for (int month = 1; month <= 12; month++)
            {
                double monthAvg = GetAverageCostByMonth(month);
                {
                    if (monthAvg > highestCost)
                    {
                        highestCost = monthAvg;
                        mostExp = month;
                    }
                }
            }

            if (mostExp > 0 && avCost > 0)
            {
                double Percents = ((highestCost - avCost)/avCost)*100;
                string monthName = GetMonthName(mostExp);
                Console.WriteLine($"Самый затратный месяц: {monthName} (+{Percents:F0}% к среднему)");
            }


        }


        /// <summary>
        /// Метод для сравнение типов транспорта
        /// </summary>
        public void CompareVehicles()
        {
            if (tripCount <2)
            {
                Console.WriteLine("\nНедостаточно данных для сравнения. Нужно как минимум 2 поездки.");
                return;
            }

            Console.WriteLine("\n=== Сравнение эффективности разных видов транспорта ===");

            string[] vehicleTypes = { "Легковой", "Грузовик", "Мотоцикл" };

            Console.WriteLine("\nТоп транспорта по эффективности");
            Console.WriteLine("Транспорт       | Стоимость/км | Поездок");

            foreach(string vType in vehicleTypes)
            {
                double totalCost = 0;
                double totalDistance = 0;
                int count = 0;

                for (int i = 0; i < trips.Length; i++)
                {
                    if (trips[i] != null && trips[i].VehicleType == vType)
                    {
                        totalCost += trips[i].TotalCost;
                        totalDistance += trips[i].Distance;
                        count++;
                    }
                }

                if (count > 0)
                {
                    double avgCostPerKm = 0;
                    if (totalDistance > 0) { avgCostPerKm = totalCost / totalDistance; }
                    Console.WriteLine($"{vType,-15} | {avgCostPerKm,11:F2} | {count,7}");
                }
            }
        }
    }
}
