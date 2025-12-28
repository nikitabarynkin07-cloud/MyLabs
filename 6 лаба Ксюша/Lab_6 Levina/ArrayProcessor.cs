// ArrayProcessor.cs
using System;
using System.Diagnostics;

namespace Lab_6_Levina
{
    public class ArrayProcessor
    {
        private const int MIN_SIZE = 1;
        private const int MAX_SIZE = 50;
        private const int DEFAULT_SIZE = 10;


        /// <summary>
        /// Создание массива
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int[] CreateRandomArray(int size)
        {
            if (size < MIN_SIZE || size > MAX_SIZE)
                throw new ArgumentOutOfRangeException(nameof(size), $"Размер должен быть от {MIN_SIZE} до {MAX_SIZE}.");

            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(-10, 10);
            return arr;
        }


        /// <summary>
        /// создание массива по умолчанию
        /// </summary>
        /// <returns></returns>
        public static int[] CreateDefaultArray() => CreateRandomArray(DEFAULT_SIZE);
        

        /// <summary>
        /// Сортировка шелла со временем
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static (int[] sorted, double timeMs) ShellSortWithTime(int[] original)
        {
            int[] copy = (int[])original.Clone();
            var sw = Stopwatch.StartNew();
            ShellSort(copy);
            sw.Stop();
            return (copy, sw.Elapsed.TotalMilliseconds);
        }


        /// <summary>
        /// сортировка гномья со временем
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static (int[] sorted, double timeMs) GnomeSortWithTime(int[] original)
        {
            int[] copy = (int[])original.Clone();
            var sw = Stopwatch.StartNew();
            GnomeSort(copy);
            sw.Stop();
            return (copy, sw.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Только сортировка шелла
        /// </summary>
        /// <param name="array"></param>
        private static void ShellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];
                    array[j] = temp;
                }
            }
        }

        /// <summary>
        /// только гномья сортировка
        /// </summary>
        /// <param name="array"></param>
        private static void GnomeSort(int[] array)
        {
            int index = 0;
            int n = array.Length;
            while (index < n)
            {
                if (index == 0)
                    index++;
                else if (array[index] >= array[index - 1])
                    index++;
                else
                {
                    (array[index], array[index - 1]) = (array[index - 1], array[index]);
                    index--;
                }
            }
        }

        /// <summary>
        /// Статистика по массиву
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static (int min, int max, double average) GetStatistics(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив пуст");

            int min = array[0], max = array[0], sum = 0;
            foreach (int val in array)
            {
                if (val < min) min = val;
                if (val > max) max = val;
                sum += val;
            }
            double avg = (double)sum / array.Length;
            return (min, max, avg);
        }
    }
}