using System;
using static System.Net.WebRequestMethods;

class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public string Genre { get; set; }

    public Movie(string title, int year, double rating, string genre)
    {
        Title = title;
        Year = year;
        Rating = rating;
        Genre = genre;
    }

    public void UpdateRating()
    {
        Console.Write($"Введите новый рейтинг для фильма '{Title}': ");
        double newRating;

        while (!double.TryParse(Console.ReadLine(), out newRating) || newRating < 0 || newRating > 10)
        {
            Console.WriteLine("Недопустимое значение. Пожалуйста, введите число от 0 до 10.");
            Console.Write($"Введите новый рейтинг для фильма '{Title}': ");
        }

        Rating = newRating;
        Console.WriteLine($"Рейтинг фильма '{Title}' успешно обновлен до {Rating}.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Рейтинг: {Rating}");
        Console.WriteLine($"Жанр: {Genre} рб");
    }
}

class Program
{
    static void Main()
    {
        Movie[] movies = new Movie[]
        {
            new Movie("Inception", 2010, 8.8, "Драма/Фэнтези"),
            new Movie("The Shawshank Redemption", 1994, 9.3, "Драма"),
            new Movie("Avatar", 2009, 7.8, "Экшн/Адвенчер"),
            new Movie("The Godfather", 1972, 9.2, "Драма")

        };

        foreach (Movie employee in movies)
        {
            Console.WriteLine();
            employee.DisplayInfo();
        }

        foreach (Movie movie in movies)
        {
            movie.UpdateRating();
        }
    }
}