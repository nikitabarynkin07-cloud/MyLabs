// GuessGameLogic.cs
using Lab_6_Levina;
using System;

namespace Lab_6_Levina
{
    public class GuessGameLogic
    {
        private double _correctAnswer;
        public int _attemptsLeft;
        public readonly int TotalAttempts;
        public readonly int TimeLimitSeconds;
        public CountdownTimer Timer { get; private set; }


        /// <summary>
        /// Конструктор угадайки
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="attempts"></param>
        /// <param name="timeLimit"></param>
        public GuessGameLogic(double a, double b, int attempts, int timeLimit)
        {
            _correctAnswer = CalculateFormula(a, b);
            _attemptsLeft = attempts;
            TotalAttempts = attempts;
            TimeLimitSeconds = timeLimit;
            Timer = new CountdownTimer(timeLimit);
        }


        /// <summary>
        /// Переменна для окончания игры 
        /// </summary>
        public bool IsGameOver => _attemptsLeft <= 0 || Timer.GetRemainingSeconds() <= 0;

        /// <summary>
        /// Правильный ответ
        /// </summary>
        public double CorrectAnswer => _correctAnswer;

        /// <summary>
        /// Угадайка
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public GuessResult MakeGuess(int guess)
        {
            if (IsGameOver) return GuessResult.GameOver;
            _attemptsLeft--;
            if (guess == (int)Math.Round(_correctAnswer))
                return GuessResult.Correct;
            return _attemptsLeft > 0 && Timer.GetRemainingSeconds() > 0
                ? GuessResult.Incorrect
                : GuessResult.GameOver;
        }

        /// <summary>
        /// Запуск таймера после начала игры
        /// </summary>
        public void Start() => Timer.Start();

        /// <summary>
        /// Формула
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static double CalculateFormula(double a, double b)
        {
            const double PI = Math.PI;

            // Вычисляем аргумент для косинуса
            double cosArg = Math.Cos(a + b);

            // Защита от отрицательного значения под корнем
            double sqrtValue = cosArg >= 0 ? Math.Sqrt(cosArg) : 0.0;

            double sinPart = Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * PI));
            double result = sinPart + sqrtValue;

            return Math.Round(result);
        }
    }

    public enum GuessResult
    {
        Correct,
        Incorrect,
        GameOver
    }
}