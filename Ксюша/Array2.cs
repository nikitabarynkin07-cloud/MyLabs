using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5_левина_оп
{
    /// <summary>
    /// Вызывается для работы с массивами
    /// </summary>
    internal class Array2
    {
        /// <summary>
        /// поле с парметором
        /// </summary>
        private int size;
        /// <summary>
        /// поле без праметров
        /// </summary>
        private int[] Arr;
        /// <summary>
        /// конструктор создающий 10 элементов в массиве
        /// </summary>
        public Array2()
        {
            size = 10;
            Arr = RandomArray(size);
        }
        /// <summary>
        /// конструктор осуществляющий проверку количес ва элементов
        /// </summary>
        /// <param name="Size"></param>
        public Array2(int Size)
        {
            if (Size > 0)
                size = Size;
            else
            {
                Console.WriteLine("Ошибка, Массив не может содержать количество елементов меньше 0. Стандартное кол-во 10");
                size = 10;
            }
            Arr = RandomArray(size);
        }
        /// <summary>
        /// Проверка на длину массива
        /// </summary>
        /// <returns></returns>
        private int length()
        {
            Console.WriteLine("Введите длину массива:");
            int f = InputNumber.Chislo();
            while (f < 0)
            {
                Console.WriteLine("ОШИБКА, длина массива должна быть больше 0, Введите новое число:");
                f = InputNumber.Chislo();

            }
            return f;
        }
        /// <summary>
        /// заполнение массива рандомными числами
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int[] RandomArray(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10, 10);
            return a;
        }
        /// <summary>
        /// Копирование массива, чтобы считался исходный массив до первой сортировкм
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int[] Copy(int[] n)
        {
            int[] a = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
                a[i] = n[i];
            return a;
        }
        /// <summary>
        /// Сортировка Шелла
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[] ShellSort(int[] array)
        {
            if (array == null || array.Length <= 1)
                return array;
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
            return array;
        }
        /// <summary>
        /// Сортировка Гномья
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[] GnomeSort(int[] array)
        {
            if (array == null || array.Length <= 1)
                return array;
            int index = 0;
            int n = array.Length;

            while (index < n)
            {
                if (index == 0)
                {
                    index++;
                }
                if (array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }
            return array;
        }
        /// <summary>
        /// Вывод итогов и затраченного времени двух сортировок
        /// </summary>
        public void Sort()
        {
            int[] array = RandomArray(length());
            Print_Array(array);
            Console.WriteLine("\n");
            Console.WriteLine("Массив отсортирован методом Шелла.");
            var stopWatchShella = Stopwatch.StartNew();
            int[] mass1 = Copy(array);
            mass1 = ShellSort(mass1);
            stopWatchShella.Stop();
            double n1 = stopWatchShella.Elapsed.TotalMilliseconds;
            Print_Array(mass1);
            Console.WriteLine("\nВремя сортировки массива методом Шелла равно:{0}", n1);
            Console.WriteLine("Массив отсортированный методом Гномья");
            var stopWatchGnomia = Stopwatch.StartNew();
            int[] mass2 = Copy(array);
            mass2 = GnomeSort(mass2);
            stopWatchGnomia.Stop();
            double n2 = stopWatchGnomia.Elapsed.TotalMilliseconds;
            Print_Array(mass2);
            Console.WriteLine("\nВремя сортировки массива методом Гномья равно:{0}", n2);
            if (n2 < n1)
                Console.WriteLine("Гномья сортировка выполнилась быстрее Шелла на:{0}", n1 - n2);
            else
                Console.WriteLine("Шелли сортировка выполнилась быстрее Гномья на:{0}", n2 - n1);
        }
        /// <summary>
        /// вывод исходного массива
        /// </summary>
        /// <param name="array"></param>
        private void Print_Array(int[] array)
        {
            if (array.Length < 10)
            {
                Console.WriteLine("Ваш массив:");
                foreach (int i in array)
                    Console.Write("{0} ", i);
            }
            else
                Console.WriteLine("Нельзя вывести массив, так как его длина больше 10");
        }
    }
}
