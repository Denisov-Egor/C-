using System;

public class Reader
{
    public string Name;
    public int CardNumber;
    public string Faculty;
    public DateTime BirthDate;
    public string Phone;

    public Reader(string name, int cardNumber, string faculty, DateTime birthDate, string phone)
    {
        Name = name;
        CardNumber = cardNumber;
        Faculty = faculty;
        BirthDate = birthDate;
        Phone = phone;
    }

    public void takeBook(int numberOfBooks)
    {
        Console.WriteLine($"{Name} взял {numberOfBooks} книги");
    }

    public void takeBook(params string[] bookTitles)
    {
        string booksList = string.Join(", ", bookTitles);
        Console.WriteLine($"{Name} взял книги: {booksList}");
    }

    public void returnBook(int numberOfBooks)
    {
        Console.WriteLine($"{Name} вернул {numberOfBooks} книги");
    }

    public void returnBook(params string[] bookTitles)
    {
        string booksList = string.Join(", ", bookTitles);
        Console.WriteLine($"{Name} вернул книги: {booksList}");
    }

    public override string ToString()
    {
        return $"ФИО: {Name}, Номер билета: {CardNumber}, Факультет: {Faculty}, Дата рождения: {BirthDate.ToShortDateString()}, Телефон: {Phone}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Reader[] readers = new Reader[]
        {
        new Reader("Иванов И. И.", 1, "Факультет Кибернетики", new DateTime(2000, 9, 1), "1234567890"),
        new Reader("Петров В. В.", 2, "Факультет Физики", new DateTime(2001, 10, 2), "0987654321"),
        };

        for (int i = 0; i < readers.Length; i++)
        {
            Console.WriteLine($"Читатель №{i + 1}: {readers[i]}");
        }
    }
}
