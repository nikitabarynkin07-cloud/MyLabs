using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    /// <summary>
    /// Класс для реализации логики игры Сапер
    /// </summary>
    internal class SaperLogic
    {
        // Размер поля
        public const int Size_1 = 5;
        public const int Size_2 = 5;
        // Изображение мин
        private const char Mine = '*';
        // Изображение неоткрытых клеток
        private const char Hide = '#';

        // Двумерные массивы для хранения состояния поля
        private char[,] gameField; // Поле с минами и цифрами
        private char[,] userField; // Поле, видимое игроку

        // Количество мин
        private int countMine = 5;

        // Флаг победы/поражения
        private bool isGameOver = false;
        private bool isWin = false;

        /// <summary>
        /// Конструктор. Инициализирует новую игру.
        /// </summary>
        public SaperLogic()
        {
            InitializeGame();
        }

        /// <summary>
        /// Инициализирует новую игру.
        /// </summary>
        private void InitializeGame()
        {
            gameField = MineCreate(Pole(), countMine);
            userField = Pole();
            isGameOver = false;
            isWin = false;
        }

        /// <summary>
        /// Получает состояние клетки по координатам.
        /// </summary>
        /// <param name="row">Строка (0-based)</param>
        /// <param name="col">Столбец (0-based)</param>
        /// <returns>Символ, представляющий состояние клетки</returns>
        public char GetCellState(int row, int col)
        {
            if (row < 0 || row >= Size_1 || col < 0 || col >= Size_2)
                return ' ';
            return userField[row, col];
        }

        /// <summary>
        /// Проверяет, является ли клетка открытой.
        /// </summary>
        /// <param name="row">Строка (0-based)</param>
        /// <param name="col">Столбец (0-based)</param>
        /// <returns>True, если клетка открыта, иначе False</returns>
        public bool IsCellOpen(int row, int col)
        {
            return userField[row, col] != Hide;
        }

        /// <summary>
        /// Открывает клетку по координатам.
        /// </summary>
        /// <param name="row">Строка (0-based)</param>
        /// <param name="col">Столбец (0-based)</param>
        /// <returns>True, если игра продолжается, False, если игра окончена (победа или поражение)</returns>
        public bool OpenCell(int row, int col)
        {
            if (isGameOver)
                return false;

            if (row < 0 || row >= Size_1 || col < 0 || col >= Size_2)
                return true;

            if (userField[row, col] != Hide)
                return true; // Клетка уже открыта

            if (gameField[row, col] == Mine)
            {
                // Игрок нажал на мину
                userField[row, col] = Mine;
                isGameOver = true;
                isWin = false;
                return false;
            }

            // Открываем клетку
            userField[row, col] = gameField[row, col];

            // Проверяем победу
            CheckWin();

            return !isGameOver;
        }

        /// <summary>
        /// Проверяет, достигнута ли победа.
        /// </summary>
        private void CheckWin()
        {
            int openedCells = 0;
            for (int i = 0; i < Size_1; i++)
            {
                for (int j = 0; j < Size_2; j++)
                {
                    if (userField[i, j] != Hide && userField[i, j] != Mine)
                        openedCells++;
                }
            }

            if (openedCells == (Size_1 * Size_2 - countMine))
            {
                isGameOver = true;
                isWin = true;
            }
        }

        /// <summary>
        /// Возвращает флаг окончания игры.
        /// </summary>
        /// <returns>True, если игра окончена</returns>
        public bool IsGameOver()
        {
            return isGameOver;
        }

        /// <summary>
        /// Возвращает флаг победы.
        /// </summary>
        /// <returns>True, если игрок победил</returns>
        public bool IsWin()
        {
            return isWin;
        }

        /// <summary>
        /// Возвращает полное поле (для отладки или показа после проигрыша).
        /// </summary>
        /// <returns>Двумерный массив с полным состоянием поля</returns>
        public char[,] GetFullField()
        {
            return gameField;
        }

        /// <summary>
        /// Метод заполнения поля решетками
        /// </summary>
        /// <returns>Пустое поле</returns>
        private char[,] Pole()
        {
            char[,] arr = new char[Size_1, Size_2];
            for (int i = 0; i < Size_1; i++)
            {
                for (int j = 0; j < Size_2; j++)
                {
                    arr[i, j] = Hide;
                }
            }
            return arr;
        }

        /// <summary>
        /// Метод заполнения поля минами
        /// </summary>
        /// <param name="array">Поле</param>
        /// <param name="mineCount">Количество мин</param>
        /// <returns>Поле, заполненное минами</returns>
        private char[,] MineCreate(char[,] array, int mineCount)
        {
            int counter = 0;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            var rnd = new Random();
            while (counter < mineCount)
            {
                int r = rnd.Next(row);
                int c = rnd.Next(col);
                if (array[r, c] != Mine)
                {
                    array[r, c] = Mine;
                    counter++;
                }
            }
            return array;
        }

        /// <summary>
        /// Метод заполнения поля цифровыми значениями в зависимости от количества мин вокруг
        /// </summary>
        /// <param name="array">Поле с минами</param>
        /// <returns>Поле с цифрами</returns>
        private char[,] Num(char[,] array)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (array[i, j] == Mine) continue;
                    int mineCounter = 0;
                    for (int r = -1; r <= 1; r++)
                    {
                        for (int c = -1; c <= 1; c++)
                        {
                            if (r == 0 && c == 0) continue;
                            int xr = i + r; int xc = j + c;
                            if (xr < 0 || xr >= row || xc < 0 || xc >= col) continue;
                            if (array[xr, xc] == Mine) mineCounter++;
                        }
                    }
                    array[i, j] = (char)('0' + mineCounter);
                }
            }
            return array;
        }

        /// <summary>
        /// Перезапускает игру.
        /// </summary>
        public void Restart()
        {
            InitializeGame();
        }
    }
}