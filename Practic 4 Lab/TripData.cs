using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс для реализации данных для последующих рассчетов
    /// </summary>
    internal class TripData
    {
        // Задание полей
        private double distance;
        private string vehicleType;
        private string season;
        private double fuelPrice;
        private int month;

        //Задание свойст полям
        public double Distance { get { return distance; } }
        public string VehicleType { get { return vehicleType; } }
        public string Season { get { return season; } }
        public double FuelPrice { get { return fuelPrice; } }
        public int Month { get { return month; } }
        public double TotalCost { get; private set; }
        public DateTime ShowDate { get; private set; }


        public double CostPerKm
        {
            get
            {
                if (distance > 0)
                    return TotalCost / distance;
                return 0;
            }
        }


        /// <summary>
        /// конструктор для определения полей
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="vType"></param>
        /// <param name="s"></param>
        /// <param name="fPrice"></param>
        /// <param name="baseRate"></param>
        /// <param name="m"></param>
        public TripData(double dist, string vType, string s, double fPrice, double baseRate, int m)
        {
            this.distance = dist;
            this.vehicleType = vType;
            this.season = s;
            this.fuelPrice = fPrice;
            this.month = m;
            ShowDate = DateTime.Now;

            TotalCost = CalculateCost(baseRate);
        }

        
        /// <summary>
        /// Метод для подсчета стоимости, учитывая сезон и транспорт
        /// </summary>
        /// <param name="baseRate"></param>
        /// <returns></returns>
        private double CalculateCost(double baseRate)
        {
            double v_coff = 1.0;
            if (vehicleType == "Грузовик") v_coff = 1.2;
            else if (vehicleType == "Мотоцикл") v_coff = 0.85;

            double s_coff = 1.0;
            if (season == "Зима") s_coff = 1.1;

            double calRate = baseRate * v_coff * s_coff;
            double totalFuel = distance * (calRate / 100);

            return totalFuel * fuelPrice;
        }

        /// <summary>
        /// Вывод информации на экран
        /// </summary>
        /// <param name="index"></param>
        public void PrintInfo(int index = 0)
        {
            if (index > 0)
            {
                Console.Write($"{index,2}. |");
            }

            Console.WriteLine($"{distance,-8:F1} км | {vehicleType,-9} | {season,-5} | " + $"{fuelPrice,-14:F2} руб/л | {TotalCost,-18:F2} руб | {CostPerKm,-9:F2} руб/км | " + $"{GetMonthName(month),-7} |" + $"{ShowDate,-24:dd.MM.yy} |");
        }


        /// <summary>
        /// Нахождение имени месяца по выбранному номеру
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        private string GetMonthName(int monthNumber)
        {
            string[] months = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

            if (monthNumber >= 1 && monthNumber <= 12)
                return months[monthNumber - 1];
            return "неизвестно";
        }
    }
}
