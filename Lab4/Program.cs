using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            bool ans = true;
            do
            {
                Console.WriteLine("====^_^==== МЕНЮ ====^_^====");
                Console.WriteLine("| Выберите действие         |");
                Console.WriteLine("| 1. Игра 'Угадайка'        |");
                Console.WriteLine("| 2. Об авторе              |");
                Console.WriteLine("| 3. Сортировка массивов    |");
                Console.WriteLine("| 4. Игра сапер             |");
                Console.WriteLine("| 5. Выход                  |");
                Console.WriteLine("====^_^==============^_^====");
                Console.WriteLine("Ваш выбор:");
                int input = iCheck();
                switch (input)
                {
                    case 1:
                        {
                            PlayGame();
                            break;
                        }
                    case 2:
                        {
                            ShowAuthor();
                            break;
                        }
                    case 3:
                        {
                            OutputArray();
                            break;
                        }
                    case 4:
                        {
                            Saper();
                            break;
                        }
                    case 5:
                        {
                            if (Exit() == false)
                                ans = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка! Нажмите любую клавишу...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
            while (ans == true);
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
            Console.WriteLine("До свидания!");
        }
        static int iCheck()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Ошибка! Введите число:");
            return number;
        }
        static double dCheck()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Ошибка! Введите число:");
            return number;
        }
        static void Ugadaika(double answer)
        {
            int guy_answer = iCheck();
            if (guy_answer != answer)
            {
                int counter = 1;
                while (counter < 3)
                {
                    if (guy_answer != answer)
                        Console.WriteLine("Неверно! Осталось попыток {0}", 3 - counter);
                    else
                    {
                        Console.WriteLine("Верно!");
                        break;
                    }
                    counter++;
                    guy_answer = iCheck();
                }
                if (counter == 3)
                    Console.WriteLine("Неверно! Осталось попыток {0}. Правильный ответ: {1}", 3 - counter, answer);
            }
            else
                Console.WriteLine("Верно!");
        }
        static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Введите число а");
            double correct_answer = Calculate();
            Console.WriteLine("Попробуйте отгадать ответ функции f = (sin(a)+tg(2a)/(sqrt(log3e2)");
            Console.WriteLine("У вас есть 3 попытки!");
            Ugadaika(correct_answer);

            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey();
            Console.Clear();
        }
        static double Calculate()
        {
            const double E = Math.E;
            double a = GetNumber();
            double f = (Math.Sin(a) + Math.Tan(2 * a)) / (Math.Sqrt(Math.Log(Math.Pow(E, 2), 3)));
            double answer = Math.Round(f);
            return answer;
        }
        static double GetNumber()
        {
            double a = dCheck();
            return a;
        }
        static void ShowAuthor()
        {
            Console.Clear();
            Console.WriteLine("Группа: 6106-090301D \nБарынкин Никита Викторович");
            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey();
            Console.Clear();
        }
        static bool Exit()
        {
            Console.Clear();
            Console.Write("Выйти? (д/н): ");
            string answer = Console.ReadLine().ToLower();
            while (answer != "д" && answer != "н")
            {
                Console.WriteLine("Введите д или н");
                answer = Console.ReadLine().ToLower();
            }
            Console.Clear();
            if (answer == "д")
                return false;
            else
                return true;
        }
        static int InputMass()
        {
            Console.WriteLine("Введите длину массива");
            int length = iCheck();
            while (length < 0)
            {
                Console.WriteLine("Ошибка! Длина массива должна быть больше 0");
                length = iCheck();
            }
            return length;
        }
        static int[] RandomArray(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10, 10);
            return a;
        }
        static void OutputArray()
        {
            while (true)
            {
                Console.Clear();
                int[] n = RandomArray(InputMass());
                Print_Array(n);
                Console.WriteLine("\n");
                Console.WriteLine("Массив, отсортированный пузырьковым методом:");

                var stopWatchBuble = Stopwatch.StartNew();
                int[] mass1 = CopyMass(n);
                mass1 = BubbleSort(mass1);
                stopWatchBuble.Stop();
                double n1 = stopWatchBuble.Elapsed.TotalMilliseconds;
                Print_Array(mass1);
                Console.WriteLine("\nВремя, потраченное на сортировку пузырьком: {0}", stopWatchBuble.Elapsed.TotalMilliseconds);

                Console.WriteLine("Массив, отсортированный методом выбора:");
                var stopWatchInsert = Stopwatch.StartNew();
                int[] mass2 = CopyMass(n);
                mass2 = ViborSort(mass2);
                stopWatchInsert.Stop();
                double n2 = stopWatchInsert.Elapsed.TotalMilliseconds;
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
        static void Print_Array(int[] array)
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
        static int[] CopyMass(int[] UserArray)
        {
            int[] copyArray = new int[UserArray.Length];
            for (int i = 0; i < UserArray.Length; i++)
            {
                copyArray[i] = UserArray[i];
            }
            return copyArray;
        }
        static int[] BubbleSort(int[] c)
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
        static int[] ViborSort(int[] c)
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
        static char[,] Pole()
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
        static void Print_Array(char[,] arr)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(j + " ");
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static char[,] MineCreate(char[,] array, int mineCount)
        {
            int counter = 0;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            var rnd = new Random();
            
            while (counter < mineCount)
            {
                int r = rnd.Next(row);
                int c = rnd.Next(col);
                if (array[r,c]!='*')
                {
                    array[r,c] = '*';
                    counter++;
                }
            }
            return array;
        }
        static char[,] Num(char[,] array)
        {
            int row = array.GetLength (0);
            int col = array.GetLength (1);

            for (int i = 0;i < row;i++)
            {
                for (int j = 0; j < col;j++)
                {
                    if (array[i, j] == '*') continue;

                    int mineCounter = 0;

                    for (int r = -1; r <= 1; r++)
                    {
                        for (int c = -1; c<=1; c++)
                        {
                            if (r == 0 && c == 0) continue;
                            int xr = i + r; int xc = j+c;

                            if (xr < 0 || xr >= row || xc < 0 || xc >= col) continue;

                            if (array[xr, xc] == '*') mineCounter++;
                        }
                    }
                    array[i, j] = (char)('0' + mineCounter);
                }
            }
            return array;
        }
        static int Coord()
        {
            int c = iCheck();
            bool flag = true;
            while (flag)
            {
                if (c < 0 || c > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Координаты существуют в диапазоне от 0 до 4");
                    c = iCheck();                   
                }
                else
                    flag = false;
            }
            return c;
        }
        static void Saper()
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
                        Console.WriteLine("Хотите сыграть еще раз? (да/нет)");
                        string answer = Console.ReadLine();
                        if (answer == "Да")
                            flag = true;
                        else if (answer == "Нет") flag = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите координату x (от 0 до 4)");
                        int x = Coord();
                        Console.WriteLine("Введите координату y (от 0 до 4)");
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
                            Console.WriteLine("Хотите сыграть еще раз? (да/нет)");
                            string answer = Console.ReadLine();
                            if (answer == "Да")
                                flag = true;
                            else if (answer == "Нет") flag = false;
                            break;
                        }
                    }
                }
            }
            
        }

    }   

}