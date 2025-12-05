using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MassivSort
    {   
        //создание поля для размера массива
        private int size;
        //создание поля для самого массива
        private int[] array;


        /// <summary>
        /// Главный метод для реализации сортировки массивов
        /// </summary>
        /// ///<param name="n"></param>
        ///<param name="mass1"></param>
        ///<param name="mass2"></param>
        ///<param name="n1"></param>
        ///<param name="n2"></param>
        ///<param name="answer"></param>
        public void OutputArray()
        {
            while (true)
            {
                //изначальный массив
                int[] n = RandomArray(InputMass());
                Print_Array(n);
                Console.WriteLine("\n");
                Console.WriteLine("Массив, отсортированный пузырьковым методом:");

                //запуск таймера для отслеживания времени сортировки
                var stopWatchBuble = Stopwatch.StartNew();
                //копирование массива
                int[] mass1 = CopyMass(n);
                //сортировка массива пузырьковым методом
                mass1 = BubbleSort(mass1);
                //окончание таймера
                stopWatchBuble.Stop();
                //переменная для записи времени сортировки
                double n1 = stopWatchBuble.Elapsed.TotalMilliseconds;
                //вывод массива на экран
                Print_Array(mass1);
                Console.WriteLine("\nВремя, потраченное на сортировку пузырьком: {0}", stopWatchBuble.Elapsed.TotalMilliseconds);

                Console.WriteLine("Массив, отсортированный методом выбора:");
                //запуск таймера для отслеживания времени сортировки
                var stopWatchInsert = Stopwatch.StartNew();
                //копирование массива
                int[] mass2 = CopyMass(n);
                //сортировка массива методом выбора
                mass2 = ViborSort(mass2);
                //окончание таймера
                stopWatchInsert.Stop();
                //переменная для записи времени сортировки
                double n2 = stopWatchInsert.Elapsed.TotalMilliseconds;
                //вывод массива на экран
                Print_Array(mass2);
                Console.WriteLine("\nВремя, потраченное на сортировку выбором: {0}", stopWatchInsert.Elapsed.TotalMilliseconds);

                if (n1 < n2)
                {
                    Console.WriteLine("Метод выбора выполнился быстрее пузырькового метода на {0}", n2 - n1);
                }
                else
                {
                    Console.WriteLine("Пузырьковый метод выполнился быстрее метода выбора на {0}", n1 - n2);
                }

                Console.Write("Хотите сделать еще один рассчет? (д/н): ");
                //ответ пользователя на вопрос хочет ли он сделать еще один рассчет
                string answer = Console.ReadLine().ToLower();
                while (answer != "д" && answer != "н")
                {
                    Console.WriteLine("Введите д или н");
                    answer = Console.ReadLine().ToLower();
                }
                Console.Clear();
                if (answer == "н")
                {
                    break;
                }
            }
        }


        /// <summary>
        /// Метод заполнения массива рандомными значениями
        /// </summary>
        ///<raturns></raturns>
        private int[] RandomArray(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10, 10);
            return a;
        }


        /// <summary>
        /// Метод ввода длины массива
        /// </summary>
        /// <param name="length">польщователь вводит длину массива</param>
        /// <returns> Возвращается значение длины </returns>
        private int InputMass()
        {
            Console.WriteLine("Введите длину массива");
            //польщователь вводит длину массива
            int length = CheckInput.iCheck();
            while (length < 0)
            {
                Console.WriteLine("Ошибка! Длина массива должна быть больше 0");
                length = CheckInput.iCheck();
            }
            return length;
        }


        /// <summary>
        /// Метод вывода массива на экран
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

        /// <summary>
        /// Метьод копирования массива
        /// </summary>
        /// <param name="UserArray"></param>
        /// <returns>Возвращается копия массива</returns>
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
        /// <param name="c"></param>
        /// <returns>Возвращается массив отсортированный пузырьковым методом</returns>
        private int[] BubbleSort(int[] c)
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
        /// <param name="c"></param>
        /// <returns>Возвращается массив, отсортированный сортировкой выбором</returns>
        private int[] ViborSort(int[] c)
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
        /// Конструктор без параметром для задания массива и его длины
        /// </summary>
        /// <param name="size"></param>
        /// <param name="array"></param>
        public Massiv()
        {
            size = 10;
            array = RandomArray(size);

        }


        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="Size">Размер массива</param>
        public Massiv(int Size)
        {
            if (Size > 0)
            {
                size = Size;
            }
            else
            {
                Console.WriteLine("Размер должен быть больше 0. Установлен размер по умолчанию: 10.");
                size = 10;
            }
            array = RandomArray(size);
        }
    }
}
