using System;
using System.Collections.Generic;

class Contact
{
    public string Surname;
    public string Phone;

    public Contact(string surname, string phone)
    {
        Surname = surname;
        Phone = phone;
    }
}

class Page
{
    public char Letter;
    public List<Contact> Contacts;

    public Page(char letter)
    {
        Letter = letter;
        Contacts = new List<Contact>();
    }

    public void AddContact(string surname, string phone)
    {
        Contacts.Add(new Contact(surname, phone));
    }
}

class PhoneBook
{
    public List<Page> Pages;

    public PhoneBook()
    {
        Pages = new List<Page>();
    }

    public void AddContact(string surname, string phone)
    {
        char firstLetter = char.ToUpper(surname[0]);

        Page page = null;
        for (int i = 0; i < Pages.Count; i++)
        {
            if (Pages[i].Letter == firstLetter)
            {
                page = Pages[i];
                break;
            }
        }

        if (page == null)
        {
            page = new Page(firstLetter);
            Pages.Add(page);
        }

        page.AddContact(surname, phone);
    }

    public string FindPhone(string surname)
    {
        char firstLetter = char.ToUpper(surname[0]);

        // Ищем страницу
        for (int i = 0; i < Pages.Count; i++)
        {
            if (Pages[i].Letter == firstLetter)
            {
                // Ищем контакт прямо здесь, без отдельного метода
                for (int j = 0; j < Pages[i].Contacts.Count; j++)
                {
                    if (Pages[i].Contacts[j].Surname == surname)
                    {
                        return Pages[i].Contacts[j].Phone;
                    }
                }
            }
        }

        return "Контакт не найден";
    }
}

class Program
{
    static void Main()
    {
        PhoneBook book = new PhoneBook();

        book.AddContact("Ivanov", "+7-999-123-45-67");
        book.AddContact("Petrov", "+7-999-234-56-78");
        book.AddContact("Sidorov", "+7-999-345-67-89");
        book.AddContact("Smirnov", "+7-999-456-78-90");

        Console.WriteLine("Ivanov: " + book.FindPhone("Ivanov"));
        Console.WriteLine("Smirnov: " + book.FindPhone("Smirnov"));
        Console.WriteLine("Volkov: " + book.FindPhone("Volkov"));
    }
}