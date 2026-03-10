using System;

class Program
{
    static string ConvertToBase(int number, int baseN)
    {
        string result = "";

        if (baseN >= 2 && baseN < 10)
        {
            if (number < baseN)
            {
                result = number.ToString();
            }
            else
            {
                result = ConvertToBase(number / baseN, baseN) + (number % baseN).ToString();
            }
        }

        return result;
    }

    static void Main()
    {

        Console.Write("Введите число в десятичной системе: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите основание системы счисления (2-9): ");
        int baseN = int.Parse(Console.ReadLine());

        string result = ConvertToBase(decimalNumber, baseN);

        if (result != "")
        {
            Console.WriteLine("Результат:");
            Console.WriteLine(decimalNumber +  " в десятичной = " + result + " в системе счисления " + baseN);
        }
        else
        {
            Console.WriteLine("Ошибка: основание системы счисления должно быть от 2 до 9");
        }
    }
}