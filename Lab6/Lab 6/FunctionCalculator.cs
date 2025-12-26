using System;

namespace Lab_6
{
    /// <summary>
    /// Класс для вычисления математической функции
    /// </summary>
    public static class FunctionCalculator
    {
        /// <summary>
        /// Метод Calculate производит подсчет функции
        /// </summary>
        /// <param name="a">Входное значение</param>
        /// <returns> Ответ на математическую функцию </returns>
        public static double Calculate(double a)
        {
            // константа E (математическое число)
            const double E = Math.E;
            //подсчет функции
            double f = (Math.Sin(a) + Math.Tan(2 * a)) / (Math.Sqrt(Math.Log(Math.Pow(E, 2), 3)));
            //округление ответа
            double answer = Math.Round(f);
            return answer;
        }
    }
}