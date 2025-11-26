using System;
using System.Diagnostics;

namespace ConsoleApp5
{
    /// <summary>
    /// Главный метод (вызов меню)
    /// </summary>
    ///<param name="ans"></param>
    ///<param name="input"></param>
    class Program
    {
        static void Main()
        {
            //переменная булевского типа для выхода из цикла повтора меню
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

                //выбор пункта меню
                int input = CheckInput.iCheck();
                switch (input)
                {
                    case 1:
                        {
                            PlayGame.Game();
                            break;
                        }
                    case 2:
                        {
                            ShowAuthor();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Создание массива с параметром:");
                            //создание экземпляра класса MassiveSort с помощью конструктора с параметром
                            MassivSort arr1 = new MassivSort(7);
                            arr1.OutputArray();
                            //создание экземпляра класса MassiveSort с помощью конструктора без параметра
                            Console.WriteLine("Создание массива без параметров:");
                            MassivSort arr2 = new MassivSort();
                            arr2.OutputArray();
                            break;

                            break;
                        }
                    case 4:
                        {
                            Game.Saper();
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


        /// <summary>
        /// Метод вывода сведений об авторе (2 пункт меню)
        /// </summary>
        static void ShowAuthor()
        {
            Console.Clear();
            Console.WriteLine("Группа: 6106-090301D \nБарынкин Никита Викторович");
            Console.WriteLine("Нажмите любую клавишу для выхода в меню...");
            Console.ReadKey();
            Console.Clear();
        }


        /// <summary>
        /// Метод выхода из меню (5 пункт меню)
        /// </summary>
        ///<param name="answer"></param>
        ///<returns>Возвращемый ответ (да\нет) </returns>
        static bool Exit()
        {
            Console.Clear();
            Console.Write("Выйти? (д/н): ");
            // ответ пользователя
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
        

    }

}