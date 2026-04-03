class Book
{
    string Title;
    string Author;
    int Year;
    double Price;

    public Book(string title, string author, int year, double price)
    {
        Title = title;
        Author = author;
        Year = year;
        Price = price;
    }

    public void UpdatePrise()
    {
        Console.Write($"Введите новую цену для книги '{Title}': ");
        double newPrice;

        while (!double.TryParse(Console.ReadLine(), out newPrice))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
        }

        Price = newPrice;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Цена: {Price}");
    }
}

class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new Book("1984", "George Orwell", 1949, 15.99),
            new Book("1984", "George Orwell", 1949, 15.99),
            new Book("1984", "George Orwell", 1949, 15.99),
            new Book("1984", "George Orwell", 1949, 15.99),
        };

        foreach (Book book in books)
        {
            book.UpdatePrise();

            book.DisplayInfo();
            Console.WriteLine();
        }
    }
}
