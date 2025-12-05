using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Класс для реализации игры Сапер (4 пункт меню)
    /// </summary>
    internal class Game
    {
        //константа размера поля по ч
        private const int Size_1 = 5;
        //константа размера поля по н
        private const int Size_2 = 5;
        //константа изображения мин
        private const char Mine = '*';
        //константа изображения неоткрытых клеток поля
        private const char Hide = '#';

        /// <summary>
        /// Главный метод игры в сапер
        /// </summary>
        public void Saper()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                char[,] Array = Num(MineCreate(Pole(), 5));
                char[,] UserArray = Pole();
                int countMine = 5;
                Print_Array(UserArray);
                while (true)
                {
                    int count = 0;
                    for (int i = 0; i < UserArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < UserArray.GetLength(1); j++)
                        {
                            if ((UserArray[i, j] != '*') && (UserArray[i, j] != '#')) count++;
                        }
                    }
                    if ((UserArray.GetLength(0) * UserArray.GetLength(1) - countMine) == count)
                    {
                        Console.WriteLine("ПОБЕДА!!!");
                        if (ExitSaper() == false)
                            flag = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите номер строки (от 1 до 5)");
                        int x = Coord();
                        Console.WriteLine("Введите номер столбца (от 1 до 5)");
                        int y = Coord();

                        if (Array[x, y] != '*')
                        {
                            UserArray[x, y] = Array[x, y];
                            Print_Array(UserArray);
                            Console.WriteLine("Клетка была без мины");
                        }
                        else
                        {
                            Print_Array(Array);
                            Console.WriteLine("Вы взорвались на мине");
                            if (ExitSaper() == false)
                                flag = false;
                            break;
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Метод заполнения поля решетками
        /// </summary>
        /// <returns></returns>
        private char[,] Pole()
        {
            char[,] arr = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = '#';
                }
            }
            return arr;
        }


        /// <summary>
        /// Метод отрисовки игрового поля в консоли
        /// </summary>
        /// <param name="arr"></param>
        private void Print_Array(char[,] arr)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 1; j < arr.GetLength(1) + 1; j++)
                Console.Write(j + " ");
            Console.WriteLine();

            for (int i = 1; i < arr.GetLength(0) + 1; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j < arr.GetLength(1) + 1; j++)
                {
                    Console.Write(arr[i - 1, j - 1] + " ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Метод заполнения поля минами
        /// </summary>
        /// <param name="counter"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns>возвращается поле, заполненное минами</returns>
        private char[,] MineCreate(char[,] array, int mineCount)
        {
            //счетчик для подсчета текущего количества мин
            int counter = 0;
            //строки игрового поля
            int row = array.GetLength(0);
            //колонки игрового поля
            int col = array.GetLength(1);
            var rnd = new Random();

            while (counter < mineCount)
            {
                int r = rnd.Next(row);
                int c = rnd.Next(col);
                if (array[r, c] != '*')
                {
                    array[r, c] = '*';
                    counter++;
                }
            }
            return array;
        }


        /// <summary>
        /// Метод заполнения поля цифровыми значениями в зависимости от количества мин вокруг
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="mineCounter"></param>
        /// <returns>Возвращается поле, заполненное минами</returns>
        private char[,] Num(char[,] array)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);

            //идем по всему полю
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //если встречаем мину то ее не трогаем
                    if (array[i, j] == '*') continue;

                    int mineCounter = 0;

                    //осматриваем клетки вокруг мины
                    for (int r = -1; r <= 1; r++)
                    {
                        for (int c = -1; c <= 1; c++)
                        {
                            if (r == 0 && c == 0) continue;
                            int xr = i + r; int xc = j + c;

                            //проверка что мы не за границами
                            if (xr < 0 || xr >= row || xc < 0 || xc >= col) continue;

                            //прибавляем счетчик если встретили мину
                            if (array[xr, xc] == '*') mineCounter++;
                        }
                    }
                    //заполнение ячейки цифрой
                    array[i, j] = (char)('0' + mineCounter);
                }
            }
            return array;
        }

        /// <summary>
        /// Метод ввода координат поля
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        private int Coord()
        {
            int c = CheckInput.iCheck();
            bool flag = true;
            while (flag)
            {
                if (c < 0 || c > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Координаты существуют в диапазоне от 1 до 5");
                    c = CheckInput.iCheck();
                }
                else
                    flag = false;
            }
            return c - 1;
        }

        /// <summary>
        /// Метод выбора повторной игры
        /// </summary>
        /// <returns>Возвращается значение да\нет</returns>
        private bool ExitSaper()
        {
            Console.WriteLine("Хотите сыграть еще раз? (Да/Нет)");
            string answer = Console.ReadLine().ToLower();
            while (answer != "да" && answer != "нет")
            {
                Console.WriteLine("Ошибка! Введите да или нет");
                answer = Console.ReadLine().ToLower();
            }
            Console.Clear();
            if (answer == "да") return true;
            else return false;
        }
    }
}
