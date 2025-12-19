using лаба_5_левина_оп;

namespace LAB_5
{
    class Program
    {
        static void Main()
        {
            bool ans = true;
            do
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Угадай ответ");
                Console.WriteLine("2. Об авторе");
                Console.WriteLine("3. Сортировка массива");
                Console.WriteLine("4. Игра");
                Console.WriteLine("5. Выход");
                int f = InputNumber.Chislo();
                switch (f)
                {
                    case 1:
                        {
                            Ygodaika1.Ugaday();
                            break;
                        }
                    case 2:
                        {
                            Avtor();
                            break;
                        }
                    case 3:
                        {
                            Array2 arr1 = new Array2();
                            arr1.Sort();
                            Array2 arr2 = new Array2(4);
                            arr2.Sort();                                                //создание экземпляра класса с параметром 4 и без параметра (33-37)
                            break;
                        }
                    case 4:
                        {
                            Game1.Game();  //вызываю гейм используя класс гейм1
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
                            Console.WriteLine("ОШИБКА, ВВедите чсисло заново");
                            f = InputNumber.Chislo();
                            f = InputNumber.Chislo();
                            break;
                        }

                }
            }
            while (ans == true);
        }
        static bool Exit()
        {
            Console.Clear();
            Console.WriteLine("Выйти да/нет");
            string answer = Console.ReadLine().ToLower();
            while (answer != "да" && answer != "нет")
            {
                Console.WriteLine("Ошибка. ВВедите да или нет");
                answer = Console.ReadLine().ToLower();
            }
            Console.Clear();
            if (answer == "да") return false;
            else return true;

        }
        static void Avtor()
        {
            Console.Clear();
            Console.WriteLine("Группа: 6105-090301D \nЛевина Ксения Андреевна");
            Console.WriteLine("Нажмите любую клавишу для выхода в меню");
            Console.ReadKey();
            Console.Clear();
        }
    }
}