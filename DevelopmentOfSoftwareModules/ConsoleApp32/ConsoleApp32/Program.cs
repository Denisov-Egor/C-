using System;

public interface Printable
{
    void Print();
}

public class Book : Printable
{
    public string Title;
    public string Author;

    public void Print()
    {
        Console.WriteLine($"Книга: {Title} автор {Author}");
    }
}

public class Magazine : Printable
{
    public string Title;
    public string Publisher;

    public void Print()
    {
        Console.WriteLine($"Журнал: {Title} опубликованно {Publisher}");
    }
}

class Program
{
    static void Main()
    {
        Printable[] items = new Printable[]
        {
            new Book { Title = "Head First. Изучаем C#", Author = "Эндрю Стиллмен, Дженнифер Грин" },
            new Magazine { Title = "Технологии Сегодня", Publisher = "XYZ Press" }
        };

        for (int i = 0; i < items.Length; i++)
        {
            items[i].Print();
        }
    }
}