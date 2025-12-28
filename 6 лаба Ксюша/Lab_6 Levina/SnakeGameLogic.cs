// SnakeGameLogic.cs
using System;
using System.Collections.Generic;

namespace Lab_6_Levina
{
    public class SnakeGameLogic
    {
        public const int FIELD_SIZE = 20;
        public const int CELL_SIZE = 20;
        public const int INITIAL_SPEED = 150; // мс

        public List<(int x, int y)> Snake { get; private set; }
        public (int x, int y) Food { get; private set; }
        public char Direction { get; set; }
        public int Score { get; private set; }
        public bool IsGameOver { get; private set; }
        public int Speed { get; private set; }

        private Random _random;


        /// <summary>
        /// Конструктор для вызова игры
        /// </summary>
        public SnakeGameLogic()
        {
            _random = new Random();
            Reset();
        }


        /// <summary>
        /// Игра
        /// </summary>
        public void Reset()
        {
            Snake = new List<(int, int)> { (10, 10) };
            Direction = 'd';
            Score = 0;
            IsGameOver = false;
            Speed = INITIAL_SPEED;
            GenerateFood();
        }


        /// <summary>
        /// Создаение еды в рандомном месте
        /// </summary>
        private void GenerateFood()
        {
            var occupied = new HashSet<(int, int)>(Snake);
            int x, y;
            do
            {
                x = _random.Next(FIELD_SIZE);
                y = _random.Next(FIELD_SIZE);
            } while (occupied.Contains((x, y)));

            Food = (x, y);
        }

        /// <summary>
        /// Движение змейки
        /// </summary>
        public void Move()
        {
            if (IsGameOver) return;

            var head = Snake[0];
            int nx = head.x, ny = head.y;

            switch (Direction)
            {
                case 'w': nx--; break;
                case 's': nx++; break;
                case 'a': ny--; break;
                case 'd': ny++; break;
            }

            // Проход сквозь стены
            if (nx < 0) nx = FIELD_SIZE - 1;
            if (nx >= FIELD_SIZE) nx = 0;
            if (ny < 0) ny = FIELD_SIZE - 1;
            if (ny >= FIELD_SIZE) ny = 0;

            // Проверка самопересечения
            foreach (var segment in Snake)
            {
                if (segment.x == nx && segment.y == ny)
                {
                    IsGameOver = true;
                    return;
                }
            }

            bool ateFood = (nx == Food.x && ny == Food.y);
            Snake.Insert(0, (nx, ny));

            if (ateFood)
            {
                Score += 10;
                // Ускорение каждые 50 очков
                Speed = Math.Max(50, INITIAL_SPEED - (Score / 50) * 10);
                GenerateFood();
            }
            else
            {
                Snake.RemoveAt(Snake.Count - 1);
            }
        }
    }
}