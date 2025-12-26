using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    /// <summary>
    /// Класс для работы с одномерными массивами, модифицированный согласно заданию
    /// </summary>
    internal class MassivSort
    {
        private int[] array; // Основной массив
        private int size;    // Размер массива

        /// <summary>
        /// Конструктор по умолчанию (размер 10)
        /// </summary>
        public MassivSort()
        {
            size = 10;
            array = new int[size];
            GenerateRandomArray();
        }

        /// <summary>
        /// Конструктор с параметром (размер задаётся пользователем)
        /// </summary>
        /// <param name="Size">Размер массива</param>
        public MassivSort(int Size)
        {
            if (Size > 0)
            {
                size = Size;
            }
            else
            {
                throw new ArgumentException("Размер массива должен быть больше 0.");
            }
            array = new int[size];
            GenerateRandomArray();
        }

        /// <summary>
        /// Метод для получения текущего массива
        /// </summary>
        /// <returns>Массив</returns>
        public int[] GetArray()
        {
            return array;
        }

        /// <summary>
        /// Метод для установки массива (например, из DataGridView)
        /// </summary>
        /// <param name="newArray">Новый массив</param>
        public void SetArray(int[] newArray)
        {
            if (newArray.Length != size)
            {
                throw new ArgumentException($"Массив должен иметь размер {size}.");
            }
            array = newArray;
        }

        /// <summary>
        /// Метод заполнения массива рандомными значениями
        /// </summary>
        public void GenerateRandomArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
        }

        /// <summary>
        /// Метод копирования массива
        /// </summary>
        /// <param name="UserArray">Исходный массив</param>
        /// <returns>Копия массива</returns>
        private int[] CopyMass(int[] UserArray)
        {
            int[] copyArray = new int[UserArray.Length];
            for (int i = 0; i < UserArray.Length; i++)
            {
                copyArray[i] = UserArray[i];
            }
            return copyArray;
        }

        /// <summary>
        /// Метод пузырьковой сортировки
        /// </summary>
        /// <param name="c">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        public int[] BubbleSort(int[] c)
        {
            for (int i = 0; i < c.Length; ++i)
            {
                for (int j = 0; j < c.Length - i - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        int temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }
                }
            }
            return c;
        }

        /// <summary>
        /// Метод сортировки выбором
        /// </summary>
        /// <param name="c">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        public int[] ViborSort(int[] c)
        {
            for (int i = 0; i < c.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < c.Length; j++)
                {
                    if (c[j] < c[min])
                    {
                        min = j;
                    }
                }
                int temp = c[min];
                c[min] = c[i];
                c[i] = temp;
            }
            return c;
        }

        /// <summary>
        /// Метод для нахождения максимального значения
        /// </summary>
        /// <returns>Максимальное значение</returns>
        public int FindMax()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Метод для нахождения минимального значения
        /// </summary>
        /// <returns>Минимальное значение</returns>
        public int FindMin()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Метод для нахождения среднего арифметического значения
        /// </summary>
        /// <returns>Среднее арифметическое</returns>
        public double FindAverage()
        {
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        /// <summary>
        /// Метод для выполнения всех операций и возврата результатов в виде строки
        /// </summary>
        /// <returns>Строка с результатами</returns>
        public string PerformAllOperations()
        {
            var stopWatchBuble = System.Diagnostics.Stopwatch.StartNew();
            int[] mass1 = CopyMass(array);
            mass1 = BubbleSort(mass1);
            stopWatchBuble.Stop();

            var stopWatchInsert = System.Diagnostics.Stopwatch.StartNew();
            int[] mass2 = CopyMass(array);
            mass2 = ViborSort(mass2);
            stopWatchInsert.Stop();

            string result = $"Исходный массив: {string.Join(", ", array)}\n\n";
            result += $"Отсортированный пузырьком: {string.Join(", ", mass1)}\n";
            result += $"Время сортировки пузырьком: {stopWatchBuble.Elapsed.TotalMilliseconds:F2} мс\n\n";
            result += $"Отсортированный выбором: {string.Join(", ", mass2)}\n";
            result += $"Время сортировки выбором: {stopWatchInsert.Elapsed.TotalMilliseconds:F2} мс\n\n";

            if (stopWatchBuble.Elapsed.TotalMilliseconds < stopWatchInsert.Elapsed.TotalMilliseconds)
            {
                result += $"Пузырьковая сортировка быстрее на {stopWatchInsert.Elapsed.TotalMilliseconds - stopWatchBuble.Elapsed.TotalMilliseconds:F2} мс.";
            }
            else if (stopWatchInsert.Elapsed.TotalMilliseconds < stopWatchBuble.Elapsed.TotalMilliseconds)
            {
                result += $"Сортировка выбором быстрее на {stopWatchBuble.Elapsed.TotalMilliseconds - stopWatchInsert.Elapsed.TotalMilliseconds:F2} мс.";
            }
            else
            {
                result += "Оба метода заняли одинаковое время.";
            }

            result += $"\n\nМаксимальное значение: {FindMax()}";
            result += $"\nМинимальное значение: {FindMin()}";
            result += $"\nСреднее арифметическое: {FindAverage():F2}";

            return result;
        }

        /// <summary>
        /// Метод для выделения цветом максимума и минимума в DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView, в котором нужно выделить ячейки</param>
        public void HighlightMinMaxInGrid(DataGridView dgv)
        {
            int max = FindMax();
            int min = FindMin();

            // Сбрасываем все стили
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
            }

            // Выделяем максимум и минимум
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null &&
                        int.TryParse(dgv.Rows[i].Cells[j].Value.ToString(), out int cellValue))
                    {
                        if (cellValue == max)
                        {
                            dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                            dgv.Rows[i].Cells[j].Style.ForeColor = Color.DarkGreen;
                        }
                        else if (cellValue == min)
                        {
                            dgv.Rows[i].Cells[j].Style.BackColor = Color.LightCoral;
                            dgv.Rows[i].Cells[j].Style.ForeColor = Color.DarkRed;
                        }
                    }
                }
            }
        }
    }
}