using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5_левина_оп
{
    /// <summary>
    /// Вызывается для запуска игры змейка
    /// </summary>
    internal class Game1
    {
        /// <summary>
        /// размер игрового поля по горизонтали
        /// </summary>
        private int size1 = 20;
        /// <summary>
        /// размер игрового поля по вертикали
        /// </summary>
        private int size2 = 20;
        /// <summary>
        /// голова змейки и ее тело
        /// </summary>
        private char sim1 = 'O';
        /// <summary>
        /// заполнение пустых клеток поля точками, для просматривания его границ
        /// </summary>
        private char sim2 = '.';
        /// <summary>
        /// еда для змейки
        /// </summary>
        private char sim3 = '$';
        /// <summary>
        /// начальне напрвление змейки в правую сторону
        /// </summary>
        private char sim4 = 'd';


        /// <summary>
        /// реализует игру змейка
        /// </summary>
        static public void Game()
        {
            int sizeField = 20;

            char[,] Field = new char[sizeField, sizeField];


            for (int i = 0; i < sizeField; i++)
            {
                for (int j = 0; j < sizeField; j++)
                {
                    Field[i, j] = '.';
                }
            }

            var snake = new List<(int, int)>();

            snake.Add((sizeField / 2, sizeField / 2));
            Field[sizeField / 2, sizeField / 2] = 'O';

            Random r = new Random();
            int foodX, foodY;

            do
            {
                foodX = r.Next(sizeField);
                foodY = r.Next(sizeField);
            }
            while (Field[foodX, foodY] != '.');

            Field[foodX, foodY] = '$';

            char direction = 'd';
            int points = 0;
            bool game = true;

            while (game)
            {
                Console.Clear();
                Console.WriteLine($"Очки: {points}");
                Console.WriteLine();

                for (int i = 0; i < sizeField; i++)
                {
                    for (int j = 0; j < sizeField; j++)
                    {
                        Console.Write(Field[i, j]);
                    }
                    Console.WriteLine();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W) direction = 'w';
                    if (key.Key == ConsoleKey.S) direction = 's';
                    if (key.Key == ConsoleKey.A) direction = 'a';
                    if (key.Key == ConsoleKey.D) direction = 'd';
                }
                var head = snake[0];
                int newX = head.Item1;
                int newY = head.Item2;

                if (direction == 'w') newX--;
                if (direction == 's') newX++;
                if (direction == 'a') newY--;
                if (direction == 'd') newY++;

                if (newX < 0 || newX >= sizeField || newY < 0 || newY >= sizeField)
                {
                    Console.WriteLine("\nВы врезались в стену!");
                    game = false;
                    break;
                }
                if (Field[newX, newY] == 'O')
                {
                    Console.WriteLine("\nВы врезались в себя!");
                    game = false;
                    break;
                }

                bool ate_food = (Field[newX, newY] == '$');

                snake.Insert(0, (newX, newY));
                Field[newX, newY] = 'O';

                if (ate_food)
                {
                    points++;
                    do
                    {
                        foodX = r.Next(sizeField);
                        foodY = r.Next(sizeField);
                    } while (Field[foodX, foodY] != '.');

                    Field[foodX, foodY] = '$';
                }
                else
                {
                    var tail = snake[snake.Count - 1];
                    snake.RemoveAt(snake.Count - 1);
                    Field[tail.Item1, tail.Item2] = '.';
                }
                System.Threading.Thread.Sleep(80);
            }

            Console.WriteLine($"\nКонец игры! Очки: {points}");
        }
    }
}
